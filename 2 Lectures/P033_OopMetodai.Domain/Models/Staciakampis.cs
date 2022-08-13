using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P033_OopMetodai.Domain.Models
{
    public class Staciakampis
    {
        public Staciakampis(double ilgis, double plotis)
        {
            Ilgis = ilgis;
            Plotis = plotis;
        }

        internal double Ilgis { get; set; }
        internal double Plotis { get; set; }


       public double ApskaiciuotiPlota() // naudojame non static metodas kad galetume dirbti su konkrecia instancija/arba objektu
        {
            return Ilgis * Plotis;
        }

        public void PakeistiIlgi(double ilgis)
        {
            Ilgis = ilgis;
        }

        public void PakeistiPloti(double plotis)
        {
            Plotis = plotis;
        }


    }
}
