using Microsoft.VisualStudio.TestTools.UnitTesting;
using P045_Generics.Domain.Interfaces;
using P045_Generics.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generics.Domain.Models.Tests
{
    [TestClass()]
    public class CordinateTests
    {
        [TestMethod()]
        public void GetCordinateTest()
        {
            var expected = "0;0";
            Cordinate<int> intKoordinate = new Cordinate<int>();
            var actual = intKoordinate.GetCordinate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCordinateTest2()
        {
            var expected = "5;5";
            Cordinate<int> intKoordinate = new Cordinate<int>(5,5);
            var actual = intKoordinate.GetCordinate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ResetCordinateTest()
        {
            ICordinate intKoordinate = new Cordinate<int>();
            intKoordinate.ResetCordinate(); 

            var expected = "0;0";
            var actual = intKoordinate.GetCordinate();

            Assert.AreEqual(expected, actual);
        }




    }
}