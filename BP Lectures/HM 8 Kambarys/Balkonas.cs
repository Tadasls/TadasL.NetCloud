using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8_Kambarys
{
    public class Balkonas
    {
        public Balkonas()
        {

        }
        public Balkonas(string tipas, bool istiklintas, bool sildymas, int aukstis, int plotas)
        {
            Tipas = tipas;
            Istiklintas = istiklintas;
            Sildymas = sildymas;
            Aukstis = aukstis;
            Plotas = plotas;
        }

        public string Tipas { get; set; }
        public bool Istiklintas { get; set; }
        public bool Sildymas { get; set; }
        public int Aukstis { get; set; }
        public int Plotas { get; set; }
        
        public double PaskaiciuotiPlota()
        {
            double kubatura = Plotas * Aukstis;

            Console.WriteLine($"balkono plotas cm2: {kubatura}");
            return kubatura;

        }




    }
}
