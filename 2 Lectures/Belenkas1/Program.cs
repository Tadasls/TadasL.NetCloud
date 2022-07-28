using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanDemo
{
    internal class Program
    {
        public static List<string> Zodziai1 = new List<string>{ "Kaunas", "Vilnius", "Klaipeda","mazeikiai","Šiauliai","Panevezys","Alytus","Marijampole" };
        public static List<string> Zodziai2 = new List<string> { "Akvile", "Titas", "Tadas", "Kristijonas", "Dainius", "Sauleja", "Mikas", "Merunas","Augustinas","justinas","Mykolas" };
        public static List<string> Zodziai3 = new List<string> { "Lietuva", "Lenkija", "Ukraina", "Rusija", "Vengrija", "Norvegija", "Svedija", "Anglija", "Prancuzija", "Belgija", "Kongas" };
        public static int Lives = 9;
        public static bool Laimejo = false;
        public static char[] raides;
        public static bool[] rodomos;
        public static string zod;
        public static string tema = "";
        public static List<char> spetosRaidesNeteisingos;
        public static List<char> spetosRaidestesingos;
        public static string[] Deadman = {
                                            @" |      |      ",
                                            @" |      |      ",
                                            @" |      O      ",
                                            @" |   ---|---   ",
                                            @" |      |      ",
                                            @" |     /\      ",
                                            @" |    /  \     ",
                                            @" |   _|  |_    ",
                                            @"_______________" };
        public static string[] Alive = {                                          
                                            @" |             ",
                                            @" |             ",
                                            @" |             ",
                                            @" |             ",
                                            @" |             ",
                                            @" |             ",
                                            @" |             ",
                                            @" |             ",
                                            @"_______________" };


        static void Main()
        {
            Lives = 9;
            Laimejo = false;
            spetosRaidesNeteisingos = new List<char>();

            spetosRaidestesingos = new List<char>();

            Console.Clear();
            Console.WriteLine("Pasirinkite Tema  \n 1. jei norite Miestu \n 2. Vardai \n 3. Salys ");
            string ivestis = "";
             ivestis = Console.ReadLine();
            Console.Clear();
            int rand_num;
            Random rd = new Random();
            switch (ivestis)
            {
                case "1":
                   
                     rand_num = rd.Next(0, Zodziai1.Count - 1); ;
                    zod = Zodziai1[rand_num];
                    zod = zod.ToLower();
                    Zodziai1.RemoveAt(rand_num);
                    tema = "Miestai";
                    zaidimas();                   
                    break;
                case "2":
                    
                     rand_num = rd.Next(0, Zodziai2.Count - 1); ;
                    zod = Zodziai2[rand_num];
                    zod = zod.ToLower();
                    Zodziai2.RemoveAt(rand_num);
                    tema = "Vardai";
                    zaidimas();
                    break;
                case "3":

                    rand_num = rd.Next(0, Zodziai3.Count - 1); ;
                    zod = Zodziai3[rand_num];
                    zod = zod.ToLower();
                    Zodziai3.RemoveAt(rand_num);
                    tema = "Salys";
                    zaidimas();
                    break;

                default:
                    Console.WriteLine("Ivestas neteisingas pasirinkimas bandykite dar karta ");
                    Console.Clear();
                    gameover();
                    break;
            }
            
            Console.ReadLine();
        }
        static void zaidimas() 
        {
            Console.WriteLine($"Sveikinu pradejus zaidima jusu pasirinkta kategorija {tema}");
            Console.WriteLine("Pradekime ? ");
            Console.ReadLine();
        
            
             
            raides = zod.ToCharArray();
            rodomos = Enumerable.Repeat(false, raides.Length).ToArray();
            

            while (true)
            {
                Console.Clear();
                if (Lives <= 0) { gameover(); }
                string ivestasSpejimas;
                bool kartojas = false;
                bool kartojasGerose = false;
                do
                {
                    Console.WriteLine(@"-------- | ");
                    for (int i = 0; i < Deadman.Length; i++)
                    {
                        if (9 - i >= Lives)
                        { Console.WriteLine(Deadman[i].ToString()); }
                        else
                        { Console.WriteLine(Alive[i].ToString()); }


                    }
                    Console.WriteLine();

                    Console.WriteLine("Spekite raide ,arba zodi jai jauciates drasus ");
                    ivestasSpejimas = Console.ReadLine();
                    if (ivestasSpejimas.Length == 1) {
                        kartojas = spetosRaidesNeteisingos.Contains(ivestasSpejimas[0]);
                        kartojasGerose = spetosRaidestesingos.Contains(ivestasSpejimas[0]);
                        Console.Clear();
                        if (kartojas || kartojasGerose ) Console.WriteLine("raide kartojas");
                        
                    }

                } while (kartojas || kartojasGerose || ivestasSpejimas.Length ==0);
                
                
                SpejimoTikrinimas(ivestasSpejimas);

                Vaizdavimas();

            }

           
            
        }

        static void SpejimoTikrinimas(string spejimas)
        {
            if (spejimas.Length > 1)
            {
                if (spejimas.ToLower().Equals(zod) )
                {
                    Console.WriteLine($"Sveikinai laimejote zodis buvo {zod}");
                    Console.ReadLine();
                    gameover();
                }
                else { Lives = 0;
                    Console.WriteLine($"Mirete zodis buvo {zod}");
                    Console.ReadLine();
                    gameover();


                }
            }
            else {

                bool aratspejo =  false;
                for (int i = 0; i < raides.Length; i++) 
                {
                    if (raides[i] == spejimas[0]) { rodomos[i] = true; aratspejo = true; }
                
                }
                if (!aratspejo) { Lives += -1; spetosRaidesNeteisingos.Add(spejimas[0]); }
                else { spetosRaidestesingos.Add(spejimas[0]); }
                if (!rodomos.Contains(false)) { 
                    Laimejo = true;
                    Console.WriteLine($"Sveikinai laimejote zodis buvo {zod}");
                    Console.ReadLine();
                    gameover();
                }

            }
        
        
                
        }
        static void Vaizdavimas() 
        {
            Console.Clear();
            Console.WriteLine(@"-------- | ");
            for (int i = 0; i < Deadman.Length; i++)
            {
                if (9-i >= Lives) 
                { Console.WriteLine(Deadman[i].ToString()); }
                else
                { Console.WriteLine(Alive[i].ToString()); }


            }
            Console.WriteLine();


            for (int i = 0; i < raides.Length; i++)
            {
                if (rodomos[i]) Console.Write($" {raides[i]}" );
                else { Console.Write(" _ "); }


            }
            
            Console.WriteLine($"  \n  Gyvybes : {Lives} \n  Netspetos raides : { string.Join(" ",spetosRaidesNeteisingos.ToArray()) }");

        }
        static void gameover() {
            Console.WriteLine("Game Over");
            Console.WriteLine($" zodis buvo {zod}");
            Console.WriteLine("Ar norite testi ? Y/n");
            string arnoritesti = Console.ReadLine();
            if (arnoritesti.ToLower() == "y") { Main(); }
            Environment.Exit(0);
        
        }

    }
}
