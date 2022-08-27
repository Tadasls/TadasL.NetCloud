using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._2uzd
{
    public class StatusisTrikampis : Figura, IGeometrija
    {
        public StatusisTrikampis()
        {

        }

        public StatusisTrikampis(int aKrastinesIlgis, int bKrastinesIlgis, int cKrastinesIlgis) : base("Stat_Trikampis")
        {
            AKrastinesIlgis = aKrastinesIlgis;
            BKrastinesIlgis = bKrastinesIlgis;
            CKrastinesIlgis = cKrastinesIlgis;
        }

        public int AKrastinesIlgis { get; }
        public int BKrastinesIlgis { get; }
        public int CKrastinesIlgis { get; }

        public double Perimetras() => AKrastinesIlgis + BKrastinesIlgis + CKrastinesIlgis;

        public double Plotas() => (AKrastinesIlgis * BKrastinesIlgis )/ 2;
    }
}
