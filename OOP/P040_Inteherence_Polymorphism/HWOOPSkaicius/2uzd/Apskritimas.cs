using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._2uzd
{
    public class Apskritimas : Figura, IGeometrija
    {
        public Apskritimas()
        {

        }

        public Apskritimas(int spinfulioIlgis) : base("Apskritimas")
        {
            SpinfulioIlgis = spinfulioIlgis;
        }

        public int SpinfulioIlgis { get; }

        public double Perimetras() => 2*3.14 * SpinfulioIlgis;
       

        public double Plotas() => (SpinfulioIlgis * SpinfulioIlgis) * 3.14;
          
    }
}
