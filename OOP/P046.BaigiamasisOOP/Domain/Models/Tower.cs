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
            Bokstas = new int[] { 0, 0, 0, 0, 0 }; 
        }

       

        public void SetFirstTower() {
            
           for (int i=0; i <= 4; i++)
            {
                Bokstas[i] = i ;
            }
        
        }


        public int takeFirst() {

            int m = -1;
            for (int i = 0; i <= 4; i++)
            {
                if (Bokstas[i] != 0) {
                    m = Bokstas[i];
                    Bokstas[i] = 0;

                    return m;
                }


            }

            return -1;
        }



        public bool place(int disk) {
            int m = 0;
            for (int i = 0; i <= 4; i++)
            {
                if (Bokstas[i]==0 ){ m = i; }

            }

            if (m == 4) {
                Bokstas[m] = disk;
                    return true; 
            }

            if (Bokstas[m + 1] > disk) { Bokstas[m] = disk;
                return true;
            }


            return false;
        }

        public int [] Bokstas { get; set; }
       







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
