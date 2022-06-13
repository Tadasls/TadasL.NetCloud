namespace paskaita_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" {0:d}\n", DateTime.Now);


            Console.WriteLine("Sveikas, Pasauly!");
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
            


            
             Console.WriteLine("Jusu vardas " + Console.ReadLine());
              Console.WriteLine(" o stai mano vardas  {0}", Console.ReadLine()); 
             Console.WriteLine($"o tai kazkas { Console.ReadLine()}");
            


            
            Console.WriteLine("Iveskite raide");
            var key = Console.ReadKey();
            Console.WriteLine("ivestas simbolis {0}", key.KeyChar);
            Console.WriteLine("ivestas simbolis {0}", key.Key);
            Console.WriteLine("ivestas simbolis {0}",(int)key.KeyChar);
            Console.WriteLine("ivestas simbolis {0}", Console.ReadKey().KeyChar);
            Console.WriteLine("ivestas simbolis {0}", (int)Console.ReadKey().KeyChar);
               

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
            Console.WriteLine(" Sveiki Tadai... Follow white rabbit, Enter ") ;

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
            var skaicius = Convert.ToInt32(key2.KeyChar.ToString());
            var suma = ((int)key1.KeyChar + skaicius);
            ;
            Console.WriteLine($"Skaiciu suma: {suma} .");


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


            Console.WriteLine("--------");
            Console.WriteLine("Standard DateTime Format Specifiers");
            Console.WriteLine(" {0:d}\n", DateTime.Now);






            /*
            Console.WriteLine(
        "(C) Currency: . . . . . . . . {0:C}\n" +
        "(D) Decimal:. . . . . . . . . {0:D}\n" +
        "(E) Scientific: . . . . . . . {1:E}\n" +
        "(F) Fixed point:. . . . . . . {1:F}\n" +
        "(G) General:. . . . . . . . . {0:G}\n" +
        "    (default):. . . . . . . . {0} (default = 'G')\n" +
        "(N) Number: . . . . . . . . . {0:N}\n" +
        "(P) Percent:. . . . . . . . . {1:P}\n" +
        "(R) Round-trip: . . . . . . . {1:R}\n" +
        "(X) Hexadecimal:. . . . . . . {0:X}\n",
        -123, -123.45f);


            Console.WriteLine("--------");
            Console.WriteLine("Standard DateTime Format Specifiers");
            Console.WriteLine(
                "(d) Short date: . . . . . . . {0:d}\n" +
                "(D) Long date:. . . . . . . . {0:D}\n" +
                "(t) Short time: . . . . . . . {0:t}\n" +
                "(T) Long time:. . . . . . . . {0:T}\n" +
                "(f) Full date/short time: . . {0:f}\n" +
                "(F) Full date/long time:. . . {0:F}\n" +
                "(g) General date/short time:. {0:g}\n" +
                "(G) General date/long time: . {0:G}\n" +
                "    (default):. . . . . . . . {0} (default = 'G')\n" +
                "(M) Month:. . . . . . . . . . {0:M}\n" +
                "(R) RFC1123:. . . . . . . . . {0:R}\n" +
                "(s) Sortable: . . . . . . . . {0:s}\n" +
                "(u) Universal sortable: . . . {0:u} (invariant)\n" +
                "(U) Universal full date/time: {0:U}\n" +
                "(Y) Year: . . . . . . . . . . {0:Y}\n",
                DateTime.Now);

            */






        }
    }
}