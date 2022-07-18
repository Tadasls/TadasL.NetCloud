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
        public void maziausioieskojimas()
        {
            int[] fake = new int[] { 5, 3, 7, 6, 8, -7, 10 };
            string expected = "-7";
            var actual = P020_Masyvu_Kartojimas.Program.MaziausioSkaiciausMasyvePaieska(fake);
            Assert.AreEqual(expected, actual);

        }



    }
}
