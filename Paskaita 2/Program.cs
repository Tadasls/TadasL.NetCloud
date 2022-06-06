namespace Paskaita_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveikas, Pasauly!");
            Console.Write("Output/Išvedimas ");
            Console.Write("antras ");
            Console.Write("line");
            Console.WriteLine();
            Console.WriteLine("Visiskai kita eilute");
            Console.Write("tekstas");

            Console.WriteLine("------------------");
            Console.WriteLine("Išvedimas " + "Pirmas " + "Linija ");//kontanacija 
            Console.WriteLine("{0} {1} {2}", "Isvestis", "pirmasis", "liniuote");//kompozicija
            Console.WriteLine($"{"output"} {"antrasis"} {"paskutinis"} "); //interpelecija
            Console.WriteLine("------------------");

            Console.WriteLine(" tekstas isvestas \"Tekstas kabutese\"");
            Console.WriteLine(" tekstas \n isvestas \"Tekstas \n kabutese\"");
            Console.WriteLine(" tekstas \t isvestas \"Tekstas \t kabutese\"");
            Console.WriteLine("");
            Console.WriteLine("");



            Console.ReadKey();
        }
    }
}