
using System.Diagnostics;
using System.Globalization;

namespace P014_Debuginimas
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, & Debug!");
            //  Pinigas();
            // Console.WriteLine(DecimalHour(Console.ReadLine()));

            /*

             UŽDUOTIS 1
             1.Sukurti metodus Suma, Atimtis, Daugyba, Dalyba.
          -Main metode paprašykite įvesti 2 skaičius
          - Kiekvienas matematinis veiksmas turi turėti savo metodą
            metodas turi priimti 2 int tipo parametrus ir grąžinti atlikto veiksmo rezultatą.
          -Kiekvieno metodo darbo rezultatus atspausdinti Main metode.
          -Visų gautų rezultatų sumą atspausdinti Main metode.


         2.Skaičiuotuvas.Naudoti pirmos dalies matematinius metodus.
          -Main metode paprašykite įvesti 2 skaičius ir matematinį veiksmą
          -Metodas 'Skaiciuotuvas' turi priimti tris parametrus du skaičius ir veiksmą. 
          -Metodas 'Skaiciuotuvas' turi parinkti reikiamą matematinį metodą ir grąžinti rezultatą(naudoti switch)
          -parašyti testus
          - gautą rezultatą atspausdinti į ekraną Main metode.
            */

            /*
            // pirma dalis
            Console.WriteLine("Iveskite pirma skaiciu");
            int pS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            int aS = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" Skaiciu Suma = {Suma(pS, aS)}");
            Console.WriteLine($" Skaiciu Sandauga = {Sandauga(pS, aS)}");
            Console.WriteLine($" Skaiciu Skirtumas = {Skirtumas(pS, aS)}");
            Console.WriteLine($" Skaiciu Dalyba = {Dalyba(pS, aS)}");

            double total = Suma(pS, aS) + Sandauga(pS, aS) + Skirtumas(pS, aS) + Dalyba(pS, aS);
            Console.WriteLine($"Metodu skaiciu suma {total}");


            // 2 dalis
            Console.WriteLine("Iveskite pirma skaiciu");
            pS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            aS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite aritmetiny veiksma + - / * ");
            string aritmetinisVeiksmas = Console.ReadLine();

            Console.WriteLine($" Gautas rezultatas{Skaiciuotuvas(pS, aS, aritmetinisVeiksmas)} ");
            */

            // 3 
            /*
         DAUGIAKAMPIO PLOTAS---------------------------------------------------
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

            Console.WriteLine("Iveskite krastu n kieki ");
            int n = Convert.ToInt32(Console.ReadLine()); // krastiniuSkaicius
            Console.WriteLine("Iveskite krastines b ilgi ");
            int b = Convert.ToInt32(Console.ReadLine());  // krastines ilgis


            var figurosPlotas = n switch
            {
                0 or 1 or 2 => 0,
                3 => TrikampioPlotas(b),
                4 => KeturkampioPlotas(b),
                5 or 6 or 7 or 8 or 9 or 10 => PenkiakampioIrDaugiauPlotas(n, b),
                _ => DaugiakampioKrastuSuma(n)
            };
            Console.WriteLine(figurosPlotas);


         
        }


        private static double DaugiakampioKrastuSuma(int n)
        {
            return 180 * (n - 2);
        }
        public static double PenkiakampioIrDaugiauPlotas(int n, int b, int r = 5)
        {
            Console.Write("Iveskite statmenį r: ");
            r = Convert.ToInt32(Console.ReadLine());
            return (double)n / 2 * b * r;
        }
        public static double KeturkampioPlotas(int b)
        { 
            return b * b;
        }
        public static double TrikampioPlotas(int b, int h = 5) 
        {
            Console.Write("Iveskite aukšį h: ");
            h = Convert.ToInt32(Console.ReadLine());
            return 0.5D * b * h;
        }












        public static double? Skaiciuotuvas(int pS, int aS, string aritmetinisVeiksmas)
        {
            switch (aritmetinisVeiksmas)
            {
                case "+":
                    Console.WriteLine($"Suma yra {Suma(pS, aS)}");
                    return Suma(pS, aS);
                case "*":
                    Console.WriteLine($"Sandauga yra {Sandauga(pS, aS)}");
                    return Sandauga(pS, aS);
               case "-":
                    Console.WriteLine($"Skirtumas yra {Skirtumas(pS, aS)}");
                    return Skirtumas(pS, aS);
                case "/":
                    Console.WriteLine($"Dalyba yra {Dalyba(pS, aS)}");
                    return Dalyba(pS, aS);
                default:
                    return null;
            }
        }
        
          



        public static int Suma(int pS, int aS)
        {
            return pS + aS;
        }
        public static int Sandauga(int pS, int aS)
        {
            return pS * aS;
        }
        public static int Skirtumas(int pS, int aS)
        {
            return pS - aS;
        }
        public static double Dalyba(double pS, int aS)
        {
          return pS / aS;
        }











            /*

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

            */

            /*

        public static void Pinigas()
        {
            Console.WriteLine(" iveskite pinigu suma ");
            var suma = Console.ReadLine();
            var kursas = 5.6;
            Debug.WriteLine("Labas");

            // var rezultatas = Convert.ToInt32(suma) * kursas; // korekcija del didelio skaiciaus pvz 88888888
            // var rezultatas = Convert.ToInt64(suma) * kursas; // korekcija reikalinga del strukmeninio skaiciaus pvz 20.4
            // var rezultatas = Convert.ToDouble(suma) * kursas; // reikalinga korekcija del trukmeninio skaiciaus su tasku 20.4

            var decimalSeparator = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
            var groupSeparator = CultureInfo.CurrentUICulture.NumberFormat.NumberGroupSeparator;

            suma = suma.Replace(groupSeparator, decimalSeparator);

            var rezultatas = Convert.ToDouble(suma) * kursas;
            Console.WriteLine("Jus turite rankose {0}", rezultatas);
            Debug.WriteLine("Jus turite rankose {0}", rezultatas);
            Console.ReadKey();

            */







        






    }
}