using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_Metodu_Testai
{
    [TestClass]
    public class savTest01
    {
        [TestMethod]
        public void DNR_Test1()
        {
            var fake = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-AGG";
            var actual = SavarDrbV03DNR.Program.TreciasSub1(ref fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DNR_Test2()
        {
            var fake = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = true;
            var actual = SavarDrbV03DNR.Program.TreciasSub2(ref fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DNR_Test3()
        {
            var fake = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = "GAC";
            var actual = SavarDrbV03DNR.Program.TreciasSub3(ref fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DNR_Test4()
        {
            var fake = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = 39;
            var actual = SavarDrbV03DNR.Program.TreciasSub4(ref fake);

            Assert.AreEqual(expected, actual);
        }

    }
}
