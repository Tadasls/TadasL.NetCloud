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
        public void UzpildytiBokstaDuomenis() 
        {  
           for (int i=0; i <= Bokstas.Length - 1; i++)
            {
                Bokstas[i] = i ;
            }
        
        }
        public int SurastiVirsutinioDiskoIndeksa() {
            int m = -1;
            for (int i = 0; i <= Bokstas.Length - 1; i++)
            {
                if (Bokstas[i] != 0) // kai bokstas uzpildytas
                {
                    m = Bokstas[i]; // paima indeksus ir priskiria
                    Bokstas[i] = 0; //suradus diska, iztustina joo vieta 
                    return m; // grazinia virsutinio disko indexa
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

            if (m == Bokstas.Length - 1) {
                Bokstas[m] = disk; //jei bokstas tuscias, iskarto padeda i apacia
                return true;  // grazina statusa kad padejo
            }

            if (Bokstas[m + 1] > disk) { Bokstas[m] = disk; // jei apatinis diskas yra didesnis, tada einama vieta uzpildo disku
                return true;// grazina statusa kad padejo
            }


            return false; // grazina statusa kad nepadejo (galima jei bokstas pilnas/arba apatinis diskas mazesnis
        }
        public int [] Bokstas { get; set; }
       


    }
}
