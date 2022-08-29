using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWOOPSkaiciavimas._4uzd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._4uzd.Tests
{
    [TestClass()]
    public class MovieTests
    {
        [TestMethod()]
        public void GetHobbyInformationTest()
        {
            string expected1 = $"This Movie made by Disney in Fantasy gendre has this rating: 9 ";
            Movie fakeFilmas = new Movie()
            {
                Id = 1,
                Name = "Matrix",
                Genre = "Fantasy",
                Publisher = "Disney",
                Rating = 9,
                CreationDate = DateTime.Now,
            };
            string actual1 = fakeFilmas.GetHobbyInformation();
            Assert.AreEqual(expected1, actual1);
        }

        [TestMethod()]
        public void GetHobbyNameTest()
        {
            string expected1 = $"Movie";
            Movie fakeMovie = new Movie();
            string actual1 = fakeMovie.GetHobbyName();
            Assert.AreEqual(expected1, actual1);
        }
    }
}