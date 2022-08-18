using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_Metodu_Testai
{
    [TestClass]
    public class P016_DnrTests
    {
        string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
        int iteration = 10_000_000;
        [TestMethod]
        public void DnrGrandinesValidacija_Replace()
        {
            var actual = false;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_For.Program.DnrGrandinesValidacija_Replace(dnr);
            }
            Assert.IsTrue(actual);

        }

        [TestMethod]
        public void DnrGrandinesValidacija_Replace_False()
        {
            string badDnr = "QCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var actual = false;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_For.Program.DnrGrandinesValidacija_Replace(badDnr);
            }
            Assert.IsFalse(actual);

        }

        [TestMethod]
        public void DnrGrandinesValidacija_For()
        {
            var actual = false;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_For.Program.DnrGrandinesValidacija_For(dnr);
            }
            Assert.IsTrue(actual);

        }

        [TestMethod]
        public void DnrGrandinesValidacija_For_False()
        {
            string badDnr = "QCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var actual = false;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_For.Program.DnrGrandinesValidacija_For(badDnr);
            }
            Assert.IsFalse(actual);

        }



        [TestMethod]
        public void KiekKartuPasikartoja_For_Interpoliacija()
        {
            string badDnr = "QCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var actual = 0;
            var expected = 1;

            for (int i = 0; i < iteration; i++)
            {
                actual = P016_For.Program.KiekKartuPasikartoja_For_Interpoliation(dnr, "CCA");
            }
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void KiekKartuPasikartoja_For_Composition()
        {
            var actual = 0;
            var expected = 1;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_For.Program.KiekKartuPasikartoja_For_Composition(dnr, "CCA");
            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void KiekKartuPasikartoja_For_Concat()
        {
            var actual = 0;
            var expected = 1;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_For.Program.KiekKartuPasikartoja_For_Concat(dnr, "CCA");
            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void KiekKartuPasikartoja_For_StringBuilder()
        {
            var actual = 0;
            var expected = 1;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_For.Program.KiekKartuPasikartoja_For_StringBuilder(dnr, "CCA");
            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void KiekKartuPasikartoja_For_StringConstructor()
        {
            var actual = 0;
            var expected = 1;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_For.Program.KiekKartuPasikartoja_For_StringConstructor(dnr, "CCA");
            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void KiekKartuPasikartoja_For_Substring()
        {
            var actual = 0;
            var expected = 1;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_For.Program.KiekKartuPasikartoja_For_Substring(dnr, "CCA");
            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void KiekKartuPasikartoja_Replace()
        {
            var actual = 0;
            var expected = 1;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_For.Program.KiekKartuPasikartoja_Replace(dnr, "CCA");
            }
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void KiekKartuPasikartoja_Split()
        {
            var actual = 0;
            var expected = 1;
            for (int i = 0; i < iteration; i++)
            {
                actual = P016_For.Program.KiekKartuPasikartoja_Split(dnr, "CCA");
            }
            Assert.AreEqual(expected, actual);

        }




    }
}