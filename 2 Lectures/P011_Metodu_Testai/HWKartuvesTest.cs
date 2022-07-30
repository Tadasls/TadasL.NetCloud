//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using SNamDarbas_Kartuves_HangMan;

//namespace Metodu_Testai
//{
//    [TestClass]
//    public class HWKartuvesTest
//    {
//        [TestMethod]
//        public void AtsitiktineGeneracija_test()
//        {
//            SNamDarbas_Kartuves_HangMan.arZodisAtspetas = true;
//            SNamDarbas_Kartuves_HangMan.AtsitiktineGeneracija();
//            var expected = false;
//            var actual = SNamDarbas_Kartuves_HangMan.xxxxxxxxx;
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void NaujasZaidimas_AtstatoPanaudotosRaides()
//        {
//            Kartuves.panaudotosRaides = new List<char> { 't', 'e', 's', 't' };
//            Kartuves.NaujasZaidimas();
//            var expected = 1;
//            var actual = Kartuves.panaudotosRaides.Count;
//            Assert.AreEqual(expected, actual);
//        }

//        [TestMethod]
//        public void TemuMeniu_GrazinaTemas()
//        {
//            Kartuves.zodziuTemos = new Dictionary<string, string[]>
//            {
//                {"test1", new string[] {"t1", "t2"} },
//                {"test2", new string[] {"t1", "t2"} },
//                {"test3", new string[] {"t1", "t2"} }
//            };
//            var expected = "1. TEST1" + Environment.NewLine
//                + "2. TEST2" + Environment.NewLine
//                + "3. TEST3" + Environment.NewLine;
//            var actual = Kartuves.TemuMeniu();
//            Assert.AreEqual(expected, actual);
//        }

//        [TestMethod]
//        public void IsrinktiZodi_GrazinaFalseKaiNeraZodziu()
//        {
//            Kartuves.panaudotiZodziai = new List<string> { "test1", "test2" };
//            var fake = new string[] { "test1", "test2" };
//            var expected1 = false;
//            string expected2 = null;
//            var actual1 = Kartuves.IsrinktiZodi(fake, out var actual2);
//            Assert.AreEqual(expected1, actual1);
//            Assert.AreEqual(expected2, actual2);
//        }

//        [TestMethod]
//        public void IsrinktiZodi_GrazinaAtsitiktiniZodi()
//        {
//            Kartuves.panaudotiZodziai = new List<string> { "test1" };
//            var fake = new string[] { "test1", "test2", "test3" };
//            var expected1 = true;
//            var expected2 = new string[] { "test2", "test3" };
//            var actual1 = Kartuves.IsrinktiZodi(fake, out var actual2);
//            Assert.AreEqual(expected1, actual1);
//            Assert.IsTrue(expected2.Contains(actual2));
//        }

//        [TestMethod]
//        public void GrazintiKlaidingasRaides_GrazinaKlaidinguRaidziuSarasa()
//        {
//            Kartuves.zodzioRaides = new List<char> { 'a', 'b', 'c' };
//            Kartuves.panaudotosRaides = new List<char> { 'c', 'd', 'e' };
//            var expected = new List<char> { 'd', 'e' };
//            var actual = Kartuves.GrazintiKlaidingasRaides();
//            CollectionAssert.AreEqual(expected, actual);
//        }

//        [TestMethod]
//        public void PatikrintiArZodisAtspetas_NustatoTrueJeiAtspetas()
//        {
//            Kartuves.arZodisAtspetas = false;
//            Kartuves.zodzioRaides = new List<char> { 'a', 'b', 'c' };
//            Kartuves.panaudotosRaides = new List<char> { 'a', 'b', 'c', 'd', 'e' };
//            var expected = true;
//            Kartuves.PatikrintiArZodisAtspetas();
//            Assert.AreEqual(expected, Kartuves.arZodisAtspetas);
//        }

//        [TestMethod]
//        public void PatikrintiArZodisAtspetas_NenustatoTrueJeiNeatspetas()
//        {
//            Kartuves.arZodisAtspetas = false;
//            Kartuves.zodzioRaides = new List<char> { 'a', 'b', 'c' };
//            Kartuves.panaudotosRaides = new List<char> { 'a', 'c', 'd', 'e' };
//            var expected = false;
//            Kartuves.PatikrintiArZodisAtspetas();
//            Assert.AreEqual(expected, Kartuves.arZodisAtspetas);
//        }

//        [TestMethod]
//        public void GrazintiSpejamaZodi_GrazinaAtspetasRaides()
//        {
//            Kartuves.zodzioRaides = new List<char> { 'a', 'b', 'c' };
//            Kartuves.panaudotosRaides = new List<char> { 'a', 'c', 'd', 'e' };
//            var expected = "a _ c";
//            var actual = Kartuves.GrazintiSpejamaZodi();
//            Assert.AreEqual(expected, actual);
//        }


//    }
//}
