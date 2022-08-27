using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWOOPSkaiciavimas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas.Tests
{
    [TestClass]
    public class Skaicius_tests
    {
        [TestMethod]
       public void UzdavinioTestas()
        {
            var actual = new Skaicius(3);
            var expected = 3;
            Assert.AreEqual(actual.Reiksme, expected);
        }

        [TestMethod]
        public void DefinedConstruktorTest()
        {
            var actual = new Skaicius(5);
            int expected = 5;
            Assert.AreEqual(expected, actual.Reiksme);
        }



        [TestMethod]
        public void PakeltiKubu_test()
        {
            var actual = new Skaicius(2);

            int expected = 8;
            // 2 ^3 = 8
            Assert.AreEqual(expected, actual.PakeltiKubu());
        }

        [TestMethod]
        public void PakeltiKvadratu_test()
        {
            var actual = new Skaicius(5);

            int expected = 25;
            // 5 ^2 = 25
            Assert.AreEqual(expected, actual.PakeltiKvadratu());
        }

        [TestMethod]
        public void Sumos_test()
        {
            int expected = 10;
            Skaicius penketukas = new Skaicius(5);
            int actual = penketukas.Prideti(5);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Skirtumo_test()
        {
            int expected = 7;
            IMatematika penketukas = new Skaicius(10);
            int actual = penketukas.Atimti(3);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Dalybos_test()
        {
            int expected = 2;
            Skaicius penketukas = new Skaicius(8);
            double actual = penketukas.Padalinti(4);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Daugybos_test()
        {
            int expected = 25;
            Skaicius penketukas = new Skaicius(5);
            double actual = penketukas.Padauginti(5);

            Assert.AreEqual(expected, actual);
        }




    }
}