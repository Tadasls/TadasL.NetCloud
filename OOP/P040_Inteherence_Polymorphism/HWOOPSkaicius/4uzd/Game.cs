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

        public Game(int id, int platform, bool isMultiplayer, string name, string publisher, string genre, int rating) : this(id, platform, isMultiplayer)
        {
            Name = name;
            Publisher = publisher;
            Genre = genre;
            Rating = rating;
        }

        public int Id { get; set; }
        public int Platform { get; set; }
        public bool IsMultiplayer { get; set; }

        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }

        public string GetHobbyInformation()
        {
            string info = $"This Game genre is  {Genre} and this rating is: {Rating} made by {Publisher}";
            return info;
        }

        public string GetHobbyName()
        {
            return nameof(Game);
        }
    }
}
