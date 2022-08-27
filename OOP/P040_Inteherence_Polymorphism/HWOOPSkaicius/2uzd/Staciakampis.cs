using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._2uzd
{
    public class Staciakampis : Figura, IGeometrija
    {
        public Staciakampis()
        {

        }

        public Staciakampis(int trumposiosKrastinesIlgis, int ilgosiosKrastinesIlgis): base("Staciakampis")
        {
            TrumposiosKrastinesIlgis = trumposiosKrastinesIlgis;
            IlgosiosKrastinesIlgis = ilgosiosKrastinesIlgis;
        }

        public int TrumposiosKrastinesIlgis { get; }
        public int IlgosiosKrastinesIlgis { get; }
        public double Perimetras() => TrumposiosKrastinesIlgis*2+ IlgosiosKrastinesIlgis*2;
        public double Plotas() => TrumposiosKrastinesIlgis * IlgosiosKrastinesIlgis;


    }
}
