using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._4uzd
{
    public class Music : IHobby
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

        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }

        public string GetHobbyInformation()
        {
            string info = $"This Company {Publisher} made Song which genre is {Genre} and this rating is: {Rating} ";
            return info;
        }

        public string GetHobbyName()
        {
            return nameof(Music);
        }



    }  
}

    

