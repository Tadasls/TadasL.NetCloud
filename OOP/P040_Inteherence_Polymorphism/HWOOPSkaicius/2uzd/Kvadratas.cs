using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._2uzd
{
    public class Kvadratas : Figura, IGeometrija
    {
        public Kvadratas()
        {

        }

        public Kvadratas(int krastinesIlgis) : base("Kvadratas")
        {
            KrastinesIlgis = krastinesIlgis;
        }

        public int KrastinesIlgis { get; }

        public double Perimetras() => KrastinesIlgis*4;
        public double Plotas() => KrastinesIlgis* KrastinesIlgis;
        
    }
}
