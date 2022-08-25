using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas
{
    public class IGeometrija
    {
        public double Plotas(int skaicius)
        {
           
            double plotas = skaicius * skaicius;
            return plotas;
        }
        public double Perimetras(int skaicius)
        {

            double perimetras = (2*(skaicius + skaicius));
            return perimetras;
        }

    }
}
