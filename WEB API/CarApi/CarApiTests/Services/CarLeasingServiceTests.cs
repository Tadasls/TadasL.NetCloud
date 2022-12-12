using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApi.Services.Tests
{
    [TestClass]
    public class CarLeasingServiceTests
    {

        [AssemblyInitialize]
        public static void MyAssemblyInitialize(TestContext context)
        {

        }

        [ClassInitialize]
        public static void MyClassInitilize (TestContext context) 
        {
            
        }

        [TestInitialize]
        public void MyTestInialize() 
        {

        }


        [TestMethod()]
        public void AddPriceTest()
        {

            var sut = new CarLeasingService();   // sut = service under test
            var actual = sut.AddPrice(100, 10);
              var expected = 110;
            Assert.AreEqual(expected, actual);
            
        }


        [TestMethod()]
        public void CarLease()
        {
            var sut = new CarLeasingService();
            Assert.ThrowsException<NotImplementedException>(() => sut.CanLease(1));
        }






    }
}