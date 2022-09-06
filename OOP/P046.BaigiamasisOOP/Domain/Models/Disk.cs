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

        public Disk(int number, int size, ConsoleColor color)
        {
            Number = number;
            Size = size;
            Color = color;
        }

        public int Number;
        public int Size;
        public ConsoleColor Color;
               
        




        //string D0 = "      |      ";
        //string D1 = "     #|#     ";
        //string D2 = "    ##|##    ";
        //string D3 = "   ###|###   ";
        //string D4 = "  ####|####  "



    }
}
