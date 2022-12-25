using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppMSSQL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMSSQL.Models.DTO.BookDTO;
using WebAppMSSQL.Models;
using System.Collections;
using WebAppMSSQL.Models.Enums;
using Microsoft.AspNetCore.Routing;
using WebAppMSSQL.Services.IServices;
using WebAppMSSQL.Services.Wraperiai;

namespace WebAppMSSQL.Services.Tests
{
    [TestClass()]
    public class BookWrapperTests
    {
  
    [TestMethod]
     public void Bind_GivenValidCreateBookDto_ReturnsExpectedBook()
            {
                // Arrange
                var createBookDto = new CreateBookDto
                {
                    Pavadinimas = "The Great Gatsby",
                    Autorius = "F. Scott Fitzgerald",
                    Isleista = new DateTime(1925, 4, 10),
                    KnyguKiekis = 5,
                    KnygosTipas = "Hardcover"
                };

                var bookBinder = new BookWrapper();

                // Act
                var book = bookBinder.Bind(createBookDto);

                // Assert
                Assert.AreEqual("The Great Gatsby", book.Title);
                Assert.AreEqual("F. Scott Fitzgerald", book.Author);
                Assert.AreEqual(1925, book.PublishYear);
                Assert.AreEqual(5, book.Stock);
                Assert.AreEqual(ECoverType.Hardcover, book.ECoverType);
            }


        //[TestMethod()]
        //public void BindTest()
        //{
        //    var fakeBook = new CreateBookDto
        //    {
        //        Pavadinimas = "The Great Gatsby",
        //        Autorius = "F. Scott Fitzgerald",
        //        Isleista = new DateTime(1925, 4, 10),
        //        KnyguKiekis = 5,
        //        KnygosTipas = "Hardcover"
        //    };

        //    var expected = new Book()
        //    {
        //        Title = "The Great Gatsby",
        //        Author = "F. Scott Fitzgerald",
        //        PublishYear = 1925,
        //        Stock = 5,
        //        ECoverType = ECoverType.Hardcover,
        //    };

        //    var sut = new BookWrapper();
        //    var actual = sut.Bind(fakeBook);

        //    Assert.AreEqual(expected, actual);

        //}










    }

}









