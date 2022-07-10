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
        public void DNR_Test_Norma()
        {
            var fake = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var expected = true;
            var actual = SavarDrbV03DNR.Program.GrandinesNormalizavimas(ref fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DNR_Test_Valid()
        {
            var fake = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var expected = true;
            var actual = SavarDrbV03DNR.Program.GrandinesValidavimas(ref fake);

            Assert.AreEqual(expected, actual);
        }

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
        [TestMethod]
        public void DNR_Test5()
        {
            var fake = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT"; //TAC testuojam
            var expected = 2;
            var actual = SavarDrbV03DNR.Program.TreciasSub5("TAC", ref fake);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DNR_Test6()
        {
            var fake = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT-TAC";
            var actual = SavarDrbV03DNR.Program.TreciasSub6("TAC", ref fake);
            
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DNR_Test7()
        {
            var fake = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = "TCG--GAC--CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var actual = SavarDrbV03DNR.Program.TreciasSub7("TAC", ref fake);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DNR_Test8()
        {
            var fake = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = "TCG-CAT-GAC-CAT-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var actual = SavarDrbV03DNR.Program.TreciasSub8("TAC","CAT", ref fake);

            Assert.AreEqual(expected, actual);
        }





    }
}
