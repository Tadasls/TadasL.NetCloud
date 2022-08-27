using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWOOPSkaiciavimas._2uzd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._2uzd.Tests
{
    [TestClass()]
    public class StaciakampisTests
    {
        [TestMethod()]
        public void Perimetras_NiekoNeperduodame_KvadratoPerimetras()
        {
            int expected = 14;
            Staciakampis staciakampis = new Staciakampis(2, 5);
            double actual = staciakampis.Perimetras();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Ploto_Testavimas()
        {
            int expected = 10;
            Staciakampis staciakampis = new Staciakampis(2, 5);
            double actual = staciakampis.Plotas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PerimetrasTestKvadratui()
        {
            int expected = 8;
            Kvadratas kvadratas = new Kvadratas(2);
            double actual = kvadratas.Perimetras();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PlotasTestKvadratui()
        {
            int expected = 4;
            Kvadratas kvadratas = new Kvadratas(2);
            double actual = kvadratas.Plotas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PlotasTestApskritimui()
        {
            double expected = 50.24;
            Apskritimas apskritimas = new Apskritimas(4);
            double actual = apskritimas.Plotas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PerimetrasTestApskritimui()
        {
            double expected = 25.12;
            Apskritimas apskritimas = new Apskritimas(4);
            double actual = apskritimas.Perimetras();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StatTrikampisPerimetrasTest1()
        {
            double expected = 6;
            StatusisTrikampis statusisTrikampis = new StatusisTrikampis(1,2,3);
            double actual = statusisTrikampis.Perimetras();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StatTrikampisPlotasTest1()
        {
            double expected = 1;
            StatusisTrikampis statusisTrikampis = new StatusisTrikampis(1,2,3);
            double actual = statusisTrikampis.Plotas();

            Assert.AreEqual(expected, actual);
        }

    }
}