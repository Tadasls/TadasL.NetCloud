using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/
class Player
{
    static void Main(string[] args)
    {
        string filename = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\input.txt";
        var data =
            (from line in File.ReadAllLines(filename)
               where !string.IsNullOrWhiteSpace(line)
                 select line).ToArray();

       
         int amountOfmountains = 8;
      

        // game loop
        do 
        {
            Dictionary<int, int> kalnuSarasas = new Dictionary<int, int>();

            for (int i = 0; i < amountOfmountains; i++)
            {
                int mountainH = int.Parse(data[i]); // represents the height of one mountain.
                kalnuSarasas.Add(i, mountainH);

            }


            var sortedDict = from entry in kalnuSarasas orderby entry.Value ascending select entry;
            
            amountOfmountains--;


            int result = sortedDict.First().Value -2;

            Console.WriteLine(result); // The index of the mountain to fire on.

            kalnuSarasas.Remove(kalnuSarasas.Keys.First());

        } while (amountOfmountains != 0);
    }
}