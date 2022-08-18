using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_Metodu_Testai
{
    [TestClass]
    public class P021ListTestai
    {
        [TestMethod]
        public void DidziausiasSarase()
        {

            var fake = new List<int> { 5, 1, 6, 8, 7 };
            int expected = 8;
            var actual = P021_List.Program.DidziausiasSarase(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DidziausiasSarase_SuSort()
        {

            var fake = new List<int> { 5, 1, 6, 8, 7 };
            int expected = 8;
            var actual = P021_List.Program.DidziausiasSarase_SuSort(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DidesnisUzDidziausia()
        {

            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = new List<int> { 5, 1, 6, 8, 7, 9 };
            var actual = P021_List.Program.DidesnisUzDidziausia(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void DidesnisUzDidziausia_SuSort()
        //{

        //    var fake = new List<int> { 5, 1, 6, 8, 7 };
        //    var expected = new List<int> { 5, 1, 6, 8, 7, 9 };
        //    var actual = P021_List.Program.DidesnisUzDidziausia_SuSort(fake);
        //    CollectionAssert.AreEqual(expected, actual);
        //}


    }
}
