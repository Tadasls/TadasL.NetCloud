using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P033_OopMetodai.Domain.Models
{
    public class SkaiciuKrepselis
    {
        public SkaiciuKrepselis()
        {
                
        }

        public SkaiciuKrepselis(List<int> skaiciuSarasas)
        {
            SkaiciuSarasas = skaiciuSarasas;
        }

        private List<int> SkaiciuSarasas { get; set; } = new List<int>();


        public void PridėtiSkaiciu(int skaicius)
        {
            SkaiciuSarasas.Add(skaicius);
        }
       

        public double ApskaiciuotiVidurki()
        {
            var vidurkis = 0;
            foreach (var skaicius in SkaiciuSarasas)
            {
                vidurkis += skaicius;
            }

            vidurkis = vidurkis / SkaiciuSarasas.Count;
           
            return vidurkis;

        }





    }
}
