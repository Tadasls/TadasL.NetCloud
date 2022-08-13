using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P032_OopMetodai.Domain._7_uzd
{
    public class Studentas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public PazymiuKnygele PazymiuKnygele { get; set; }
        public List<Mokytojas> Mokytojai { get; set; }



    }
}
