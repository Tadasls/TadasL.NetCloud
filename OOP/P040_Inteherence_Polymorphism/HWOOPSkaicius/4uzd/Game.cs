using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._4uzd
{
    public class Game : IHobby
    {
        public Game()
        {

        }

        public Game(int id, int platform, bool isMultiplayer)
        {
            Id = id;
            Platform = platform;
            IsMultiplayer = isMultiplayer;
        }

        public int Id { get; set; }
        public int Platform { get; set; }
        public bool IsMultiplayer { get; set; }

        public string Name => throw new NotImplementedException();

        public string Publisher => throw new NotImplementedException();

        public string Genre => throw new NotImplementedException();

        public int Rating => throw new NotImplementedException();

        public string GetHobbyInformation()
        {
            string info = $"This Game genre is  {Genre} and this rating is: {Rating} ";
            return info;
        }

        public string GetHobbyName()
        {
            return nameof(Game);
        }
    }
}
