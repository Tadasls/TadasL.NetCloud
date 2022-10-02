using Microsoft.VisualStudio.TestTools.UnitTesting;
using DBHomeWorkMusicSalesShop.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.Reflection.Metadata;
using DBHomeWorkMusicSalesShop.Models;
using DBHomeWorkMusicSalesShop.Services;

namespace DBHomeWorkMusicSalesShop.DataBase.Tests
{
    [TestClass()]
    public class MusicShopServicesTests
    {
        private Mock<ChinookRepository> mock_MusicShopServices = new Mock<ChinookRepository>();

        [TestMethod()]
        public void AddCustomerTest()
        {
             MusicShopServices manageDb = new MusicShopServices();
            mock_MusicShopServices.Setup(c => c.GetCustomers()).Returns(
                new List<Customer>
                {
                        new Customer { CustomerId = 1, FirstName = "Tadas", LastName = "Laurinaitis" , Email = "Tadas.laurinaitis@gmail.com"}
            }
            );

            MusicShopServices service = new MusicShopServices(mock_MusicShopServices.Object);
            var actual = service.GautiKlientus();


            Assert.IsTrue(actual.Any(x => x.Name == "Tadas"));
        }
    }
}