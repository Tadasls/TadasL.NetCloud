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
    public class PersonTests
    {
        [TestMethod()]
        public void GetFavoriteHobbyType_Test()
        {
            string expected1 = $"Matrix";
            Person fakePerson = new Person(5, "Billas", "Geitsas");
            Movie fakeFilmas = new Movie()
            {
                Id = 1,
                Name = "Matrix",
                Genre = "Fantasy",
                Publisher = "Disney",
                Rating = 9,
                CreationDate = DateTime.Now,
            };

            string actual1 = fakePerson.GetFavoriteHobbyType(fakeFilmas);
            Assert.AreEqual(expected1, actual1);

        }


        [TestMethod()]
        public void GetFavoriteHobbyTest()
        {
            string expected1 = $"This Movie made by Disney in Fantasy gendre has this rating: 9 ";

            Person fakePerson = new Person(5, "Billas", "Geitsas");
            
            Movie filmas = new Movie()
            {
                Id = 1,
                Name = "Matrix",
                Genre = "Fantasy",
                Publisher = "Disney",
                Rating = 9,
                CreationDate = DateTime.Now,
            };
            Music daina = new Music()
            {
                Name = "Let it Be",
                Genre = "Pop",

            };
            Game zaidimas = new Game()
            {
                Name = "WOT",
                Genre = "PPS",

            };
            List<IHobby> MegstamiDalykai = new List<IHobby>() { filmas, daina, zaidimas };

            string actual1 = fakePerson.GetFavoriteHobby(MegstamiDalykai);
            Assert.AreEqual(expected1, actual1);

        }

       

   




    }
}