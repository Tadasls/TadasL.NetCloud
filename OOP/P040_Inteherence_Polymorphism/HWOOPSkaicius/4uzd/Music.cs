using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._4uzd
{
    public class Music
    {
        public Music()
        {

        }

        public Music(int id, int length, string artistName)
        {
            Id = id;
            Length = length;
            ArtistName = artistName;
        }

        public int Id { get; set; }
        public int Length { get; set; }
        public string ArtistName { get; set; }

            
    }
}
