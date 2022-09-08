using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P049_LINQ_Extensions
{
    public class ExcerciseModel
    {
        public List<int> FirstExcerciseLinqFiltering(List<int> initialNumbers)
        {
            initialNumbers = initialNumbers
                .Where(n => n >= 35 && n <= 99)
                .ToList();

            return initialNumbers;
        }

        public List<string> SecondExcerciseLinqFiltering(List<string> colors)
        {
            IEnumerable<string> filteredColors = colors
                .Where(c => c.Length > 4)
                .Select(c => c.ToUpper());

            foreach (string color in filteredColors)
            {
                Console.WriteLine(color);
            }

            return filteredColors.ToList();
        }

        public List<string> ThirdExcerciseLinqFiltering(List<string> foods)
        {
            IEnumerable<string> food = foods
                .Where(c => c.StartsWith("d") && c.EndsWith("s"));
                

            foreach (string foodItem in food)
            {
                Console.WriteLine(foodItem);
            }

            return food.ToList();
        }

         
    
     
}









    }
