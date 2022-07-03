namespace Belenkas1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite 1 skaiciu ");
            int pirmasSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite 2 skaiciu ");
            int antrasSkaicius = Convert.ToInt32(Console.ReadLine());

            string isPalyginimas = pirmasSkaicius > antrasSkaicius ? "Taip jis yra Didesnis"  : "Tikrai Ne";
            Console.WriteLine($" matome ar pirmas {pirmasSkaicius} skaicius yra didesnis uz antra {antrasSkaicius} skaiciu - {isPalyginimas}");




        }
    }
}