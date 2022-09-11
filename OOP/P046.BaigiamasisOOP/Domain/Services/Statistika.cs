using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class Statistika
    {
        public Statistika()
        {
            EjimuSkaicius = 0;
            Laimejimas = false;
            ZaidimuDuomenys = new List<int[]>();
        }


        public string ZaidimoPradziodata { get; set; }
        public int EjimuSkaicius { get; set; }
        public bool Laimejimas { get; set; }
        public List<int[]> ZaidimuDuomenys { get; set; }

        public void DuomenuPridejimas(int[] linija)
        {
            EjimuSkaicius++;
            ZaidimuDuomenys.Add(linija);
            if (linija[1] == 3 && linija[2] == 3 && linija[3] == 3 && linija[4] == 3)
            {
                Laimejimas = true;
            }

        }


    }
}
