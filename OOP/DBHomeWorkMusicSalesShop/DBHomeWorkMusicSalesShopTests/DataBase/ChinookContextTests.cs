using Microsoft.VisualStudio.TestTools.UnitTesting;
using DBHomeWorkMusicSalesShop.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using DBHomeWorkMusicSalesShop.Models;

namespace DBHomeWorkMusicSalesShop.DataBase.Tests
{
    [TestClass()]
    public class ChinookContextTests
    {
        private ChinookContext context;

        [TestInitialize]
        public void OnInit()
        {
            var options = new DbContextOptionsBuilder<ChinookContext>()
                .UseInMemoryDatabase(databaseName: "Customer")
                .Options;
            context = new ChinookContext(options);
            context.Customers.Add(new Customer { CustomerId = 1, FirstName = "Tomas71", LastName = "Testeris", Email = "Testeris" });
            context.Customers.Add(new Customer { CustomerId = 2, FirstName = "Tomas72", LastName = "Testeris", Email = "Testeris" });
            context.Customers.Add(new Customer { CustomerId = 3, FirstName = "Tadas", LastName = "Laurinaitis", Email = "Tadas.Laurinaitis@gmail.com" });
            context.Customers.Add(new Customer { CustomerId = 4, FirstName = "Tomas74", LastName = "Testeris", Email = "Testeris" });
            context.SaveChanges();
        }



        [TestMethod()]
        public void AddCustomerTest()
        {
            var cust = context.Customers.Find(1L);
            cust.FirstName = "Tadas";
            context.SaveChanges();

            Assert.IsTrue(context.Customers.Any(x => x.FirstName == "Tadas"));
            Assert.IsTrue(context.Customers.Any(x => x.FirstName == "Tomas74"));
            Assert.IsFalse(context.Customers.Any(x => x.FirstName == "Tadas83"));
        }
    }
}