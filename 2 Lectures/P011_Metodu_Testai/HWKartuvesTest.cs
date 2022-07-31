using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SNamDarbas_Kartuves_HangMan;


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
            var actual = SNamDarbas_Kartuves_HangMan.Program.NeleistinoSimbolioIrRaidesPasikartojimoValidacija(fake);
            Assert.AreEqual(expected, actual);
        }
[       TestMethod]
        public void ZodzioSpejimoTikrinimas()
        {
            Program.zodisSpejimui = "tadas";
            var fake = "linas";
            var expected = false;
            var actual = Program.ZodzioSpejimoTikrinimas(fake);
            Assert.AreEqual(expected, actual);
        }


    





    }
}
