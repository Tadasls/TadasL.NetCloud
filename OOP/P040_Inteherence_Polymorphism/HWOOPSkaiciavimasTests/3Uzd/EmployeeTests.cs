using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWOOPSkaiciavimas._3Uzd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._3Uzd.Tests
{
    [TestClass()]
    public class EmployeeTests
    {
        [TestMethod()]
        public void AlgosirAdresoRodymas_AlgairAdresa_TikimesGautiAlgairAdresa()
        {
            int expected1 = 3000;
            string expected2 = "Kaunakiemiog";
            Employee edvinas = new Employee(3000, "Kaunakiemiog");
            double actual1 = edvinas.GetCurrentSalary();
            string actual2 = edvinas.GetPhisicalAdress();

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod()]
        public void AlgosPadidinimas_Alga_TikimesGautiAlga()
        {
            int expected1 = 3500;
           
            Employee edvinas = new Employee(3000, "Kaunakiemiog");
            double actual1 = edvinas.IncreaseCurrentSalary(500);
            

            Assert.AreEqual(expected1, actual1);
            
        }
    }
}