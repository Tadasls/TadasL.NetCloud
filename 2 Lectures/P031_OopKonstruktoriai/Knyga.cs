using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P031_OopKonstruktoriai
{
    internal class Knyga
    {

        public Knyga()
        {
            Leidejas = "Nenurodyta";
            Pavadinimas = "Nenurodyta";
            PuslapiuSkaicius = 456;
            Autorius = "Nenurodyta";
        }

        public Knyga(string leidejas, string pavadinimas, int puslapiuSkaicius, string autorius)
        {
            Leidejas = leidejas;
            Pavadinimas = pavadinimas;
            PuslapiuSkaicius = puslapiuSkaicius;
            Autorius = autorius;
        }

        public Knyga(Knyga knyga) : this()
        {
            Leidejas = knyga.Leidejas;
            Pavadinimas = knyga.Pavadinimas;
            PuslapiuSkaicius = knyga.PuslapiuSkaicius;
            Autorius = knyga.Autorius;
        }




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
