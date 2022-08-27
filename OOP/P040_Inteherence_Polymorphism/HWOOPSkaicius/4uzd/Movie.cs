using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._4uzd
{
    public class Movie
    {
        public Movie()
        {

        }

        public Movie(int id, DateTime creationDate)
        {
            Id = id;
            CreationDate = creationDate;
        }

        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
