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

        public Tower(int[] bokstas)
        {
            Bokstas = bokstas;
        }

        public void UzpildytiBokstaDuomenis() {
            
           for (int i=0; i <= 4; i++)
            {
                Bokstas[i] = i ;
            }
        
        }


        public int SurastiVirsutinioDiskoIndeksa() {

            int m = -1;
            for (int i = 0; i <= 4; i++)
            {
                if (Bokstas[i] != 0) // kai bokstas pilnas
                {
                    m = Bokstas[i]; // paima indeksus
                    Bokstas[i] = 0; //uzpildo 

                    return m;
                }


            }

            return -1;
        }



        public bool PadetiDiskaINaujaVieta(int disk) {
            int m = 0;
            for (int i = 0; i <= Bokstas.Length-1; i++)
            {
                if (Bokstas[i]==0 ){ m = i; } // eina per visus boksto aukstus ir paskutinio tuscio disko vieta indeksuojasi

            }

            if (m == 4) {
                Bokstas[m] = disk; //jei bokstas tuscias, iskarto padeda i apacia
                    return true;  // grazina statusa kad padejo
            }

            if (Bokstas[m + 1] > disk) { Bokstas[m] = disk; // jei apatinis diskas yra didesnis, tada einama vieta uzpildo disku
                return true;// grazina statusa kad padejo
            }


            return false; // grazina statusa kad nepadejo (galima jei bokstas pilnas/arba apatinis diskas mazesnis
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
