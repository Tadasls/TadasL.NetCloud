using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;

namespace Domain.Services
{
    public class Loger : ILog
    {

        public void WriteLog(int iskurpaimtas, int diskas, int ikurpadetas, Tower[] bokstai, DateTime pradziosdata, int ejimonr, bool baigtas = false)
        {

           


            int[] busenos = new int[4];
            for (int i = 0; i < bokstai.Length; i++)
            {
                for (int j = 0; j < bokstai[i].Bokstas.Length; j++)
                {
                    if (bokstai[i].Bokstas[j] != 0)
                    {
                        busenos[bokstai[i].Bokstas[j] - 1] = i + 1;
                    }
                }
            }


            string csvlogpath = "C:\\Users\\tadas\\Source\\Repos\\Tadasls\\TadasL.NetCloud\\OOP\\P046.BaigiamasisOOP\\Domain\\Logs\\Logcsv.csv";

            using (var w = new StreamWriter(csvlogpath, true))
            {
                w.WriteLine($"{pradziosdata},{ejimonr},{busenos[0]},{busenos[1]},{busenos[2]},{busenos[3]}");

            }

            //html Loginimas

            string htmllogpath = "C:\\Users\\tadas\\Source\\Repos\\Tadasls\\TadasL.NetCloud\\OOP\\P046.BaigiamasisOOP\\Domain\\Logs\\LogHtml.html";

            using (var h = new StreamWriter(htmllogpath, true))
            {
                h.WriteLine($"{pradziosdata},{ejimonr},{busenos[0]},{busenos[1]},{busenos[2]},{busenos[3]}");

            }



            //txt Loginimas

            string TxtLog = $"žaidime kuris pradėtas {pradziosdata.ToString("yyyy-MM-dd HH-mm")}, ėjimu nr {ejimonr} " +
              $"{diskas.ToString().Replace("1", "vienos").Replace("2", "dvieju").Replace("3", "triju").Replace("4", "keturiu")} dalių diskas buvo paimtas iš" +
              $" {iskurpaimtas.ToString().Replace("1", "pirmo").Replace("2", "antro").Replace("3", "trecio")} sulpelio ir padėtas į" +
              $" {ikurpadetas.ToString().Replace("1", "pirma").Replace("2", "antra").Replace("3", "trecia")}";


            string txtlogpath = "C:\\Users\\tadas\\Source\\Repos\\Tadasls\\TadasL.NetCloud\\OOP\\P046.BaigiamasisOOP\\Domain\\Logs\\LogTxt.txt";

            using (StreamWriter writer = new StreamWriter(txtlogpath, true))
            {
                writer.WriteLine(TxtLog);
            }










        }


    }


}
