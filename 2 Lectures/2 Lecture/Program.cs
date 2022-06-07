namespace paskaita_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Sveikas, Pasauly!");
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


            /*
             Console.WriteLine("Jusu vardas " + Console.ReadLine());
              Console.WriteLine(" o stai mano vardas  {0}", Console.ReadLine()); 
             Console.WriteLine($"o tai kazkas { Console.ReadLine()}");
            */


            /*
            Console.WriteLine("Iveskite raide");
            var key = Console.ReadKey();
            Console.WriteLine("ivestas simbolis {0}", key.KeyChar);
            Console.WriteLine("ivestas simbolis {0}", key.Key);
            Console.WriteLine("ivestas simbolis {0}",(int)key.KeyChar);
            Console.WriteLine("ivestas simbolis {0}", Console.ReadKey().KeyChar);
            Console.WriteLine("ivestas simbolis {0}", (int)Console.ReadKey().KeyChar);
               */

            // Console.WriteLine("Įveskite savo vardą, ir to vardo pirma raide bus:");
            //Console.WriteLine("suvesto vardo pirma raide yra \"" + Console.ReadLine()[0] + "\"");


            //Console.ReadKey();


            /*
             Console.WriteLine("eilute 1" + 
               Environment.NewLine + "Eilute 2" + 
                Environment.NewLine + "Eilute 3" );
            */

            /*
                        Console.WriteLine(@"    ""tekstas kabutese""  \ \ \ \ \ \ \ \ 
            Eilute pirma
            eilute antra
            eilute trecia  ");
            */



            //1
            Console.WriteLine(" Sveiki Tadai... Follow white rabbit,  Enter");

            //2
            Console.WriteLine(" Iveskite savo varda, ir paspauskite Enter" + Console.ReadLine());
            Console.WriteLine(" Jusu Vardas yra: {0}", Console.ReadLine());



            //3
            Console.WriteLine("Dabar Iveskite savo vardo Pirmaja raide");
            var key0 = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(" \n ivestas simbolis ASCII sistemoje yra {0}", (int)key0.KeyChar);


            //4
            Console.WriteLine("Dabar Iveskite savo vardo Pirmaja raide");
            var key1 = Console.ReadKey();
            Console.WriteLine(" \n ivestas simbolis ASCII sistemoje yra {0}", (int)key1.KeyChar);

            Console.WriteLine("Iveskite betkoky skaiciu");
            var key2 = Console.ReadKey();
            var suma = (int)key1.KeyChar + (int)key2.KeyChar;
            ;
            Console.WriteLine("Skaiciu suma: ", (int)key1.KeyChar);


            //5A
            Console.WriteLine("Spauskite Enter kas pamatytute ivairius lygiavimus");
            Console.ReadLine();
            Console.WriteLine(" \n 1 pirkti, \n 2 parduoti, \n 3 likuciai");
            //5B
            Console.WriteLine(@" 
            1 pirkti, 
            2 parduoti, 
            3 likuciai  ");

            //5C
            Console.WriteLine(" \n {0} \n {1} \n {2}", "Pirkti", "Parduoti", "Likuciai");


        }
    }
}