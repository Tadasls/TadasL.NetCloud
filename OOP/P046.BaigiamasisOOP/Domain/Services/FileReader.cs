using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Services
{
    public class FileReader
    {

        public string GetFilePath(string fileName)
        {
       
            Console.WriteLine(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.Parent.Parent.FullName + "\\P046.BaigiamasisOOP\\Domain\\Logs\\" + fileName);
            return new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.Parent.Parent.FullName + "\\P046.BaigiamasisOOP\\Domain\\Logs\\" + fileName;
        }




        public List<Statistika> LoadCSV()
        {
            string filename = new  DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.Parent.Parent.FullName + "\\P046.BaigiamasisOOP\\Domain\\Logs\\Logcsv.csv";
            // Get the file's text.
            string whole_file = File.ReadAllText(filename);

            // Split into lines.
            whole_file = whole_file.Replace('\n', '\r');
            string[] lines = whole_file.Split(new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            // See how many rows and columns there are.
            int num_rows = lines.Length;
            int num_cols = lines[0].Split(',').Length;

            // Allocate the data array.
            string[,] values = new string[num_rows, num_cols];

            List<Statistika> statiskuObjektasBuveZaidimai = new List<Statistika>();
            Statistika buvesZaidimas = new Statistika();
            buvesZaidimas.ZaidimoPradziodata = lines[0].Split(',')[0];
            // Load the array.


            for (int r = 0; r < num_rows; r++)
            {
                string[] line_r = lines[r].Split(',');


                int[] linijos = { Convert.ToInt32(line_r[1]), Convert.ToInt32(line_r[2]), Convert.ToInt32(line_r[3]), Convert.ToInt32(line_r[4]), Convert.ToInt32(line_r[5]) };

                if (line_r[0] == buvesZaidimas.ZaidimoPradziodata.ToString())
                {
                    buvesZaidimas.DuomenuPridejimas(linijos);
                } else
                {
                    statiskuObjektasBuveZaidimai.Add(buvesZaidimas);
                    buvesZaidimas = new Statistika();
                    buvesZaidimas.ZaidimoPradziodata = line_r[0];
                }


              
              
            }

            
           return statiskuObjektasBuveZaidimai;
        }






    }
}
