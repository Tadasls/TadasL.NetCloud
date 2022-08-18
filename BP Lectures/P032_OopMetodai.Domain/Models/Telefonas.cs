using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P031_OopKonstruktoriai
{
    internal class IsmanusisTelefonas
    {
        public IsmanusisTelefonas()
        {
            Dimensija = "Nenurodyta";
            Stiklas = "Nenurodyta";
            Rezoliucija = "Nenurodyta";
            Modelis = "Nenurodyta";
        }

        public IsmanusisTelefonas(string operacineSistema) : this()
        {
            OperacineSistema = operacineSistema;
        }

        public IsmanusisTelefonas(string kamera, string operacineSistema) : this(operacineSistema)
        {
            Kamera = kamera;
        }

        public IsmanusisTelefonas(double svoris, double atmintis, int baterija, Dekliukas dekliukas)
        {
            Svoris = svoris;
            Atmintis = atmintis;
            Baterija = baterija;
            Dekliukas = dekliukas;
        }

        public IsmanusisTelefonas(IsmanusisTelefonas ismanusisTelefonas) : this(ismanusisTelefonas.kamera, ismanusisTelefonas.operacineSistema)
        {
            Svoris = ismanusisTelefonas.Svoris;
            Atmintis = ismanusisTelefonas.Atmintis;
            Baterija = ismanusisTelefonas.Baterija;
            Dekliukas = ismanusisTelefonas.Dekliukas;
        }

        public IsmanusisTelefonas(string dimensija, double svoris, string stiklas, string rezoliucija, double atmintis, string modelis, string operacineSistema, int baterija, string kamera, string gamintojas, Dekliukas dekliukas) : this(operacineSistema)
        {
            Svoris = svoris;
            Stiklas = stiklas;
            Rezoliucija = rezoliucija;
            Atmintis = atmintis;
            Modelis = modelis;
            Dimensija = dimensija;
            Baterija = baterija;
            Kamera = kamera;
            Gamintojas = gamintojas;
            Dekliukas = dekliukas;
        }

        // Klase aprasome tik public fully described properciais
        private string dimensija;

        public string Dimensija
        {
            get => dimensija;
            private set => dimensija = value;
        }

        private double svoris;

        public double Svoris
        {
            get { return svoris; }
            private set { svoris = value; }
        }

        private string stiklas;

        public string Stiklas
        {
            get { return stiklas; }
            private set { stiklas = value; }
        }

        private string rezoliucija;

        public string Rezoliucija
        {
            get { return rezoliucija; }
            private set { rezoliucija = value; }
        }

        private double atmintis;

        public double Atmintis
        {
            get { return atmintis; }
            private set { atmintis = value; }
        }

        private string modelis;

        public string Modelis
        {
            get { return modelis; }
            private set { modelis = value; }
        }

        private string operacineSistema;

        public string OperacineSistema
        {
            get { return operacineSistema; }
            private set { operacineSistema = value; }
        }

        private int baterija;

        public int Baterija
        {
            get { return baterija; }
            private set { baterija = value; }
        }

        private string kamera;

        public string Kamera
        {
            get { return kamera; }
            private set { kamera = value; }
        }

        private string gamintojas;

        public string Gamintojas
        {
            get { return gamintojas; }
            private set { gamintojas = value; }
        }

        private Dekliukas dekliukas; // Field

        public Dekliukas Dekliukas // Property
        {
            get { return dekliukas; }
            private set { dekliukas = value; }
        }

    }
}
