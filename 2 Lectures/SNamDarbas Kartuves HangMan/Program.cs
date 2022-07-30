using System.Text;

namespace SNamDarbas_Kartuves_HangMan
{
    public class Program
    {
        #region // Kintamieji
        public static string[] varduMasyvas = new string[] { "Akvile", "Titas", "Tadas", "Kristina", "Dainius", "Stasys", "Lina", "Merunas", "Jolanta", "Justinas" };
        public static string[] miestuMasyvas = new string[] { "Kaunas", "Vilnius", "Klaipeda", "Mazeikiai", "Šiauliai", "Panevezys", "Alytus", "Marijampole", "Palanga", "Nida" };
        public static string[] valstybiuMasyvas = new string[] { "Lietuva", "Lenkija", "Ukraina", "Rusija", "Vengrija", "Norvegija", "Svedija", "Anglija", "Prancuzija", "Belgija" };
        public static string[] kitasMasyvas = new string[] { "kitkas", "niekas" };
        public static string[] temuMasyvas = new string[] { "1. VARDAI, \n", "2. LIETUVOS MIESTAI, \n", "3. VALSTYBES, \n", "4. KITA. " };
        public static string[] kunoPiesinys = new string[] { "\\", "/", "0", "/", "|", "\\", "o" };
        public static string[] piesiamasKunas = new string[kunoPiesinys.Length];

        public static char[] spejamosRaides;
        public static char[] tusciosRaides;
        public static bool[] rodomosRaides;
        public static string laistinosRaides = "AaĄąBbCcČčDdEeĘęĖėFfGgHhIiĮįYyJjKkLlMmNnOoPpRrSsŠšTtUuŲųŪūVvZzŽž";
        public static string zodisSpejimui;

        public static int spejimoBandymai = 7;
        public static int temosNr;
        public static string tesimas;


        public static bool galimiSimboliai = false;
        public static bool atspetasZodis = false;
        public static bool pakartotaNeatspetaRaide = false;
        public static bool pakartotaAtspetaRaide = false;

        public static List<char> atspetosRaides = new List<char>();
        public static List<char> neatspetosRaides = new List<char>();

        public static List<string> varduSarasas = varduMasyvas.ToList();
        public static List<string> miestuSarasas = miestuMasyvas.ToList();
        public static List<string> valstybiuSarasas = valstybiuMasyvas.ToList();
        public static List<string> kitasSarasas = kitasMasyvas.ToList();
        public static List<string> temuSarasas = temuMasyvas.ToList();
        public static List<string> zodziuSarasas;

        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);
            PasirinkimasTemu();   //zaidimo pradzia
        }
        public static void PasirinkimasTemu()
        {
            do
            {
                Console.WriteLine("Pasirenkite vieną iš temų:\n" + string.Join("", temuSarasas));
                int.TryParse(Console.ReadLine(), out temosNr);
                Console.Clear();
            } while (temosNr != 1 && temosNr !=2 && temosNr != 3 && temosNr != 4); // ciklas neleidzia nieko ivesti iskyrus 1,2,3,4
            switch (temosNr)
            {
                case 1:
                    AtsitiktineGeneracija(varduSarasas);
                    break;
                case 2:
                    AtsitiktineGeneracija(miestuSarasas);
                    break;
                case 3:
                    AtsitiktineGeneracija(valstybiuSarasas);
                    break;
                case 4:
                    AtsitiktineGeneracija(kitasSarasas);
                    break;
                default:
                    Console.WriteLine("Toks Meniu pasirinkimas neįmanomas");
                    break;
            }
            ZaidimasKartuves(zodisSpejimui);
        }
        public static string AtsitiktineGeneracija(List<string> zodziuSarasas)
        {
            int indexRandom;
            Random rand = new Random();
            indexRandom = rand.Next(0, zodziuSarasas.Count - 1);
            zodisSpejimui = zodziuSarasas[indexRandom];
            zodziuSarasas.RemoveAt(indexRandom);
            return zodisSpejimui; //sugeneruoja viena atsitiktini zody is saraso
        }
        public static void ZaidimasKartuves(string zodisSpejimui)
        {
            string ivedimas;      
            spejamosRaides = zodisSpejimui.ToLower().ToCharArray();
            string tusciosRaides = new string('-', (int)spejamosRaides.Length);
            rodomosRaides = new bool[spejamosRaides.Length];

            Console.WriteLine($"pasirinkta Tema: {temuSarasas[temosNr - 1]}");
            KartuviuPiesimas();                 
            Console.WriteLine($"Zodis:  {tusciosRaides} ");

            for (int i = 0; i < spejamosRaides.Length; i++)
            {
                rodomosRaides[i] = false;
            }
            
                while (spejimoBandymai != 0)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Spėkite raidę ar žodį: ");
                        ivedimas = Console.ReadLine().ToLower();
                        Console.Clear();

                        NeleistinoSimbolioIrRaidesPasikartojimoValidacija(ivedimas);
                        ZodzioSpejimoTikrinimas(ivedimas);

                    } while (pakartotaNeatspetaRaide || pakartotaAtspetaRaide || ivedimas.Length == 0 || !galimiSimboliai); // ciklas neleidzia vesti pasikartojimu ir neleistinu simboliu
                                
                KartuviuPiesimas();
                RaidziuTikrinimas(ivedimas);
                NeatspetuRaidziuRodymas();
                AtspetuRaidziuRodymas();
                


                }
            TemuPabaigosMetodas();
            PabaigosMetodas();
        }
        public static void KartuviuPiesimas()
         {
            for (int i = 6; i >= spejimoBandymai; i--)
            {
                piesiamasKunas[i] = kunoPiesinys[i];
            }
            Console.WriteLine("| - - - - - - |"); //ideja refactorinimui i viena stringa piesiny perdaryti ir testams atiduoti kaip stringą
            Console.WriteLine("|             {0}", piesiamasKunas[6]);
            Console.WriteLine("|            {0}{1}{2}", piesiamasKunas[5], piesiamasKunas[4], piesiamasKunas[3]);
            Console.WriteLine("|             {0}", piesiamasKunas[2]);
            Console.WriteLine("|            {0} {1}", piesiamasKunas[1], piesiamasKunas[0]);
            Console.WriteLine("|");
            Console.WriteLine("|_ _ _ _");


         }
        public static void RaidziuTikrinimas(string ivedimas) 
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
            if (raidesSpejimas)
            {
                atspetosRaides.Add(ivedimas[0]);
            }
            else
            {
                spejimoBandymai--;
                neatspetosRaides.Add(ivedimas[0]);
            }
            if (!rodomosRaides.Contains(false))
            {
                atspetasZodis = true;
                Sveikinimai();
            }

        }
        public static void NeatspetuRaidziuRodymas() 
        {
            Console.WriteLine($"Spetos raides: {string.Join(", ", neatspetosRaides)}");
        }
        public static bool[] AtspetuRaidziuRodymas() //grazinuosi char masyva 
        {
            Console.Write("Zodis: ");
            for (int i = 0; i < spejamosRaides.Length; i++)
            {
                if (rodomosRaides[i]) Console.Write($" {spejamosRaides[i]}");
                else { Console.Write(" _ "); }
            }
            Console.WriteLine();
            return rodomosRaides;

        }
        public static bool NeleistinoSimbolioIrRaidesPasikartojimoValidacija(string ivedimas)
        {
            if (ivedimas.Length == 1)
            {
                
                pakartotaNeatspetaRaide = neatspetosRaides.Contains(ivedimas[0]);
                pakartotaAtspetaRaide = atspetosRaides.Contains(ivedimas[0]);
                galimiSimboliai = laistinosRaides.Contains(ivedimas[0]);

                if (!galimiSimboliai) Console.WriteLine($"simbolis {ivedimas[0]} negalimas ");
                if (pakartotaNeatspetaRaide || pakartotaAtspetaRaide) Console.Write($"raide {ivedimas[0]} jau buvo ivesta, veskite kita raide");
               
            }
            return galimiSimboliai;
        }
        public static bool ZodzioSpejimoTikrinimas(string ivedimas ) //testavimui grazinu spejama zody
        {
            if (ivedimas.Length > 1)
            {
                if (ivedimas == zodisSpejimui.ToLower())
                {
                    Sveikinimai();
                    return true;
                }
                else
                {
                    return false;
                    Console.WriteLine($"Neatspejote zodzio: {zodisSpejimui.ToUpper()}  - Zaidimas baigtas nes Jusu spejimas buvo {ivedimas.ToUpper()} ");
                    Environment.Exit(1);
                    
                }
               return true;
            }
            return true;
        }
        public static void Sveikinimai()
        {
            Console.WriteLine($"!!! Sveikinimai !!! \n  Atspėjote žodį !!! \n Zodis buvo {zodisSpejimui.ToUpper()}");
            Console.ReadLine();// tiesiog kad nebugintu
            TemuPabaigosMetodas();
            PabaigosMetodas();
        }// teisingu spejimu  atveju
        public static void TemuPabaigosMetodas() 
        {
            if (varduSarasas.Count == 0)
            {
                Console.WriteLine($"Išnaudojote visus Temos Vardai zodzius ");
                temuSarasas[0]= "      ";
            }
            if (miestuSarasas.Count == 0)
            {
                Console.WriteLine($"Išnaudojote visus Temos Miestai zodzius");
                temuSarasas[1] = "      ";
            }
            if (valstybiuSarasas.Count == 0)
            {
                Console.WriteLine($"Išnaudojote visus Temos Valstybes zodzius");
                temuSarasas[2]= "     ";
            }
            if (kitasSarasas.Count == 0)
            {
                Console.WriteLine($"Išnaudojote visus Temos KitosTemos  zodzius");
                temuSarasas[3] = "     ";
            }
            if (temuSarasas.Count == 0)
            {
                Console.WriteLine("Išnaudojote visas Temas - GameOver )");
                Environment.Exit(1);
            }
       
        }
        public static void PabaigosMetodas() //restartuoja pagal pasirinkima
        {
            do
            {
                Console.WriteLine();
                Console.WriteLine("Zaidimas Baigtas, ar Norite testi? T/N ");

                string tesimas = Console.ReadLine().ToUpper();

                if (tesimas == "T" || tesimas == "t")
                {
                    Reset();
                    Console.Clear();
                    PasirinkimasTemu();
                }
                else if (tesimas == "N" || tesimas == "n")
                {
                    Environment.Exit(1);
                };
                Console.Clear();
            } while (tesimas != "T" && tesimas != "t" && tesimas != "N" && tesimas != "n"); // ciklas neleidzia nieko ivesti iskyrus T/N

        }
        public static void Reset() //nusinulina reiksmes ir piesimai
        {
            atspetosRaides = new List<char>();
            neatspetosRaides = new List<char>();
            char[] spejamosRaides = null;
            bool[] rodomosRaides = null;
            spejimoBandymai = 7;
            atspetasZodis = false;
            pakartotaNeatspetaRaide = false;
            pakartotaAtspetaRaide = false;
            Array.Clear(piesiamasKunas, 0, kunoPiesinys.Length);

        }
      
        /*  Instructions todo
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