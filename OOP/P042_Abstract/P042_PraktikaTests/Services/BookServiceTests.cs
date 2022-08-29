﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Novele.Base.InitialData;
using P042_Praktika.Enums;
using P042_Praktika.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P042_Praktika.Services.Tests
{
    [TestClass()]
    public class BookServiceTests
    {



        [TestMethod()]
        public void DecodeTest()
        {
            BookService service = new BookService();
            var actual = service.Decode(BookInitialData.DataSeedHtml);

            Assert.AreEqual(4, actual.Count);
            Assert.AreEqual(4, actual[BookType.Ebook].Count);
            Assert.AreEqual(9, actual[BookType.Audio].Count);
            Assert.AreEqual(10, actual[BookType.Hardcover].Count);
            Assert.AreEqual(8, actual[BookType.Paperback].Count);
        }



       


    }
}