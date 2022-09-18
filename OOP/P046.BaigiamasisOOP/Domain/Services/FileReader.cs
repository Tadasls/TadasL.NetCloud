using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Domain.Services
{
    public class FileReader : IServis
    {
        public List<Statistika> LoadCSV()
        {
            string filename = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.Parent.Parent.FullName + "\\P046.BaigiamasisOOP\\Domain\\Logs\\Logcsv.csv";
            string whole_file = File.ReadAllText(filename);

            whole_file = whole_file.Replace('\n', '\r');
            string[] lines = whole_file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int eiluciuSkaicius = lines.Length;
            int StulpeiuSkaicius = lines[0].Split(',').Length;

            string[,] values = new string[eiluciuSkaicius, StulpeiuSkaicius];

            List<Statistika> buvusiuZaidimuDuomenuSarasas = new List<Statistika>();
            Statistika vienoZaidimoStatistiniaiDuomenys = new Statistika();
            vienoZaidimoStatistiniaiDuomenys.ZaidimoPradziodata = lines[0].Split(',')[0];
            
            for (int r = 0; r < eiluciuSkaicius; r++)
            {
                string[] eiluitesMasyvas = lines[r].Split(',');

                int[] linijosDuomenys = { Convert.ToInt32(eiluitesMasyvas[1]), Convert.ToInt32(eiluitesMasyvas[2]), Convert.ToInt32(eiluitesMasyvas[3]), Convert.ToInt32(eiluitesMasyvas[4]), Convert.ToInt32(eiluitesMasyvas[5]) };

                if (eiluitesMasyvas[0] == vienoZaidimoStatistiniaiDuomenys.ZaidimoPradziodata.ToString())
                {
                    vienoZaidimoStatistiniaiDuomenys.DuomenuPridejimas(linijosDuomenys);
                } else
                {
                    buvusiuZaidimuDuomenuSarasas.Add(vienoZaidimoStatistiniaiDuomenys);
                    vienoZaidimoStatistiniaiDuomenys = new Statistika();
                    vienoZaidimoStatistiniaiDuomenys.ZaidimoPradziodata = eiluitesMasyvas[0];
                    vienoZaidimoStatistiniaiDuomenys.DuomenuPridejimas(linijosDuomenys);

                }
            }
            buvusiuZaidimuDuomenuSarasas.Add(vienoZaidimoStatistiniaiDuomenys);


            return buvusiuZaidimuDuomenuSarasas;
        }






    }
}
