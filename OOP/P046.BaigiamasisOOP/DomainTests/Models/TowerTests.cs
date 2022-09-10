using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Tests
{
    [TestClass()]
    public class TowerTests
    {
        [TestMethod()]
        public void SurastiVirsutinioDiskoIndeksa_TestTuscio()
        {
            // Arrange
            var expected = -1;
            Tower fakeBokstas = new Tower();

            // Act
            var actual = fakeBokstas.SurastiVirsutinioDiskoIndeksa();

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void SurastiVirsutinioDiskoIndeksa_TestPilno()
        {
            // Arrange
            var expected = 2;
            Tower fakeBokstas = new Tower(new int[] { 0, 0, 2, 3, 4 });

            // Act
            var actual = fakeBokstas.SurastiVirsutinioDiskoIndeksa();

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void SurastiVirsutinioDiskoIndeksa_TestPilnoBoksto()
        {
            // Arrange
            var expected = 4;


            Tower fakeBokstas = new Tower(new int[] { 0, 0, 0, 0, 4 });

            // Act
            var actual = fakeBokstas.SurastiVirsutinioDiskoIndeksa();

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void PadetiDiskaINaujaVietaTest()
        {
            var expected = false;


            Tower fakeBokstas = new Tower(new int[] { 4, 4, 4, 4, 4 });

            // Act
            var actual = fakeBokstas.PadetiDiskaINaujaVieta(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }

}