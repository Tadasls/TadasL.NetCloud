using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using PresentC2invoice.Models;


namespace PresentC2invoice.Service.Tests
{
    [TestClass]
    public class InvoiceServiceTests
    {
        [TestMethod]
        public void CalculateVAT_WhenProviderIsNotVatPayer_ShouldBeZero_Test() //ok if provider is not Company  gives 0
        {
            // Arrange
            var mockCustomer = Substitute.For<ICustomer>();

            var mockServiceProvider = Substitute.For<ICompany>();
            mockServiceProvider.IsVATPayer.Returns(false);

            var sut = new InvoiceService(mockCustomer, mockServiceProvider);

            // Act
            var result = sut.CalculateVAT(mockCustomer, mockServiceProvider, 100);

            // Assert
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        public void CalculateVAT_WhenCustomerisOutsideEU_ShouldBeZero_Test() // ok when Customer is not from EU gives 0
        {
            // Arrange
            var mockCustomer = Substitute.For<ICustomer>();
            mockCustomer.Country.Returns("USA");

            var mockServiceProvider = Substitute.For<ICompany>();
            mockServiceProvider.IsVATPayer.Returns(true);

            var sut = new InvoiceService(mockCustomer, mockServiceProvider);

            // Act
            var result = sut.CalculateVAT(mockCustomer, mockServiceProvider, 100);

            // Assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void CalculateVAT_WhenCustomerIsEuCompany_ShouldBeZero_Test() // ok with Provider VAT when customer EU bot not VAT payer
        {
            // Arrange
            var mockCustomer = Substitute.For<ICustomer>();
            mockCustomer.Country.Returns("Spain");
            mockCustomer.IsVATPayer.Returns(true);

            var mockServiceProvider = Substitute.For<ICompany>();
            mockServiceProvider.IsVATPayer.Returns(true);
            mockServiceProvider.Country.Returns("Lithuania");

            var sut = new InvoiceService(mockCustomer, mockServiceProvider);

            // Act
            var result = sut.CalculateVAT(mockCustomer, mockServiceProvider, 100);

            // Assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void CalculateVAT_WhenCustomerNotPayVAT_ShouldBeVATValue_Test() // ok whencustomer EU Company but different countries gives 0
        {
            // Arrange
            var mockCustomer = Substitute.For<ICustomer>();
            mockCustomer.Country.Returns("Spain");
            mockCustomer.IsVATPayer.Returns(false);

            var mockServiceProvider = Substitute.For<ICompany>();
            mockServiceProvider.IsVATPayer.Returns(true);
            mockServiceProvider.Country.Returns("Lithuania");


            var sut = new InvoiceService(mockCustomer, mockServiceProvider);

            // Act
            var result = sut.CalculateVAT(mockCustomer, mockServiceProvider, 100);

            // Assert
            Assert.AreEqual(15m, result);
        }
        [TestMethod]
        public void CalculateVAT_IfSameCountry_ShouldBeVATValue_Test() //ok if same Country
        {
            // Arrange
            var mockCustomer = Substitute.For<ICustomer>();
            mockCustomer.Country.Returns("Lithuania");

            var mockServiceProvider = Substitute.For<ICompany>();
            mockServiceProvider.Country.Returns("Lithuania");
            mockServiceProvider.IsVATPayer.Returns(true);

            var sut = new InvoiceService(mockCustomer, mockServiceProvider);

            // Act
            var result = sut.CalculateVAT(mockCustomer, mockServiceProvider, 100);

            // Assert
            Assert.AreEqual(21m, result); //nes default grazina 0 reikia pertestuoti

        }
        [TestMethod]
        public void CalculateVATForCountry_TestVATCalculationsForLithuania_test() //ok expecting 21
        {
            // Arrange
            decimal orderAmount = 100.00m;
            decimal expectedVAT = 21.00m;
            var fakeCountry = "Lithuania";

            var mockCustomer = Substitute.For<ICustomer>();
            var mockServiceProvider = Substitute.For<ICompany>();
            var sut = new InvoiceService(mockCustomer, mockServiceProvider);

            // Act
            decimal actualVAT = sut.CalculateVATForCountry(fakeCountry, orderAmount);
            // Assert
            Assert.AreEqual(expectedVAT, actualVAT);
        }
        [TestMethod]
        public void CalculateVATForCountry_TestVATIfNotLithuania_Test() //ok expecting 15
        {
            // Arrange
            decimal fakeOrderAmount = 100.00m;
            decimal expectedVAT = 15.00m;
            var fakeCountry = "Other";

            var mockCustomer = Substitute.For<ICustomer>();
            var mockServiceProvider = Substitute.For<ICompany>();
            var sut = new InvoiceService(mockCustomer, mockServiceProvider);

            // Act
            decimal actualVAT = sut.CalculateVATForCountry(fakeCountry, fakeOrderAmount);
            // Assert
            Assert.AreEqual(expectedVAT, actualVAT);
        }
        [TestMethod]
        public void CalculateVAT_WithBothMedods_Test()
        {
            //Arrange
            decimal orderAmount = 100.00m;
            var mockCustomer = Substitute.For<ICustomer>();
            mockCustomer.Country.Returns("Spain");

            var mockServiceProvider = Substitute.For<ICompany>();
            mockServiceProvider.IsVATPayer.Returns(true);
            mockServiceProvider.Country.Returns("Spain");

            var sut = new InvoiceService(mockCustomer, mockServiceProvider);


            // Act
            decimal expectedVAT = sut.CalculateVATForCountry("Spain", orderAmount);
            decimal actualVAT = sut.CalculateVAT(mockCustomer, mockServiceProvider, orderAmount);

            // Assert
            Assert.AreEqual(expectedVAT, actualVAT);
        }
        [TestMethod]
        public void IsCountryInEU_WhenCountryIsInEU_ReturnsTrue_Test()
        {
            // Arrange
            var mockCustomer = Substitute.For<ICustomer>();
            var mockServiceProvider = Substitute.For<ICompany>();
            var sut = new InvoiceService(mockCustomer, mockServiceProvider);

            string fakeCountry = "Germany";

            // Act
            bool result = sut.IsCountryInEU(fakeCountry);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsCountryInEU_WhenCountryIsNotInEU_ReturnsFalse_Test()
        {
            // Arrange
            var mockCustomer = Substitute.For<ICustomer>();
            var mockServiceProvider = Substitute.For<ICompany>();
            var sut = new InvoiceService(mockCustomer, mockServiceProvider);

            string fakeCountry = "United States";

            // Act
            bool result = sut.IsCountryInEU(fakeCountry);

            // Assert
            Assert.IsFalse(result);



        }



    }
}






