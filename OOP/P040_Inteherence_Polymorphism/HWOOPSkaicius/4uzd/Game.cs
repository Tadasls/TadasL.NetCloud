using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._4uzd
{
    public class Game
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

    }
}
