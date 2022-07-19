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
        public void DidziausiasSkaicius_test()
        {

            var fake = new List<int> { 5, 1, 6, 8, 7 };
            int expected = 8;
            var actual = P021_List.Program.DidziausiasSarase1(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DidziausiasSkaicius_test2()
        {

            var fake = new List<int> { 5, 1, 6, 8, 7 };
            int expected = 8;
            var actual = P021_List.Program.DidziausiasSarase2(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DidziausiasSkaicius_test3()
        {

            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = new List<int> { 5, 1, 6, 8, 7, 9 };
            var actual = P021_List.Program.DidziausiasSarase3(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DidziausiasSkaicius_test4()
        {

            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = new List<int> { 5, 1, 6, 8, 7, 9 };
            var actual = P021_List.Program.DidziausiasSarase4(fake);
            CollectionAssert.AreEqual(expected, actual);
        }


    }
}
