using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P034_Praktika.Models
{
    public class Animal
    {
        public Animal()
        {

        }

        public Animal(string[] animalData)
        {
            Id = Convert.ToInt32(animalData[0]);
            Name = animalData[2];
        }

        public int Id { get; set; }
        public string Name { get; set; }



    }
}
