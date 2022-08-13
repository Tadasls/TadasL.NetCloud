using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P032_OopMetodai.Domain._7_uzd
{
    public class Mokytojas
    {
        public string Pavarde { get; set; }
        public string Vardas { get; set; }
        public string Pravarde { get; set; }
        public List<Studentas> Studentai { get; set; } 
        public Mokykla Mokykla { get; set; }
        public Pamoka Pamokos { get; set; }

    }
}
