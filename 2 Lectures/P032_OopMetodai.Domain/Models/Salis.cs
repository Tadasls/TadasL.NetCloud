using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P031_OopKonstruktoriai
{
    internal class Salis
    {

        public Salis()
        {
            Pavadinimas = "Lietuva";
            Kalba = "Lietuviu";
            Plotas = 340000;
            IkurimoMetai = 1009;
        }

        public Salis(string pavadinimas, string kalba, int plotas, int ikurimoMetai)
        {
            Pavadinimas = pavadinimas;
            Kalba = kalba;
            Plotas = plotas;
            IkurimoMetai = ikurimoMetai;
        }

        public Salis(Salis salis) : this()
        {
            Pavadinimas = salis.pavadinimas;
            Kalba = salis.kalba;
            Plotas = salis.plotas;
            IkurimoMetai = salis.ikurimoMetai;
        }

        public Salis(int ikurimoMetai, string kalba, int plotas, string pavadinimas, string vyraujantiRase, double bvp, int populiacija, List<string> vartojamosKalbos, Valiuta valiuta)
        {
            IkurimoMetai = ikurimoMetai;
            Kalba = kalba;
            Plotas = plotas;
            Pavadinimas = pavadinimas;
            VyraujantiRase = vyraujantiRase;
            Bvp = bvp;
            Populiacija = populiacija;
            VartojamosKalbos = vartojamosKalbos;
            Valiuta = valiuta;
        }

        private int ikurimoMetai;

        public int IkurimoMetai
        {
            get { return ikurimoMetai; }
            private set { ikurimoMetai = value; }
        }

        private string kalba;

        public string Kalba
        {
            get { return kalba; }
            private set { kalba = value; }
        }

        private int plotas;

        public int Plotas
        {
            get { return plotas; }
            private set { plotas = value; }
        }

        private string pavadinimas;

        public string Pavadinimas
        {
            get { return pavadinimas; }
            private set { pavadinimas = value; }
        }


        
        public string VyraujantiRase { get; private set; }
        public double Bvp { get; private set; }
        public int Populiacija { get; private set; }
        public List<string> VartojamosKalbos { get; private set; }
        public Valiuta Valiuta { get; private set; }

                             
     
       
        
    }
}
