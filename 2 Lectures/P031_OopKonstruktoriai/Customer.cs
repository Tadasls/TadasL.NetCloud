using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P031_OopKonstruktoriai
{
    internal class Customer
    {
        //tuscio konstruktoriaus generavimas
        public Customer() 
        {
            Vardas = "Stiuartas";
        }

        public Customer(string vardas)
        {
            Vardas = vardas;
        }

        public string Vardas { get; set; }

    }
}
