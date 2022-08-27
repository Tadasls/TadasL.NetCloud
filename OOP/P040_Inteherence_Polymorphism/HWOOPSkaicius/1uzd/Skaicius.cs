using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas
{
    public class Skaicius : IMatematika
    {
        public Skaicius()
        {
            Reiksme = 0;
        }
        public Skaicius(int pradineReiksme)
        {
            Reiksme = pradineReiksme;
        }
        public int Reiksme { get; private set; }
        public int Prideti(int skaicius) => Reiksme + skaicius;
        public int Atimti(int skaicius) => Reiksme - skaicius;
        public int Padauginti(int skaicius)
        {
            Reiksme *= skaicius;
            return Reiksme;
        }
        public double Padalinti(int skaicius) => (double)Reiksme / skaicius;
       
        public int PakeltiKvadratu() => (int)Math.Pow(Reiksme,2);
            
        public int PakeltiKubu()
        {
            Reiksme = Reiksme * Reiksme * Reiksme;
            return Reiksme;
        }




    }
}
