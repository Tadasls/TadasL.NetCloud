using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Disk
    {

        public Disk()
        {

        }

       
        public Disk(int diskoMatmuo) // skaiciai
        {
            
            DiskoMatmuo = diskoMatmuo;
        }

        public Disk(string diskoDydis) // stringai
        {

            DiskoDydisString = diskoDydis;
        }

             
       
        public ConsoleColor Color { get; set; }
        public int DiskoMatmuo { get; set; }
        public string DiskoDydisString { get; set; }


       
        



    }
}
