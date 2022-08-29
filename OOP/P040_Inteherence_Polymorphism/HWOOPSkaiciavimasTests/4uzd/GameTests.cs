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
    public class GameTests
    {
        [TestMethod()]
        public void GetHobbyInformationTest()
        {
            string expected1 = $"This Game genre is  PPS and this rating is: 9 made by Microsoft";
            Game fakeGame = new Game(1,3, true, "Quake", "Microsoft", "PPS", 9);  
            string actual1 = fakeGame.GetHobbyInformation();
            Assert.AreEqual(expected1, actual1);
        }
        


        [TestMethod()]
        public void GetHobbyNameTest()
        {
            string expected1 = $"Game";
            Game fakeGame = new Game();
            string actual1 = fakeGame.GetHobbyName();
            Assert.AreEqual(expected1, actual1);
        }


      



    }
}