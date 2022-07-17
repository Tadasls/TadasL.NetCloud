using System.Text;

namespace MasyvuPraktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8] { 1, 2, 2, 4, 2, 7, 6, 1 };
           //  FindRepetitions(numbers);
           FindRepetitionsInTwoDimentionalArray();
           // FindRepetitionsInTwoDimentionalArrayString();
        }
   

        /// <summary>
        /// Uzduotis 5
        /// </summary>
        public static string FindRepetitions(int[] numbers)
        {
            
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] && !sb.ToString().Contains(numbers[j].ToString()) && i != j) { sb.Append(numbers[j]).Append(','); }
                }
            }
            Console.WriteLine("5 uzd met");
            Console.WriteLine(sb.ToString());
            return sb.ToString().Trim(',');
        }

        
        /// <summary>
        /// Uzduotis 7
        /// </summary>
        public static void FindRepetitionsInTwoDimentionalArray()
        {
            int[,] numbers = new int[3, 3] { { 1, 1, 2},
                                            { 3, 5, 8},
                                            { 5, 5, 7} };
            int arrIndex = 0;
            int[] oneDimesionNumbers = new int[numbers.Length];

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    oneDimesionNumbers[arrIndex] = numbers[i, j];
                    arrIndex++;
                }
            }
            Console.WriteLine("7 uzd");
            Console.WriteLine(FindRepetitions(oneDimesionNumbers));
        }
        /// <summary>
        /// Uzduotis 8
        /// </summary>
        public static string FindRepetitions(string[] words)
        {
            //int[] numbers = new int[8] { 1, 2, 2, 4, 2, 7, 6, 1 };
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i; j < words.Length; j++)
                {
                    if (words[i] == words[j] && !sb.ToString().Contains(words[j].ToString()) && i != j) { sb.Append(words[j]).Append(','); }
                }
            }
            Console.WriteLine(sb.ToString());
            return sb.ToString().Trim(',');
        }
        public static void FindRepetitionsInTwoDimentionalArrayString()
        {
            string[,] words = new string[3, 3] { { "Tauras", "Tomas", "Aurimas"},
                                                   { "Algirdas", "Tauras", "Aurimas"},
                                                   { "Petras", "Arnas", "Povilas"} };
            int arrIndex = 0;
            string[] oneDimesionWords = new string[words.Length];

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < words.GetLength(0); i++)
            {
                for (int j = 0; j < words.GetLength(1); j++)
                {
                    oneDimesionWords[arrIndex] = words[i, j];
                    arrIndex++;
                }
            }
            Console.WriteLine(FindRepetitions(oneDimesionWords));
        }

    }
}


