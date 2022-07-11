using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_Metodu_Testai
{
    [TestClass]
    public class P016_DNR_Test
    {
        string dnr = "dsadasd ";
            int ierations = 10000000;
           [TestMethod]    
        public void DNRGrandinesValidacija_Replace()
        {
            var actual = false;
            for(int i = 0; i < ierations; i++)
            {
                actual = P016_DNR_Test.Program.DNRGrandinesValidacija_Replace(dnr);
            }

                                 
            
            Assert.IsTrue(actual);  
        }

    }
}
