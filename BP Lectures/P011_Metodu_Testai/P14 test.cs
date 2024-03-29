﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_Metodu_Testai
{
    [TestClass]
    public class P014_Debug_Tests
    {
        [TestMethod]
        public void DecimalHour_Test()
        {
            var fake = "30.30";
            var expected = "Decimal hour: 30.5000";
            var actual = P014_Debuginimas.Program.DecimalHour(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecimalHour_Test1()
        {
            var fake = "20.30.30";
            var expected = "Decimal hour: 20.5083";
            var actual = P014_Debuginimas.Program.DecimalHour(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecimalHour_Test2()
        {
            var fake = "20";
            var expected = "Invalid time";
            var actual = P014_Debuginimas.Program.DecimalHour(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DecimalHour_Test3()
        {
            var fake = "-20.50";
            var expected = "Invalid hours";
            var actual = P014_Debuginimas.Program.DecimalHour(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SkaiciuotuvoTestas_01()
        {
            //fakes
            var a = 3;
            var b = 2;
            //expected
            var expected = 1.5;
            //actual
            var actual = P014_Debuginimas.Program.Skaiciuotuvas(a, b, "/");
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void PlotoTestas_001()
        {
            //fakes
            var fake = 4;
            //expected
            var expected = 16;
            //actual
            var actual = P014_Debuginimas.Program.KeturkampioPlotas(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlotoTestas_002()
        {
            //fakes
            var b = 2;
            var r = 2;
            var n = 2;
            //expected
            var expected = 4;
            //actual
            var actual = P014_Debuginimas.Program.DaugiakampioPlotas(n, b, r);
            Assert.AreEqual(expected, actual);
        }

        

    }
}