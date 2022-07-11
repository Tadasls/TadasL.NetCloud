using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_Methods_Tests
{
    [TestClass]
    public class P016_DnrTests
    {
        string dnr = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
        int iteration = 1_000_000;
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
    }
}