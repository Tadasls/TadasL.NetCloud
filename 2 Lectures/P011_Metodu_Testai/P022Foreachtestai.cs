using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_Metodu_Testai
{
    [TestClass]
    public class P022Foreachtest
    {
        [TestMethod]
        public void ApskaiciuotiVidurki()
        {
            var fake = new List<double> { 1, 5, 8, 9, 8, 5 };
            int expected = 6;
            var actual = P022_Foreach.Program.ApskaiciuotiVidurki(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TikrintiSkaiciausTeigiamuma()
        {
            var teigiamoTekstas = "Teigiamas";
            var neigiamoTekstas = "Neigiamas";
            var fake = new List<int> { 5, -1, 0, 8, -5 };
            var expected = new List<string> { teigiamoTekstas, neigiamoTekstas, teigiamoTekstas, teigiamoTekstas, neigiamoTekstas };
            var actual = P022_Foreach.Program.TikrintiSkaiciausTeigiamuma(fake);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ApskaiciuotiGPM()
        {
            var gpm = 15;
            var fake = new List<double>() { 100, 150, 188, 88, 69, 200 };
            var expected =  119.25;
            var actual = P022_Foreach.Program.ApskaiciuotiGPM(fake, gpm);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void IstrauktiSkaicius()
        {

            var fake = "sd512sd5";
            var expected = "5125";
            var actual = P022_Foreach.Program.IstrauktiSkaicius(fake);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void SurikiuotiSkaiciusIsTeksto_Test()
        {
            var fake = "518421";
            var expected = new List<int>() { 1, 1, 2, 4, 5, 8 };
            var actual = P022_Foreach.Program.SurikiuotiSkaiciusIsTeksto(fake);

            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void IstrauktiSkaiciusIrSurikiuotiSkaiciusIsTeksto_Test()
        {
            var fake = P022_Foreach.Program.IstrauktiSkaicius("sdfg51sd84as21");
            var expected = new List<int>() { 1, 1, 2, 4, 5, 8 };
            var actual = P022_Foreach.Program.SurikiuotiSkaiciusIsTeksto(fake);

            CollectionAssert.AreEqual(expected, actual);
        }


    }

}

