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

        public Profession(string[] parts)
        {
            Id = Convert.ToInt32(parts[0]);
            Text = parts[1];
            TextLt = parts[2];
        }

        public int Id { get; set; } // readonly kai neturi seterio
        public string Text { get; set; } // tik is vidaus irasoma kada set private
        public string TextLt { get; set; }

        public string GetCsv() => String.Join(",", Id, Text, TextLt);


    }
}
