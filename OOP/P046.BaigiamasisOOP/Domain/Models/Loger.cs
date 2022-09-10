using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Loger
    {

        public void WriteLog(int iskurpaimtas, int diskas, int ikurpadetas, Tower[] Game, DateTime pradziosdata, int ejimonr,bool baigtas= false) 
        {




            string TxtLog = $"žaidime kuris pradėtas {pradziosdata.ToString("YY-MM-dd")}, ėjimu nr {ejimonr} {diskas} dalių diskas buvo paimtas iš {iskurpaimtas} sulpelio ir padėtas į {ikurpadetas}";


            int[] busenos = new int[4];
            for(int i = 0; i < 3; i++){
                for (int j = 0; j < 5; j++)
                {
                    if(Game[i].Bokstas[j] != 0)
                    {
                        busenos[Game[i].Bokstas[j] - 1] = i + 1; 


                    }



                }

            }



            string csvlogpath = "C:\\Users\\tadas\\Source\\Repos\\Tadasls\\TadasL.NetCloud\\OOP\\P046.BaigiamasisOOP\\Domain\\Logs\\Logcsv.csv";


            using (var w = new StreamWriter(csvlogpath,true))
            {
                w.WriteLine($"{pradziosdata},{ejimonr},{busenos[0]},{busenos[1]},{busenos[2]},{busenos[3]}");

            }

                    string txtlogpath = "C:\\Users\\tadas\\Source\\Repos\\Tadasls\\TadasL.NetCloud\\OOP\\P046.BaigiamasisOOP\\Domain\\Logs\\LogTxt.txt"; 
         
                using(StreamWriter writer = new StreamWriter(txtlogpath, true))
                {
                    writer.WriteLine(TxtLog);
                }        
         }

        
    }

    
}
