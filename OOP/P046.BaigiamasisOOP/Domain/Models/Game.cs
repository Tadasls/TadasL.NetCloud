using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Game
    {

       
        public Game()
        {

        }

        public Game(List<Tower> abcTowers)
        {
            AbcTowers = abcTowers;
        }

        public DateTime ZaidimoData { get; set; }

               
        public List<Tower> AbcTowers { get; set; }


       














    }
}
