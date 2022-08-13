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


        private int ikurimoMetai;

        public int IkurimoMetai
        {
            get { return ikurimoMetai; }
            set { ikurimoMetai = value; }
        }

        private string kalba;

        public string Kalba
        {
            get { return kalba; }
            set { kalba = value; }
        }

        private int plotas;

        public int Plotas
        {
            get { return plotas; }
            set { plotas = value; }
        }

        private string pavadinimas;

        public string Pavadinimas
        {
            get { return pavadinimas; }
            set { pavadinimas = value; }
        }






        
        public string VyraujantiRase { get; set; }
        public double Bvp { get; set; }
        public int Populiacija { get; set; }
        public List<string> VartojamosKalbos { get; set; }
        public Valiuta Valiuta { get; set; }

                             
     
       
        
    }
}
