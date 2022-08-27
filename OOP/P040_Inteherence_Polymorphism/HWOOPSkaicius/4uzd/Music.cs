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

        public string Name => throw new NotImplementedException();

        public string Publisher => throw new NotImplementedException();

        public string Genre => throw new NotImplementedException();

        public int Rating => throw new NotImplementedException();

        public string GetHobbyInformation()
        {
            string info = $"This Song genre is  {Genre} and this rating is: {Rating} ";
            return info;
        }

        public string GetHobbyName()
        {
            return nameof(Music);
        }



    }  
}

    

