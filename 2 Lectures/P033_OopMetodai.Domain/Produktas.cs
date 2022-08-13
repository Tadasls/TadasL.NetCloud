using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P033_OopMetodai.Domain
{
    public class Produktas
    {
        public Produktas()
        {

        }
        public Produktas(double kaina, int kiekis, string pavadinimas)
        {
            Kaina = kaina;
            Kiekis = kiekis;
            Pavadinimas = pavadinimas;
        }

        private double Kaina { get; set; }
        private int Kiekis { get; set; }
        private string Pavadinimas { get; set; }

        public void SpausdintiProdukta()
        {
            Console.WriteLine($"{Pavadinimas} kaina {Kaina.ToString("0.00")}$: {Kiekis} vnt");

            
        }












    }
}
