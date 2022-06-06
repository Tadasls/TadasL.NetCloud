namespace Paskaita_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Sveikas, Pasauly!");
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


            Console.WriteLine("Write any key to continue --------- ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Iveskite savo Varda");
            */


            // Console.WriteLine("Jusu vardas " + Console.ReadLine());
            // antras Console.WriteLine(" o stai mano vardas  {0}", Console.ReadLine()); 
            // Console.WriteLine($"o tai kazkas { Console.ReadLine()}");

             Console.WriteLine("Iveskite raide");
             var key = Console.ReadKey();
             Console.WriteLine("ivestas simbolis {0}", key.KeyChar);
             Console.WriteLine("ivestas simbolis {0}", key.Key);
             Console.WriteLine("ivestas simbolis {0}",(int)key.KeyChar);

            //Console.WriteLine("ivestas simbolis {0}", Console.ReadKey().KeyChar);
            //Console.WriteLine("ivestas simbolis {0}", (int)Console.ReadKey().KeyChar);

            //Console.WriteLine("iveskite varda , o pirma raide bus: ");
            //Console.WriteLine("pakartojimas yra \" " + Console.ReadLine() { } +" \" " );

            //Console.ReadKey();



            // Console.WriteLine("eilute 1" + 
            //    Environment.NewLine + "Eilute 2" + 
            //    Environment.NewLine + "Eilute 3" );


            //            Console.WriteLine(@"    ""tekstas kabutese""  \ \ \ \ \ \ \ \ 
            //Eilute pirma
            //eilute antra
            //eilute trecia  ");



            //1
           // Console.WriteLine("Iveskite savo varda");
           // Console.WriteLine("Jusu vardas yra " + Console.ReadLine());
            
            //2
            //  Console.WriteLine(" Vardas yra {0}", Console.ReadLine()); 
           
            //3

            Console.WriteLine("Iveskite savo vardo 1 raide");
             var key = Console.ReadKey();
            Console.WriteLine();
           Console.WriteLine("ivestas simbolis {0}",(int)key.KeyChar);


            //4
            /*
            Console.WriteLine("Iveskite betkoky skaiciu");
            var key2 = Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("ivestas simbolis {0}", key2.KeyChar);
            */

            
            /*
          
            //5
            Console.WriteLine(" \n 1 pirkti, \n 2 parduoti, \n 3 likuciai");

            Console.WriteLine(@" 
            1 pirkti, 
            2 parduoti, 
            3 likuciai  ");

            */

        }
    }
}