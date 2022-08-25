using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._2uzd
{
    public class Staciakampis : Figura, IGeometrija
    {
        public int TrumposiosKrastinesIlgis { get; }
        public int IlgosiosKrastinesIlgis { get; }

        public double Perimetras()
        {
            throw new NotImplementedException();
        }

        public double Plotas()
        {
            throw new NotImplementedException();
        }
    }
}
