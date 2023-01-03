using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameRunner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace GameRunner.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void RunTest1()
        {
            string filePath = @"TestData\map2.txt";
            int expected = 13;
            Game fakeMaze = new Game();
            int actual = fakeMaze.Run(filePath);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void RunTest2()
        {
            string filePath = @"TestData\map1.txt";
            int expected = 4;
            Game fakeMaze = new Game();
            int actual = fakeMaze.Run(filePath);
            Assert.AreEqual(expected, actual);
        }
    }
}