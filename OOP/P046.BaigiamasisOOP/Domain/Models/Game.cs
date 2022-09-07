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


        public DateTime ZaidimoData { get; set; }



        public List<Disk> aTower { get; set; } = new List<Disk>();
        public List<Disk> bTower { get; set; } = new List<Disk>();
        public List<Disk> cTower { get; set; } = new List<Disk>();

        public List<Tower> abcTowers { get; set; } 
       
















    }
}
