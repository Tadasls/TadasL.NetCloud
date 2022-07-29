using System.Text;

namespace SNamDrb_Kartuves
{
    public class Program
    {
        #region // Kintamieji
        public static string[] varduMasyvas = new string[] { "Akvile", "Titas", "Tadas", "Kristijonas", "Dainius", "Sauleja", "Mikas", "Merunas", "Augustinas", "Justinas" };
        public static string[] miestuMasyvas = new string[] { "Kaunas", "Vilnius", "Klaipeda", "Mazeikiai", "Šiauliai", "Panevezys", "Alytus", "Marijampole", "Palanga", "Nida" };
        public static string[] valstybiuMasyvas = new string[] { "Lietuva", "Lenkija", "Ukraina", "Rusija", "Vengrija", "Norvegija", "Svedija", "Anglija", "Prancuzija", "Belgija" };
        public static string[] kitasMasyvas = new string[] { "kitkas" };
        public static string[] temuMasyvas = new string[] { "1. VARDAI, \n", "2. LIETUVOS MIESTAI, \n", "3. VALSTYBES, \n", "4. KITA. " };
        public static string[] kunoPiesinys = new string[] { "\\", "/", "0", "/", "|", "\\", "o" };

        public static string[] piesiamasKunas = new string[kunoPiesinys.Length];


        public static List<string> varduSarasas = varduMasyvas.ToList();
        public static List<string> miestuSarasas = miestuMasyvas.ToList();
        public static List<string> valstybiuSarasas = valstybiuMasyvas.ToList();
        public static List<string> kitasSarasas = kitasMasyvas.ToList();
        public static List<string> temuSarasas = temuMasyvas.ToList();


        public static List<char> atspetosRaides = new List<char>();
        public static List<char> neatspetosRaides = new List<char>();



        public static char[] spejamosRaides;
        public static char[] tusciosRaides;
        public static bool[] rodomosRaides;


        public static string zodisSpejimui;

        public static int spejimoBandymai = 7;
        public static int temosNr;

        public static bool galimiSimboliai = false;
        public static bool atspetasZodis = false;
        public static bool pakartotaNeatspetaRaide = false;
        public static bool pakartotaAtspetaRaide = false;

        #endregion

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);
            PradinisPasirinkimasTemu();
        }
        public static void PradinisPasirinkimasTemu()
        {
            int indexRandom;
            Random random = new Random();

            do
            {
                //Console.WriteLine("Pasirenkite vieną iš temų: \n 1) VARDAI, \n 2) LIETUVOS MIESTAI,\n 3) VALSTYBES,\n 4) KITA.");
                Console.WriteLine("Pasirenkite vieną iš temų:\n" + string.Join("", temuSarasas));
                int.TryParse(Console.ReadLine(), out temosNr);
                Console.Clear();
            } while (temosNr != 1 && temosNr != 2 && temosNr != 3 && temosNr != 4);

            switch (temosNr)
            {
                case 1:
                    indexRandom = random.Next(0, varduSarasas.Count - 1);
                    zodisSpejimui = varduSarasas[indexRandom];
                    varduSarasas.RemoveAt(indexRandom);
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


            Console.WriteLine($"pasirinkta Tema: {temuSarasas[temosNr - 1]}");
            Console.WriteLine("|-------|");
            Console.WriteLine("|           {0}", piesiamasKunas[6]);
            Console.WriteLine("|          {0}{1}{2}", piesiamasKunas[5], piesiamasKunas[4], piesiamasKunas[3]);
            Console.WriteLine("|           {0}", piesiamasKunas[2]);
            Console.WriteLine("|          {0} {1}", piesiamasKunas[1], piesiamasKunas[0]);
            Console.WriteLine("|           ");
            Console.WriteLine("|____       ");

            spejamosRaides = zodisSpejimui.ToLower().ToCharArray();
            rodomosRaides = new bool[spejamosRaides.Length];
            //rodomosRaides = Enumerable.Repeat(false, spejamosRaides.Length).ToArray();  

            string laistinosRaides = "AaĄąBbCcČčDdEeĘęĖėFfGgHhIiĮįYyJjKkLlMmNnOoPpRrSsŠšTtUuŲųŪūVvZzŽž";
            string tusciosRaides = new string('-', (int)spejamosRaides.Length);
            Console.WriteLine($"Zodis:  {tusciosRaides} ");


            for (int i = 0; i < spejamosRaides.Length; i++)
            {
                rodomosRaides[i] = false;
            }

            while (spejimoBandymai != 0)
            {
                do
                {

                    Console.WriteLine(" Spėkite raidę ar žodį: ");
                    ivedimas = Console.ReadLine().ToLower();
                    Console.Clear();

                    if (ivedimas.Length == 1)
                    {
                        pakartotaNeatspetaRaide = neatspetosRaides.Contains(ivedimas[0]);
                        pakartotaAtspetaRaide = atspetosRaides.Contains(ivedimas[0]);
                        galimiSimboliai = laistinosRaides.Contains(ivedimas[0]);

                        if (!galimiSimboliai) Console.WriteLine($"simbolis {ivedimas[0]} negalimas ");
                        if (pakartotaNeatspetaRaide || pakartotaAtspetaRaide) Console.Write($"raide {ivedimas[0]} jau buvo ivesta, veskite kita raide");
                    }
                    ZodzioSpejimoTikrinimas(ivedimas);


                } while (pakartotaNeatspetaRaide || pakartotaAtspetaRaide || ivedimas.Length == 0 || !galimiSimboliai);

                RaidziuSpejimoTikrinimas(ivedimas);
                VaizdavimasEkrane();
                //   Console.WriteLine();




            }
            TemuPabaigosMetodas();


        }
        public static void ZodzioSpejimoTikrinimas(string ivedimas)
        {
            if (ivedimas.Length > 1)
            {
                if (ivedimas == zodisSpejimui.ToLower())
                {
                    Sveikinimai();

                }

                else
                {
                    Console.WriteLine($"Neatspejote zodzio: {zodisSpejimui.ToUpper()}  - Zaidimas baigtas nes Jusu spejimas buvo {ivedimas.ToUpper()} ");
                    Environment.Exit(1);
                }


            }
        }
        public static void RaidziuSpejimoTikrinimas(string ivedimas)
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
                spejimoBandymai--;
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





        public static void Sveikinimai()
        {
            Console.WriteLine($"!!! Sveikinimai !!! \n  Atspėjote žodį !!! \n Zodis buvo {zodisSpejimui.ToUpper()}");
            Console.ReadLine();// kad nebugintu
            TemuPabaigosMetodas();
        }
        public static void TemuPabaigosMetodas()
        {
            if (varduSarasas.Count == 0)
            {
                Console.WriteLine($"Išnaudojote visus Temos Vardai zodzius ");
                temuSarasas.RemoveAt(0);
            }
            if (miestuSarasas.Count == 0)
            {
                Console.WriteLine($"Išnaudojote visus Temos Miestai zodzius");
                temuSarasas.RemoveAt(1);
            }
            if (valstybiuSarasas.Count == 0)
            {
                Console.WriteLine($"Išnaudojote visus Temos Valstybes zodzius");
                temuSarasas.RemoveAt(2);
            }
            if (kitasSarasas.Count == 0)
            {
                Console.WriteLine($"Išnaudojote visus Temos KitosTemos  zodzius");
                temuSarasas.RemoveAt(3);
            }
            if (temuSarasas.Count == 0)
            {
                Console.WriteLine("Išnaudojote visas Temas - GameOver )");
                Environment.Exit(1);
            }
            PabaigosMetodas();
        }
        public static void PabaigosMetodas()
        {
            Console.WriteLine();
            Console.WriteLine("Zaidimas Baigtas, ar Norite testi? T/N ");
            string tesimas = Console.ReadLine().ToUpper();

            if (tesimas == "T" || tesimas == "t")
            {

                Reset();
                Console.Clear();
                PradinisPasirinkimasTemu();
            }
            else
            {
                Environment.Exit(1);
            };
        }
        public static void Reset()
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
        public static void VaizdavimasEkrane()
        {
            for (int i = 6; i >= spejimoBandymai; i--)
            {
                piesiamasKunas[i] = kunoPiesinys[i];
            }

            Console.WriteLine("|-------|");
            Console.WriteLine("|       {0}", piesiamasKunas[6]);
            Console.WriteLine("|      {0}{1}{2}", piesiamasKunas[5], piesiamasKunas[4], piesiamasKunas[3]);
            Console.WriteLine("|       {0}", piesiamasKunas[2]);
            Console.WriteLine("|      {0} {1}", piesiamasKunas[1], piesiamasKunas[0]);
            Console.WriteLine("|           ");
            Console.WriteLine("|____       ");

            Console.WriteLine($"Spetos raides: {string.Join(", ", neatspetosRaides)}");


            Console.Write("Zodis: ");
            for (int i = 0; i < spejamosRaides.Length; i++)
            {
                if (rodomosRaides[i]) Console.Write($" {spejamosRaides[i]}");
                else { Console.Write(" _ "); }
            }
            Console.WriteLine();

        }






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