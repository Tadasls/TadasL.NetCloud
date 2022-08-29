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
    public class MusicTests
    {
        [TestMethod()]
        public void GetHobbyInformationTest()
        {
            string expected1 = $"This Company BombaRecords made Song which genre is Pop and this rating is: 5 ";
            Music fakeDaina = new Music()
            {
                Name = "Let it Be",
                Genre = "Pop",
                Publisher = "BombaRecords",
                Rating = 5,
            };


            string actual1 = fakeDaina.GetHobbyInformation();
            Assert.AreEqual(expected1, actual1);
        }

        [TestMethod()]
        public void GetHobbyNameTest()
        {
            string expected1 = $"Music";
            Music fakeMusic = new Music();
            string actual1 = fakeMusic.GetHobbyName();
            Assert.AreEqual(expected1, actual1);
        }
    }
}