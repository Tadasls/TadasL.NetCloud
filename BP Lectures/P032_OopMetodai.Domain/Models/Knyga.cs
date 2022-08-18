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

        public Knyga(string leidejas, string pavadinimas, int puslapiuSkaicius, bool arVaikamsSkirta, bool arSpalvota, string autorius, double kaina, double svoris, Paveiksliukai paveiksliukai)
        {
            Leidejas = leidejas;
            Pavadinimas = pavadinimas;
            PuslapiuSkaicius = puslapiuSkaicius;
            ArVaikamsSkirta = arVaikamsSkirta;
            ArSpalvota = arSpalvota;
            Autorius = autorius;
            Kaina = kaina;
            Svoris = svoris;
            Paveiksliukai = paveiksliukai;
        }

        public string Leidejas { get; private set; }
        public string Pavadinimas { get; private set; } 
        public int PuslapiuSkaicius { get; private set; } 
        public bool ArVaikamsSkirta { get; private set; } 
        public bool ArSpalvota { get; private set; }
        public string Autorius { get; private set; }
        public double Kaina { get; private set; }
        public double Svoris { get; private set; }
        public Paveiksliukai Paveiksliukai { get; private set; }


        //private Paveiksliukai paveiksliukai;

        //public Paveiksliukai Paveiksliukai
        //{
        //    get { return paveiksliukai; }
        //    set { paveiksliukai = value; }
        //}

    }
}
