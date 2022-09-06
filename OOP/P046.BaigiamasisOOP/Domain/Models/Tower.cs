using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Tower
    {
                       
        public List<Disk> aTower { get; set; } = new List<Disk>();
        public List<Disk> bTower { get; set; } = new List<Disk>();
        public List<Disk> cTower { get; set; } = new List<Disk>();


        public List<Disk> Pole { get; set; }
        public int Position { get; set; }

        public Tower(int discs, int posistion)
        {
            Pole = new List<Disk>();
            Position = posistion;
        }





        int m_numdiscs;
        public Tower()
        {
            numdiscs = 0;
        }
        public Tower(int newval)
        {
            numdiscs = newval;
        }
        public int numdiscs
        {
            get
            {
                return m_numdiscs;
            }
            set
            {
                if (value > 0)
                    m_numdiscs = value;
            }
        }
        public void movetower(int n, int from, int to, int other )
        {
            if (n > 0)
            {
                movetower(n - 1, from, other, to);
                Console.WriteLine("Move disk {0} from tower {1} to tower {2}", n, from, to);
                movetower(n - 1, other, to, from);
            }
            
        }

        private static void Move(int discs, Stack<int> fromPeg, Stack<int> toPeg, Stack<int> otherPeg)
        {
            if (discs == 0)
            {
                return;
            }

            Move(discs - 1, fromPeg, otherPeg, toPeg);

            toPeg.Push(fromPeg.Pop());

            Move(discs - 1, otherPeg, toPeg, fromPeg);
        }


    }
}
