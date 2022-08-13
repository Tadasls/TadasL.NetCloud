using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P033_OopMetodai.Domain.Models
{

    public class Skaiciuoklis
    {
        public Skaiciuoklis()
        {
           
        }
        public Skaiciuoklis(int skaicius)
        {
            Skaicius = skaicius;
           this.skaicius = skaicius;
        }

        private int skaicius;
        private int Skaicius { get; set; } // propertys

        //private int skaicius;
        //private int Skaicius
        //{
        //    get { return skaicius; }
        //    set { skaicius = value; }
        //}

        public void Didinti()
        {
            Skaicius++;
            Console.WriteLine($"Padidinus - {Skaicius}" );
        }  
        public void Mazinti()
        {
            if(Skaicius > 0)
            {
                Skaicius--;
            }
            Console.WriteLine($"Sumazinus - {Skaicius}");

        }
        public void Atspausdinti()
        {
            Console.WriteLine($"Turime Skaiciu: {Skaicius}");
        }
        public void Perkrauti() 
        {
           
            Skaicius = skaicius;
            Console.WriteLine($"Po reset sk value: {skaicius}");
            Console.WriteLine($"Po reset sk Prop: {Skaicius}");
        }


             




       
         








    }
}
