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

        public Disk(int location, int diskoMatmuo)
        {
            Location = location;
            DiskoMatmuo = diskoMatmuo;
        }

        public int Location { get; set; }
        public int Number { get; set; }
        public int Size { get; set; }
        public ConsoleColor Color { get; set; }
        public int DiskoMatmuo { get; set; }

       // public List<int> DiskoMatmuo { get; set; } = new List<int>() { 0, 1, 2, 3, 4 };
        public List<string> DiskoDydisString { get; set; } = new List<string>() { "      |      ", "     #|#     ", "    ##|##    ", "   ###|###   ", "  ####|####  " };



    }
}
