using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_Metodu_Testai
{
    [TestClass]
    public class SkaiciuotuvasTestai
    {

        [TestMethod]
        public void SkaiciuotuvoTestas_001()
        {
            //fakes
            var a = 5;
            var b = 5;
            //expected
            var expected = 0;
            //actual
            var actual = NamuDarbasSkaiciuotuvas.Program.SudetiSkaicius();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SkaiciuotuvoTestas_002()
        {
            //fakes
            var a = 5;
            var b = 5;
            //expected
            var expected = 0;
            //actual
            var actual = NamuDarbasSkaiciuotuvas.Program.AtimtiSkaicius();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SkaiciuotuvoTestas_003()
        {
            //fakes
            var a = 5;
            var b = 5;
            //expected
            var expected = 0;
            //actual
            var actual = NamuDarbasSkaiciuotuvas.Program.DaugintiSkaicius();
            Assert.AreEqual(expected, actual);
        }

  
    }
}

