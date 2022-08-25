using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._2uzd
{
    public class Kvadratas : Figura, IGeometrija
    {
        public int KrastinesIlgis { get; }

        public double Perimetras()
        {
            double perimetras = 2*(KrastinesIlgis + KrastinesIlgis);
            return perimetras;
        }

        public double Plotas()
        {
            double plotas = KrastinesIlgis * KrastinesIlgis;
            return plotas;
        }
    }
}
