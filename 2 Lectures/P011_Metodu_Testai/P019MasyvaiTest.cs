using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_Metodu_Testai
{
    [TestClass]
    public class P019MasyvaiTest
    {
      
        [TestMethod]
        public void PasikartojantysSkaiciaiMasyve_Test()
        {
            int[] fake = new int[] { 1, 2, 2, 4, 2, 7, 6, 1 };
            string expected = "1,2";
            var actual = P018_Masyvai.Program.PasikartojantysSkaiciaiMasyve(fake);
            Assert.AreEqual(expected, actual);
        }



    }
}
