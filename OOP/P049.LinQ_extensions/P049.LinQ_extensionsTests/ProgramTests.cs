using Microsoft.VisualStudio.TestTools.UnitTesting;
using P51_LINQ_Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P51_LINQ_Query.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void LyginiaiSkaiciaiTest()
        {


            var actual = Program.LyginiaiSkaiciai();
            var expected = new int[] { 0, 2, 4, 6, 8 };
            CollectionAssert.AreEqual(expected, actual);




        }

        [TestMethod()]
        public void ivairusSkaiciaiTest()
        {
            var actual = Program.ivairusSkaiciai();
            var expected = new int[] { 1, 3, 12, 19, 6, 9, 10, 14 };
            CollectionAssert.AreEqual(expected, actual);


        }
    }
}