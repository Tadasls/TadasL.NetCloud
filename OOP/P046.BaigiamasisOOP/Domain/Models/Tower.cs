using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Tower
    {
        public Tower()
        {

        }

        public Tower(List<Disk> diskuSarasas)
        {
            DiskuSarasas = diskuSarasas;
        }
        

        public int Height { get; set; }
        public int NameID { get; set; }

        public List<Disk> DiskuSarasas { get; set; }
       







        #region
        //int m_numdiscs;
        //public Tower()
        //{
        //    numdiscs = 0;
        //}
        //public Tower(int newval)
        //{
        //    numdiscs = newval;
        //}
        //public int numdiscs
        //{
        //    get
        //    {
        //        return m_numdiscs;
        //    }
        //    set
        //    {
        //        if (value > 0)
        //            m_numdiscs = value;
        //    }
        //}
        //public void movetower2(int n, int from, int to, int other )
        //{
        //    if (n > 0)
        //    {
        //        movetower2(n - 1, from, other, to);
        //        Console.WriteLine("Move disk {0} from tower {1} to tower {2}", n, from, to);
        //        movetower2(n - 1, other, to, from);
        //    }

        //}
        //static void Game()  // sprendimui rasti metodas
        //{
        //    Tower tower = new Tower(); // naujas objektas sukuriamas
        //    string cnumdiscs;

        //    Console.Write("Enter the number of discs: ");
        //    cnumdiscs = Console.ReadLine();
        //    tower.numdiscs = Convert.ToInt32(cnumdiscs);
        //    tower.movetower2(tower.numdiscs, 1, 3, 2);
        //    Console.ReadLine();

        //}
        #endregion





    }
}
