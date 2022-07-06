using System.Diagnostics;
using System.Globalization;

namespace P014_Debuginimas
{
    public class Program
    {
        public static bool arbuvonormalizuota = false;
        public static bool arGrandineValidi = false;
        public static string dnrGrandine = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Debug!");
            //Pinigas();
            //Console.WriteLine(DecimalHour(Console.ReadLine()));
            //DaugiakampioPlotas_Main(null);
            //MatematikaPapildymas_Main(null);
            DNR();
        }
            /*---------------------------------------------------
                Tarkime turime DNR grandinę užkoduotą tekstu var txt =" T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ".
            Galimos bazės: Adenine, Thymine, Cytosine, Guanine
            Parašykite programą kurioje atsiranda MENIU kuriame naudotojas gali pasirinkti:
            1. Atlikti DNR grandinės normalizavimo veiksmus:
                - pašalina tarpus.
                - visas raides keičia didžiosiomis. 
            2. Atlikti grandinės validaciją
                - patikrina ar nėra kitų nei ATCG raidžių
        3. Atlieka veiksmus su DNR grandine (tik tuo atveju jei grandinė yra normalizuota ir validi). 
        Nuspaudus 3 įeinama į sub-meniu
            - Jeigu grandinė yra validi, tačiau nenormalizuota programa pasiūlo naudotojui 
            1) normalizuoti grandinę
            2) išeiti iš programos
            - jei grandinė normalizuota arba kai buvo atlikta normalizacija
            1) GCT pakeis į AGG
            2) Išvesti ar yra tekste CAT 
            3) Išvesti trečia ir penktą grandinės segmentus (naudoti Substring()).
            4) Išvesti raidžių kiekį tekste (naudoti string composition)
            5) Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas 
            6) Prie grandinės galo pridėti iš klaviatūros įvesta segmentą  
                (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės) 
            7) Iš grandinės pašalinti pasirinką elementą  
            8) Pakeisti pasirinkti segmentą įvestu iš klaviatūros  
                (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės) 
            9) Gryžti į ankstesnį meniu
       Visoms operacijoms reikalingi testai.
       */

        public static void DNR()
        {

            //string dnrGrandine = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";  // nesutvarkyta
            string dnrGrandine = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT"; // sutvarkyta

            Console.WriteLine($"Pasirinkite veiksma \n 1) DNR grandinės normalizavimas \n 2) DNR Grandinės validavimas \n 3) Sub-meniu \n ");
            string meniu = Convert.ToString(Console.ReadLine());

            switch (meniu) //state machine
            {
                case "1":
                    arbuvonormalizuota = GrandinesNormalizavimas(ref dnrGrandine);
                    Console.WriteLine(" Grandine buvo Normalizuota");
                    break;
                case "2":
                    arGrandineValidi =  GrandinesValidavimas(ref dnrGrandine);
                    Console.WriteLine($"Ar grandine Validi {arGrandineValidi.ToString()} ");
                    break;
                case "3":
                    if (arGrandineValidi)
                        TreciasPasirinkimas(arbuvonormalizuota, arGrandineValidi, ref dnrGrandine);
                    break;
            }
        }
       
        public static bool GrandinesNormalizavimas(ref string dnrGrandine)
        {
            dnrGrandine = dnrGrandine.Trim().ToUpper().Replace(" ","");
            Console.WriteLine("Po normalizavimo ! " + dnrGrandine);
            Debug.WriteLine("pasalinti tarpai ir padarytos didziosios");
            return true;
        }
        public static bool GrandinesValidavimas(ref string dnrGrandine)
        {
            string sutrumpintaGrandine = dnrGrandine.ToUpper().Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "").Replace("-", "").Replace(" ", "");
            bool isDnrValid = sutrumpintaGrandine.Length == 0;
            Console.WriteLine("pries validavima ! " + dnrGrandine +"\n ir po normalizavimo" + dnrGrandine.ToUpper().Trim().Replace(" ", ""));
            Debug.WriteLine(" Tikrintos raides A,T,C,G");
            return isDnrValid;
        }

        public static void TreciasPasirinkimas(bool isDnrNormal, bool isDnrValid, ref string dnrGrandine)
        {
            arbuvonormalizuota = GrandinesNormalizavimas(ref dnrGrandine);
            arGrandineValidi = GrandinesValidavimas(ref dnrGrandine);

            if (arbuvonormalizuota && arGrandineValidi)
            {
                Console.WriteLine($"Pasirinkite veiksma \n 1) \n 2) \n 3) \n 4) \n 5) \n 6) \n 7) \n 8) \n 9) \n ");
                string submeniu = Convert.ToString(Console.ReadLine());
                switch (submeniu) //state machine
                {
                    case "1":
                        Console.WriteLine($" 1 ");
                        break;
                    case "2":
                        Console.WriteLine($" 2 ");
                        break;
                    case "3":
                        Console.WriteLine($" 3 ");
                        break;
                    case "4":
                        Console.WriteLine($" 4 ");
                        break;
                    case "5":
                        Console.WriteLine($" 5 ");
                        break;
                    case "6":
                        Console.WriteLine($" 6 ");
                        break;
                    case "7":
                        Console.WriteLine($" 7 ");
                        break;
                    case "8":
                        Console.WriteLine($" 8 ");
                        break;
                    case "9":
                        Console.WriteLine($" 9 ");
                        break;
                    default:
                        Console.WriteLine($" tokio meniu nera");
                        break;
                };
            }
            else
            {
                Console.WriteLine("Normalizuoti Grandine - 1 \n arba Iseiti - 2 ");
                string Kadarom = Console.ReadLine();
                if (Kadarom == "1")
                {
                    arbuvonormalizuota = GrandinesNormalizavimas(ref dnrGrandine);
                    TreciasPasirinkimas(arbuvonormalizuota, arGrandineValidi, ref dnrGrandine);
                }
                else
                {
                    Console.WriteLine("Exit");
                    System.Environment.Exit(-1);
                }
            }

        }
        public static void TreciasSub1(ref string dnrGSrandine)
        {
            //3.2.1
            dnrGSrandine.Replace("GCT", "AGG");
        }
        public static void TreciasSub2(ref string dnrGSrandine)
        {
            //3.2.2
            Console.WriteLine($"  ar grandineje yra CAT  : {dnrGSrandine.Contains("CAT").ToString()} ");
        }
        public static void TreciasSub3(ref string dnrGSrandine)
        {
            //3.2.3 
            //String[] reiksmes = dnrGSrandine.Split("-");
            //Console.WriteLine($" trecios sekcijos reiksmes : {reiksmes[2]}  penktos sekcijos reiksmes : {reiksmes[4]}");
            Console.WriteLine($" trecios sekcijos reiksmes : {dnrGSrandine.Substring(7, 3)}  penktos sekcijos reiksmes : {dnrGSrandine.Substring(16, 3)} ");
        }
        public static void TreciasSub4(ref string dnrGSrandine)
        {
            //3.2.4
            string senagrandine = dnrGSrandine;
            senagrandine = senagrandine.Replace("-", "");
            Console.WriteLine($"Grandines raidziu kiekis = : {senagrandine.Length}");
        }
        public static void TreciasSub5(ref string dnrGSrandine)
        {
            //3.2.5
            Console.WriteLine("Iveskite triju raidiziu koda xxx kuris sudarytas is AGTC");
            string ivestasSegmentas = Console.ReadLine();
            int kartu = dnrGSrandine.Split("-").Count(s => s == ivestasSegmentas);
            Console.WriteLine($" ivestas {ivestasSegmentas} kartojasi tiek kartu : {kartu.ToString()}");
        }
        public static void TreciasSub6(ref string dnrGSrandine)
        {
            //3.2.6
            Console.WriteLine("Iveskite triju raidiziu koda xxx kuris sudarytas is AGTC");
            string ivestasSegmentas2 = Console.ReadLine();
            if (ivestasSegmentas2.Length == 3 && ivestasSegmentas2.Trim().Replace("A", "").Replace("C", "").Replace("T", "").Replace("G", "").Length == 0)
            {
                dnrGSrandine = dnrGSrandine + "-" + ivestasSegmentas2;
                Console.WriteLine($" NAuja grandine {dnrGSrandine}");
            }
        }
        public static void TreciasSub7(ref string dnrGSrandine)
        {
            //3.2.7
            Console.WriteLine("Iveskite segmenta kuri norite salinti");
            string trinamasElemetas = Console.ReadLine();
            dnrGSrandine = dnrGSrandine.Replace(trinamasElemetas, "");
            Console.WriteLine($" grandine po valymo {dnrGSrandine}"); 
        }
        public static void TreciasSub8(ref string dnrGSrandine)
        {
            //3.2.8 
            Console.WriteLine("Iveskite segmenta kuri norite keisti");
            string pasirinktasElementas = Console.ReadLine();
            Console.WriteLine("Iveskite segmenta kuriuo norite pakeisiti");
            string ivestasElementas = Console.ReadLine();
            if ((pasirinktasElementas.Length == 3 && pasirinktasElementas.Trim().Replace("A", "").Replace("C", "").Replace("T", "").Replace("G", "").Length == 0) && (ivestasElementas.Length == 3 && ivestasElementas.Trim().Replace("A", "").Replace("C", "").Replace("T", "").Replace("G", "").Length == 0))
            {
                dnrGSrandine = dnrGSrandine.Replace(pasirinktasElementas, ivestasElementas);
            }
        }
        public static void TreciasSub9(ref string dnrGSrandine)
        {
            //3.2.9
            DNR();
        }









        /*  darbo laikas ivedamas is consoles parodomi trukumai aarba virsvalandziai
         Įveskite darbo laiką valandomis ir minutėmis hh.mm arba valandomis, minutėmis ir sekundėmis hh.mm.ss 
         - Konvertuokite išdirbtą laiką į dešimtainę išlaišką
         - Suapvalinkite iki 4 skaičių po kablelio 
        
        Testai:
        DecimalHour("30.30") => "Decimal hour: 30.5"
        DecimalHour("20.30.30") => "Decimal hour: 20.5083"
        DecimalHour("20") => "Invalid time"
        DecimalHour("-20.50") => "Invalid hours"
        DecimalHour("a5.20.20") => "Invalid hours"
        DecimalHour("20.a5") => "Invalid minutes"
        DecimalHour("20.90") => "Invalid minutes"
        DecimalHour("20.30.90") => "Invalid seconds"
        DecimalHour("20.30.a5") => "Invalid seconds"
      
        */
        public static string DecimalHour(string input)
        {
            var isInputValid = IsDecimalHourInputValid(input, out string? msg);
            if (!isInputValid)
                return msg!;


            var a = input.Split(".");
            var dec = Convert.ToDecimal(a[0]) +      //valandos
                      (Convert.ToDecimal(a[1]) / 60) + //pridedame minutes
                      (a.Length > 2 ? (Convert.ToDecimal(a[2]) / 3600) : 0);

            return $"Decimal hour: {dec:0.0000}";
        }

        private static bool IsDecimalHourInputValid(string input, out string? msg)
        {
            msg = null;
            var a = input.Split(".");
            if (IsInputTimeInValid(a))
            {
                msg = "Invalid time";
                return false;
            }
            if (IsInputHourInValid(a))
            {
                msg = "Invalid hours";
                return false;
            }
            if (IsInputMinuteInValid(a))
            {
                msg = "Invalid minutes";
                return false;
            }
            if (IsInputSecondsInValid(a))
            {
                msg = "Invalid seconds";
                return false;
            }

            return true;
        }
        private static bool IsInputTimeInValid(string[] a) => a.Length < 2;
        private static bool IsInputHourInValid(string[] a) => !int.TryParse(a[0], out int hour) || hour < 0;
        private static bool IsInputMinuteInValid(string[] a) => !int.TryParse(a[1], out int minute) || minute < 0 || minute > 60;
        private static bool IsInputSecondsInValid(string[] a) => a.Length > 2 && (!int.TryParse(a[2], out int sec) || sec < 0 || sec > 60);

        /* MATEMATIKA ------Skaiciuotuvas su Int---------------------------------------------
         1. Sukurti metodus Suma, Atimtis, Daugyba, Dalyba.
         - Main metode paprašykite įvesti 2 skaičius
         - Kiekvienas matematinis veiksmas turi turėti savo metodą 
           metodas turi priimti 2 int tipo parametrus ir grąžinti atlikto veiksmo rezultatą.
         - Kiekvieno metodo darbo rezultatus atspausdinti Main metode.
         - Visų gautų rezultatų sumą atspausdinti Main metode.
         
        2. Skaičiuotuvas. Naudoti pirmos dalies matematinius metodus.
         - Main metode paprašykite įvesti 2 skaičius ir matematinį veiksmą
         - Metodas 'Skaiciuotuvas' turi priimti tris parametrus du skaičius (int tipo) ir veiksmą. 
         - Metodas 'Skaiciuotuvas' turi parinkti reikiamą matematinį metodą ir grąžinti rezultatą (naudoti switch)
         - parašyti testus
         - gautą rezultatą atspausdinti į ekraną Main metode.
           
         */
        public static double? Skaiciuotuvas(int a, int b, string veiksmas)
        {
            switch (veiksmas) //state machine
            {
                case "+":
                    return Suma(a, b);
                case "-":
                    return Atimtis(a, b);
                case "*":
                    return Daugyba(a, b);
                case "/":
                    return Dalyba(a, b);
                default:
                    return null;
            }
        }
        public static int Suma(int a, int b) => a + b;
        public static int Atimtis(int a, int b) => a - b;
        public static int Daugyba(int a, int b) => a * b;
        public static double Dalyba(int a, int b) => (double)a / b;

        /* DAUGIAKAMPIO PLOTAS---------------------------------------------------
       Paprašyti naudotojo įvesti taisyklingojo daugiakampio kraštių kiekį (n) ir kraštinės ilgį (b)., 
         metodo parinkimui naudoti switch expression
       1. Kai įvestas trikampis, 
       - paprašyti įvesti aukšį h
       - A=1/2bh
       2. Kai įvestas keturkampis,
       - A=b*b
       3. Kai įvestas penkiakampis, šešiakampis ir t.t.,
       - paprašyti įvesti statmenį r
       - A=n/2 * b * r
       4. išvesti betkokio daugiakampio vidinių kampų sumą
       - 180 * (n - 2)
      N.B! atkreipkite dėmesį į metodų testuojamumą. 
        visi atvejai 1,2,3 ir 4 turi būti atskiruose metoduose ir metodai turi būti testuojami
       */
        public static void DaugiakampioPlotas_Main(string[] args)
        {
            Console.WriteLine("Iveskite kraštių kiekį (n)");
            int n = Convert.ToInt32(Console.ReadLine());

            if (!IsKampuKiekisValid(n))
            {
                Console.WriteLine("neteisingas krastiniu kiekis");
                return;
            }

            Console.WriteLine("Iveskite kraštinės ilgį (b)");
            int b = Convert.ToInt32(Console.ReadLine());

            int h = 0;
            int r = 0;
            if (n == 3)
            {
                Console.WriteLine("Iveskite trikampio auksti (h)");
                h = Convert.ToInt32(Console.ReadLine());
            }
            else if (n > 4)
            {
                Console.WriteLine("Iveskite įvesti statmenį (r)");
                r = Convert.ToInt32(Console.ReadLine());
            }

            var A = PligonoPlotas(n, b, h, r);
            var S = VidineKampuSuma(n);
            Console.WriteLine($"plotas A={A}");
            Console.WriteLine($"VidineKampuSuma S={S}");
        }   // verslo logika
        public static bool IsKampuKiekisValid(int n) => n > 2;
        public static double PligonoPlotas(int n, int b, int h = 0, int r = 0) //state machine
        {
            double A = n switch
            {
                1 or 2 => throw new ArgumentException(),
                3 => TrikampioPlotas(b, h),
                4 => KeturkampioPlotas(b),
                _ => DaugiakampioPlotas(n, b, r)
            };

            return A;
        }
        public static double TrikampioPlotas(int b, int h) => 1d / 2 * b * h;  // metodai
        public static double KeturkampioPlotas(int b) => b * b; 
        public static double DaugiakampioPlotas(int n, int b, int r) => n / 2 * b * r;
        public static double VidineKampuSuma(int n) => 180 * (n - 2);

        /* Pinigas ------------------------------
         */
        public static void Pinigas()
        {
            Console.WriteLine("Iveskite pinigu suma");
            var suma = Console.ReadLine();
            var kursas = 5.6;
            Debug.WriteLine("LABAS");
            //var rezultatas = Convert.ToInt32(suma) * kursas; //reikalinga korekcija del didelio skaiciaus pvz 8888888888
            //var rezultatas = Convert.ToInt64(suma) * kursas; //reikalinga korekcija del trupmeninio skaiciaus pvz 20,4
            //var rezultatas = Convert.ToDouble(suma) * kursas; //reikalinga korekcija del trupmeninio skaiciaus su tasku pvz 20.4

            var decimalSeparator = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
            var goupSeparator = CultureInfo.CurrentUICulture.NumberFormat.NumberGroupSeparator;

            suma = suma.Replace(decimalSeparator, goupSeparator);

            var rezultatas = Convert.ToDouble(suma) * kursas;
            Console.WriteLine("Jus turite rankoje {0} pinigus", rezultatas);
            Debug.WriteLine("Jus turite rankoje {0} pinigus", rezultatas);
            Console.ReadKey();
        }

        /* MATEMATIKA SU PASIRINKIMU---------------------------------------------------
      1.Naudodami method overloading sukurkite metodus Suma, Atimtis, Daugyba, Dalyba kurie priima du double tipo parametrus.
        (prieštai sukurtų metodų ištrinti negalima)
      2. Naudotojui įvedus skaičius nustatykite ar buvo įvestas skaičius su kableliu ar be ir duomenis nukreipkite reikiamiems metodams. 
        (Informaciją apie tai, koks metodas buvo panaudotas išveskite į debug konsolę)
      3. Matematinius metodus palildykite kėlimu kvadratu (^2) ir kėlimu kūbu ( ^3).
      4.Padarykite meniu, kur naudotojui leis pasirinkti koks matematinis veiksmas bus atliekamas 
        (gali parinkti arba veiksmą, arba veiksmo numerį meniu. Abiem atvejais bus atliekama matematinė operacija) 
        (Pasirinkimams panaudoti switch sakinį)
          1) +
          2) -
          3) *
          4) /
          5) ^2
          6) ^3
        N.B. Ankstesnis Skaiciuotuvas metodas nemoka atlikti ^2, ir ^3, 
             todel nepriklausomai nuo ar ivesta sveikas ar trupmeninis skaicius reikia nukreipti i naują Matematika metodą
    */

        public static void MatematikaPapildymas_Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu a");
            var a = Console.ReadLine();
            Console.WriteLine("iveskite skaiciu b");
            var b = Console.ReadLine();
            Console.WriteLine(@"Pasirinkite veiksma
            1) +
            2) -
            3) *
            4) /
            5) ^2
            6) ^3
            ");
            var veiksmas = Console.ReadLine();

            double? rezultatas = null;
            rezultatas = Skaiciuotuvas(a, b, veiksmas);

            Console.WriteLine($" {a} {veiksmas} {b} = {rezultatas}");

        }

        public static double? Skaiciuotuvas(string? a, string? b, string? veiksmas)
        {
          VeiksmoNormalizacija(ref veiksmas);
            if (ArSveikiejiSkaiciai(a, b) && !ArNaujasVeiksmas(veiksmas))
            {
                return Skaiciuotuvas(Convert.ToInt32(a), Convert.ToInt32(b), veiksmas);
            }
            else if (ArSkaiciai(a, b))
            {
                return Skaiciuotuvas(Convert.ToDouble(a), Convert.ToDouble(b), veiksmas);
            }

            return null;
        }

        public static void VeiksmoNormalizacija(ref string veiksmas)
        {
            if (veiksmas == "1") {veiksmas = "+";};
            if (veiksmas == "2") {veiksmas = "-";};
            if (veiksmas == "3") {veiksmas = "*";};
            if (veiksmas == "4") {veiksmas = "/";};
            if (veiksmas == "5") {veiksmas = "^2";};
            if (veiksmas == "6") {veiksmas = "^3";};

            //veiksmas = veiksmas.Replace("1", "+");
            //veiksmas = veiksmas.Replace("2", "-");
            //veiksmas = veiksmas.Replace("3", "*");
            //veiksmas = veiksmas.Replace("4", "/");
            //veiksmas = veiksmas.Replace("5", "^2");
            //veiksmas = veiksmas.Replace("6", "^3");

        }

        public static bool ArSveikiejiSkaiciai(string a, string b) => int.TryParse(a, out _) && int.TryParse(b, out _);
        public static bool ArSkaiciai(string a, string b) => double.TryParse(a, out _) && double.TryParse(b, out _);
        public static bool ArNaujasVeiksmas(string veiksmas) => veiksmas == "^2" || veiksmas == "^3";

        public static double? Skaiciuotuvas(double a, double b, string veiksmas)
        {
            switch (veiksmas) //state machine
            {
                case "+":
                    return Suma(a, b);
                case "-":
                    return Atimtis(a, b);
                case "*":
                    return Daugyba(a, b);
                case "/":
                    return Dalyba(a, b);
                case "^2":
                    return Kvadratu(a);
                case "^3":
                    return Kubu(a);
                default:
                    return null;
            }
        }

        public static double Suma(double a, double b) => a + b;
        public static double Atimtis(double a, double b) => a - b;
        public static double Daugyba(double a, double b) => a * b;
        public static double Dalyba(double a, double b) => a / b;
        public static double Kvadratu(double a) => a * a;
        public static double Kubu(double a) => a * a * a;




                    /*---------------------------------------------------
            Tarkime turime DNR grandinę užkoduotą tekstu var txt =" T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ".
            Galimos bazės: Adenine, Thymine, Cytosine, Guanine
            Parašykite programą kurioje atsiranda MENIU kuriame naudotojas gali pasirinkti:
            1. Atlikti DNR grandinės normalizavimo veiksmus:
               - pašalina tarpus.
               - visas raides keičia didžiosiomis. 
            2. Atlikti grandinės validaciją
               - patikrina ar nėra kitų nei ATCG raidžių
            3. Atlieka veiksmus su DNR grandine (tik tuo atveju jei grandinė yra normalizuota ir validi). Nuspaudus 3 įeinama į sub-meniu
                - Jeigu grandinė yra validi, tačiau nenormalizuota programa pasiūlo naudotojui 
                1) normalizuoti grandinę
                2) išeiti iš programos
                - jei grandinė normalizuota arba kai buvo atlikta normalizacija
                1) GCT pakeis į AGG
                2) Išvesti ar yra tekste CAT 
                3) Išvesti trečia ir penktą grandinės segmentus (naudoti Substring()).
                4) Išvesti raidžių kiekį tekste (naudoti string composition)
                5) Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas 
                6) Prie grandinės galo pridėti iš klaviatūros įvesta segmentą  
                    (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės) 
                7) Iš grandinės pašalinti pasirinką elementą  
                8) Pakeisti pasirinkti segmentą įvestu iš klaviatūros  
                    (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės) 
                9) Gryžti į ankstesnį meniu
            Visoms operacijoms reikalingi testai.
            */








    }
}