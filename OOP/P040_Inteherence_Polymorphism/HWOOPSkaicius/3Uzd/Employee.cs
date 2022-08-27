using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._3Uzd
{
    public class Employee : SD_Person, IPayable
    {
        public Employee()
        {

        }

        public Employee(double salary, string mailingAdress)
        {
            Salary = salary;
            MailingAdress = mailingAdress;
        }

        public double Salary { get; set; }
        public string MailingAdress { get; private set; }

        public double GetCurrentSalary()
        {
            Console.WriteLine($"Alga - {Salary}");
            return Salary;
        }

        public string GetPhisicalAdress()
        {
            Console.WriteLine($"Adresas - {MailingAdress}");
            return MailingAdress;
        }

        public double IncreaseCurrentSalary(double bonus)
        {
            Salary += bonus;
            return Salary;
        }
    }


    public class SD_Person 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; } 
    }

}
