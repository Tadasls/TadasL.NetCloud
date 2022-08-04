using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P030_OopKompozicija
{
    internal class Telefonas
    {
        // aprasome tik public fully describeb properties

        private string dimensija;

        public string Dimensija
        {
            get { return dimensija; }
            set { dimensija = value; }
        }

        private double svoris;

        public double Svoris
        {
            get { return svoris; }
            set { svoris = value; }
        }

        private int stiklas;

        public int Stiklas
        {
            get { return stiklas; }
            set { stiklas = value; }
        }

        private int rezoliucija;

        public int Rezoliucija
        {
            get { return rezoliucija; }
            set { rezoliucija = value; }
        }

        private double atmintis;

        public double Atmintis
        {
            get { return atmintis; }
            set { atmintis = value; }
        }

        private string gamintojas;

        public string Gamintojas
        {
            get { return gamintojas; }
            set { gamintojas = value; }
        }



        private int baterija;

    public int Baterija
{
    get { return baterija; }
    set { baterija = value; }
}


private string kamera;

public string Kamera
{
    get { return kamera; }
    set { kamera = value; }
}


        private Dekliukas dekliukas;

        public Dekliukas Dekliukas
        {
            get { return dekliukas; }
            set { dekliukas = value; }
        }


    }
}
