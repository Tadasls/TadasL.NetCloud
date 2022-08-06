using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P030_OopKompozicija
{
    internal class Knyga
    {
        public string Leidejas { get; set; }
        public string Pavadinimas { get; set; } 
        public int PuslapiuSkaicius { get; set; } 
        public bool ArVaikamsSkirta { get; set; } 
        public bool ArSpalvota { get; set; }
        public string Autorius { get; set; }
        public double Kaina { get; set; }
        public double Svoris { get; set; }

        public Paveiksliukai Paveiksliukai { get; set; }


        //private Paveiksliukai paveiksliukai;

        //public Paveiksliukai Paveiksliukai
        //{
        //    get { return paveiksliukai; }
        //    set { paveiksliukai = value; }
        //}

    }
}
