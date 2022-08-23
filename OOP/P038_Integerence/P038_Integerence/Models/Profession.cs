using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038_Integerence.Models
{
    public class Profession
    {

        public Profession()
        {

        }
        public Profession(int id)
        {
            Id = id;
        }
        public int Id { get; set; } // readonly kai neturi seterio
        public string Text { get; set; } // tik is vidaus irasoma kada set private
        public string TextLt { get; set; }

    }
}
