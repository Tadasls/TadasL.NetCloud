using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_Metodu_Testai
{
    [TestClass]
    public class P020MasyvuKartojimotestai
    {
        [TestMethod]
        public void RastiMaziausia_Test()
        {
            int[] fake = new int[] { 5, 3, 7, 6, 8, 7, 10 };
            int expected = 3;
            var actual = P020_Masyvu_Kartojimas.Program.RastiMaziausia(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RastiMaziausia_Test1()
        {
            int[] fake = new int[] { 5, 3, 7, 6, 8, -7, 10 };
            int expected = -7;
            var actual = P020_Masyvu_Kartojimas.Program.RastiMaziausia(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RastiDidziausia_Test()
        {
            int[] fake = new int[] { 5, 3, 7, 6, 8, 7, 10 };
            int expected = 10;
            var actual = P020_Masyvu_Kartojimas.Program.RastiDidziausia(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RikiuotiSkaiciusDidejimoTvarka_Test()
        {
            int[] fake = new int[] { 5, 1, 7, 6, 8, 7, 10 };
            int[] expected = new int[] { 1, 5, 6, 7, 7, 8, 10 };
            var actual = P020_Masyvu_Kartojimas.Program.RikiuotiSkaiciusDidejimoTvarka(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Rikiuoti_Test()
        {
            int[] fake = new int[] { 5, 1, 7, 6, 8, 7, 10 };
            int[] expected = new int[] { 1, 5, 6, 7, 7, 8, 10 };
            P020_Masyvu_Kartojimas.Program.Rikiuoti(fake);
            var actual = P020_Masyvu_Kartojimas.Program.SurikiuotasMasyvas;
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
