using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangMan;


namespace Metodu_Testai
{
    [TestClass]
    public class HWKartuvesTest
    {

        [TestMethod]
        public void AtsitiktineGeneracija()
        {
            var fakeWords = new List<string> { "Akvile", "Titas", "Tadas", "Kristina", "Dainius", "Stasys", "Lina", "Merunas", "Jolanta", "Justinas" };
            var fakeRandom = new Random(1);
            var expected = fakeWords[fakeRandom.Next(0, fakeWords.Count)];

            var actual = Program.AtsitiktineGeneracija(fakeWords);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void arLeistiniSimboliai_Test()
        {
            var fake = "1";
            var expected = false;

            var actual = Program.NeleistinoSimbolioIrRaidesPasikartojimoValidacija(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void arLeistiniSimboliai_Test2()
        {
            var fake = "A";
            var expected = true;

            var actual = Program.NeleistinoSimbolioIrRaidesPasikartojimoValidacija(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void arLeistiniSimboliai_Test3()
        {
            var fake = "W";
            var expected = false;
            var actual =Program.NeleistinoSimbolioIrRaidesPasikartojimoValidacija(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZodzioSpejimoTikrinimas_Test()
        {
            var fake = "a";
            var expected = false;
            var actual = Program.ZodzioSpejimoTikrinimas(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PavaizduojaSpejamoZodzioIlgiBruksneliais()
        {
            char[] fake = { 't', 'a', 'd', 'a', 's' };
            string expected = "-----";
            var actual = Program.PavaizduojaSpejamoZodzioIlgiBruksneliais(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SukuriasIrUzpildoSpejamuRaidziuMasyva_Test()
        {
            var fake = "Tadas" ;
            var expected = "False, False, False, False, False";
            var actual = Program.SukuriasIrUzpildoSpejamuRaidziuMasyva(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AtspetuRaidziuRodymas_Test()
        {
            char[] fake = { 't', 'a', 'd', 'a', 's' };
            bool[] fake2 = { true, true, true, true, true };
            bool[] expected = { true, true, true, true, true };
            var actual = Program.AtspetuRaidziuRodymas(fake, fake2);
            CollectionAssert.AreEqual(expected, actual);    
          
        }




    }
}
