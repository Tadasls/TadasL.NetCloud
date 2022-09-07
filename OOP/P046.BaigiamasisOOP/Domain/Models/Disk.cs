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

        public List<int> DiskoDydis { get; set; } = new List<int>() { 0, 1, 2, 3, 4 };
        public List<string> DiskoDydisString { get; set; } = new List<string>() { "      |      ", "     #|#     ", "    ##|##    ", "   ###|###   ", "  ####|####  " };



    }
}
