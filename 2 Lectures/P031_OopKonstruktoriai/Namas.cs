using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P031_OopKonstruktoriai
{
    internal class Namas
    {

        public Namas()
        {
            Spalva = "Nenurodyta";
            Aukstai = 5;
            Plotas = 550;
            Langai = 18;
            Adresas = "Ziglos g. 20";
        }
        public Namas(string spalva, int aukstai, int plotas, int langai, string adresas)
        {
            Spalva = spalva;
            Aukstai = aukstai;
            Plotas = plotas;
            Langai = langai;
            Adresas = adresas;
        }

        public Namas(Namas namas)
        {

            Spalva = namas.spalva;
            Aukstai = namas.aukstai;
            Plotas = namas.plotas;
            Langai = namas.langai;
            Adresas = namas.adresas;

                        
        }






        private string spalva;
        public string Spalva
        {
            get => spalva;         //kitokia sintakse
            set => spalva = value; 
        }
        private int aukstai;
        public int Aukstai
        {
            get { return aukstai; }
            set { aukstai = value; }
        }
        private int plotas;
        public int Plotas
        {
            get { return plotas; }
            set { plotas = value; }
        }
        private int langai;
        public int Langai
        {
            get { return langai; }
            set { langai = value; }
        }
        private string adresas;
        public string Adresas
        {
            get { return adresas; }
            set { adresas = value; }
        }
        private int kvadraturaGyvenama;
        public int KvadraturaGyvenama
        {
            get { return kvadraturaGyvenama; }
            set { kvadraturaGyvenama = value; }
        }

        private Garazas garazas;

        public Garazas Garazas
        {
            get { return garazas; }
            set { garazas = value; }
        }


    }

 
}
