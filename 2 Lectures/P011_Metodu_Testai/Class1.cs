using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_Metodu_Testai
{
    [TestClass]
    public class P017_For_uzduotys_testai
    {
        [TestMethod]
        public void IntegerToBinary_test()
        {
        var fake = 45;
        var expected = "101101";
        var actual = P017_ForUzduotys.Program.IntegerToBinary(fake);
         Assert.AreEqual(expected, actual);

        }



    }
}
