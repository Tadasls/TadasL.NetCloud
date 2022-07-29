namespace SNamDrb_Kartuves
{
    public class Program
    {
        public static string[] varduMasyvas = new string[] { "Akvile", "Titas", "Tadas", "Kristijonas", "Dainius", "Sauleja", "Mikas", "Merunas", "Augustinas", "Justinas" };
        public static string[] miestuMasyvas = new string[] { "Kaunas", "Vilnius", "Klaipeda", "Mazeikiai", "Šiauliai", "Panevezys", "Alytus", "Marijampole", "Palanga", "Nida" };
        public static string[] valstybiuMasyvas = new string[] { "Lietuva", "Lenkija", "Ukraina", "Rusija", "Vengrija", "Norvegija", "Svedija", "Anglija", "Prancuzija", "Belgija" };
        public static string[] kitasMasyvas = new string[] { "kitkas" };
        public static string[] piesinys = new string[] { "       ", " \" 0  1 piesinys", "\" 0 / 2 piesinys", "3 piesinys ", "4 piesinys", "5 piesinys", "6 piesinys", "7 piesinys", "8piesinys", "9piesinys" };

        public static List<string> varduSarasas = varduMasyvas.ToList();
        public static List<string> miestuSarasas = miestuMasyvas.ToList();
        public static List<string> valstybiuSarasas = valstybiuMasyvas.ToList();
        public static List<string> kitasSarasas = kitasMasyvas.ToList();

        public static List<char> atspetosRaides = new List<char>();
        public static List<char> neatspetosRaides = new List<char>();
             
        
        public static char[] spejamosRaides;
        public static bool[] rodomosRaides; 

        public static string zodisSpejimui;
        
        public static int likeBandymai = 9;
        public static int piesinysIndex = 0;

        public static bool atspetasZodis = false;
        public static bool pakartotaNeatspetaRaide = false;
        public static bool pakartotaAtspetaRaide = false;

        



        static void Main(string[] args)
        {
            PradinisPasirinkimasTemu();
        }
        public static void PradinisPasirinkimasTemu()
        {
            int indexRandom;
            Random random = new Random();
            int temosNr;
            
            do
            {
                Console.WriteLine("Pasirenkite vieną iš temų: \n 1) VARDAI, \n 2) LIETUVOS MIESTAI,\n 3) VALSTYBES,\n 4) KITA.");
                int.TryParse(Console.ReadLine(), out temosNr);
                Console.Clear();
            } while (temosNr != 1 && temosNr != 2 && temosNr != 3 && temosNr != 4 );

                switch (temosNr)  
                {
                    case 1:
                        indexRandom = random.Next(0, varduSarasas.Count - 1);
                        zodisSpejimui = varduSarasas[indexRandom];
                        varduSarasas.RemoveAt(indexRandom);
                        Console.WriteLine(String.Join(", ", varduSarasas)); // istrinti
                        ZaidimasKartuves(zodisSpejimui);
                       break;
                    case 2:
                        indexRandom = random.Next(0, miestuSarasas.Count - 1);
                        zodisSpejimui = miestuSarasas[indexRandom];
                        miestuSarasas.RemoveAt(indexRandom);
                        ZaidimasKartuves(zodisSpejimui);

                        break;
                    case 3:
                        indexRandom = random.Next(0, valstybiuSarasas.Count - 1);
                        zodisSpejimui = valstybiuSarasas[indexRandom];
                        valstybiuSarasas.RemoveAt(indexRandom);
                        ZaidimasKartuves(zodisSpejimui);

                        break;
                    case 4:
                        indexRandom = random.Next(0, kitasSarasas.Count - 1);
                        zodisSpejimui = kitasSarasas[indexRandom];
                        kitasSarasas.RemoveAt(indexRandom);
                        ZaidimasKartuves(zodisSpejimui);
                        break;
                    default:
                        Console.WriteLine("Wrong Meniu");
                        break;

                }  
        }


        public static void ZaidimasKartuves(string zodisSpejimui)
        {
            string ivedimas;
          
            spejamosRaides = zodisSpejimui.ToLower().ToCharArray();
            //rodomosRaides = Enumerable.Repeat(false, spejamosRaides.Length).ToArray();   
            rodomosRaides = new bool[spejamosRaides.Length];

            for (int i = 0; i < spejamosRaides.Length; i++)
            {
                rodomosRaides[i] = false;
            }

            while (likeBandymai != 0)
            {

                  

                do
                {

                    Console.WriteLine();
                    Console.WriteLine(" Iveskite spėjamą raidę arba spėkite žodį: ");
                    ivedimas = Console.ReadLine().ToLower(); 
                    Console.Clear();




                    if (ivedimas.Length == 1)
                    {
                        pakartotaNeatspetaRaide = neatspetosRaides.Contains(ivedimas[0]);
                        pakartotaAtspetaRaide = atspetosRaides.Contains(ivedimas[0]);
                        
                    }


                } while (pakartotaNeatspetaRaide || pakartotaAtspetaRaide || ivedimas.Length == 0 ) ;

                    ZodzioSpejimoTikrinimas(ivedimas);
                    Isvestis();


            }
            PabaigosMetodas();





        }

        

        public static void ZodzioSpejimoTikrinimas(string ivedimas)
        {
            if (ivedimas.Length >1 )
            {
                if (ivedimas == zodisSpejimui)
                {
                    Sveikinimai();
                    
                }

                else
                {
                    Console.WriteLine("Neatspejote - Zaidimas baigtas");
                    Environment.Exit(1);
                }


            }
            
            
            else
            {
                bool raidesSpejimas = false;
                for (int i = 0; i < spejamosRaides.Length; i++)
                {
                    if (spejamosRaides[i] == ivedimas[0])
                    {
                        rodomosRaides[i] = true;
                        raidesSpejimas = true;
                    }
                }

                if (!raidesSpejimas)
                {
                    likeBandymai--;
                    piesinysIndex++;
                    neatspetosRaides.Add(ivedimas[0]);
                    
                }
                else 
                {
                    atspetosRaides.Add(ivedimas[0]); 
                }

                if (!rodomosRaides.Contains(false))
                {
                    atspetasZodis = true; 
                    Sveikinimai();
                }

            }
            



        }



        public static void Isvestis()
        {
            string p0;
            string p1;
            string p2;
            string p3;
            string p4;
            string p5;
            string p6;
            string p7;
            string p9;


             if (likeBandymai > 1) { p0 = " ";}
             if (likeBandymai > 2) { p1 = "0"; }
             if (likeBandymai > 3) { p2 = "\" "; }
             if (likeBandymai > 4) { p3 = "| "; }
             if (likeBandymai > 5) { p4 = "/ "; }
             if (likeBandymai > 6) { p5 = "0 "; }
             if (likeBandymai > 7) { p6 = "/ "; }
             if (likeBandymai > 8) { p7 = " \""; }
             if (likeBandymai > 9) { p7 = " \""; }


            Console.WriteLine($" |--------| {p0}         "); 
            Console.WriteLine($" |        {p1} {p2} {p3}     ");
            Console.WriteLine($" |        {p4}                 ");
            Console.WriteLine($" |            {p5}             ");
            Console.WriteLine($" |         {p6}    {p7}       ");
            Console.WriteLine($" |_____________                 ");




            

           

            

            for (int i = 0; i < spejamosRaides.Length; i++)
            {
                if (rodomosRaides[i]) Console.Write($" {spejamosRaides[i]}");
                else { Console.Write(" _ "); }


            }

            if (pakartotaNeatspetaRaide || pakartotaAtspetaRaide) Console.WriteLine("raide jau buvo ivesta");
        }









        public static void Sveikinimai()
        {
            Console.WriteLine($"!!! Sveikinimai !!! \n  Atspėjote žodį !!! \n Zodis buvo {zodisSpejimui}");
            Console.ReadLine();
            PabaigosMetodas();
        }



        public static void PabaigosMetodas()
        {
            Console.WriteLine();
            Console.WriteLine("Zaidimas Baigtas, ar Norite testi? T/N ");
            string tesimas = Console.ReadLine();
            if (tesimas == "T" || tesimas == "t")
            {
                Console.Clear();
                PradinisPasirinkimasTemu();
            }
            else
            {
                Environment.Exit(1);
            };
        }

        //public static void Reset()
        //{
        //    rezultatas = null;

        //}




        //public static string deadmanFinal9 = ($"   O     " +
        //                                     $"  \'|/    " +
        //                                     $"    0     " +
        //                                     $"   / \'   " );








        /*  Instructions
- Naudotojas pasirenka iš temų: VARDAI, LIETUVOS MIESTAI, VALSTYBES, KITA. 
  (ne mažiau kaip 10 žodžių kiekvienoje grupėje)
- Žodis iš pasirinktos grupės parenkamas atsitiktine tvarka.
- Užtikrinti kad nebūtu duodamas tas pat žodis daugiau kaip 1 kartą per žaidimą
- Užtikrinti, kad programą nenulūžtu jei vartotojas įveda ne tai ko prašoma
- Ėjimas skaitomas tik jei spėjama dar nespėta raidė
- Jei spėjamas visas žodis ir neatspėjama - iškarto pralaimima
- Parodoma atspėtos raidės vieta žodyje
- Parodomos spėtos, bet neatspėtos raidės

Apribojimai:
- Žodžius saugoti masyvuose  arba žodyne.
- Kodą skaidyti į metodus.
- negalima naudoti OOP ir LINQ

        */

        


    }
}