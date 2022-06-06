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
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");

            Console.WriteLine("Write any kay to continue --------- ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Iveskite savo Varda");
            // Console.WriteLine("Jusu vardas " + Console.ReadLine());
            // antras Console.WriteLine(" o stai mano vardas  {0}", Console.ReadLine()); 
            // Console.WriteLine($"o tai kazkas { Console.ReadLine()}");

            Console.WriteLine("Iveskite raide");
            var key = Console.ReadKey();
            Console.WriteLine("ivestas simbolis {0}", key.KeyChar);
            Console.WriteLine("ivestas simbolis {0}", key.Key);
            Console.WriteLine("ivestas simbolis {0}",(int)key.KeyChar);




            Console.ReadKey();



        }
    }
}