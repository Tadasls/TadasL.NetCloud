using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P030_OopKompozicija
{
    internal class Namas
    {
        private string spalva;
        public string Spalva
        {
            get { return spalva; }
            set { spalva = value; }
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
