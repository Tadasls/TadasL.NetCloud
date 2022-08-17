using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P034_Praktika.Models
{
    public class User
    {
        public User(int id, string vardas)
        {
            Id = id;
            Name = vardas;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}
