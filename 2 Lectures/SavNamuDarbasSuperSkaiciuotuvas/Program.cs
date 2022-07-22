namespace SavNamuDarbasSuperSkaiciuotuvas
{

    public class Program
    {
        public static double? rezultatas = null;
        public static double? sk1;
        public static double? sk2;
        public static List<string> ivestys = new List<string>() ;
        public static int i = 0;
       

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Skaiciuotuve!");
            PirmasMainMeniu();
        }
        static string ReadLineFake() 
        {
            if (ivestys.Count <= 0) { return Console.ReadLine(); }
            if (ivestys.Count > i)  { return ivestys[i++]; }
            return "-1";
        }

        public static void SuperSkaiciuotuvas(string ivedimas)
        {
            ivestys.Add(ivedimas);
        }

        public static void SkaiciuIvedimoMetodas()
        {
            Console.WriteLine("Iveskite 1 skaiciu");
            string sk1temp = ReadLineFake();
            double sk1t;
            bool success1 = double.TryParse(sk1temp, out sk1t);
            sk1 = sk1t;
            if (!success1) Console.WriteLine("neskaicius ");

            Console.WriteLine("Iveskite 2 skaiciu");
            string sk2temp = ReadLineFake();
            double sk2t;
            bool success2 = double.TryParse(sk2temp, out sk2t);
            sk2 = sk2t;
            if (!success2) Console.WriteLine("neskaicius ");
        }
        public static void PirmasMainMeniu()
        {
            Console.WriteLine(" 1. Nauja operacija \n 2. Testi su rezultatu \n 3. Iseiti. ");
            string mainMeniu = Convert.ToString(ReadLineFake());
            switch (mainMeniu)
            {
                case "1":
                    // 1. Nauja operacija
                    AntrasSubMeniu();
                    break;

                case "2":
                    //  2. Testi su rezultatu
                    Console.WriteLine($" 1. Sudetis \n 2. Atimtis \n 3. Daugyba \n 4. Dalyba \n 5. Laipsniu \n 6. Saknis");
                    string antrasSubmeniu = Convert.ToString(ReadLineFake());
                    switch (antrasSubmeniu)
                    {
                        case "1":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = rezultatas;
                            sk2 = Convert.ToInt32(ReadLineFake());
                            Console.WriteLine(SudetiSkaicius());
                            PirmasMainMeniu();
                            break;
                        case "2":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = rezultatas;
                            sk2 = Convert.ToInt32(ReadLineFake());
                            Console.WriteLine(AtimtiSkaicius());
                            PirmasMainMeniu();
                            break;
                        case "3":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = rezultatas;
                            sk2 = Convert.ToInt32(ReadLineFake());
                            Console.WriteLine(DaugintiSkaicius());
                            PirmasMainMeniu();
                            break;
                        case "4":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = rezultatas;
                            sk2 = Convert.ToInt32(ReadLineFake());
                            Console.WriteLine(DalintiSkaicius());
                            PirmasMainMeniu();
                            break;
                        case "5":

                            sk1 = rezultatas;
                            Console.WriteLine(LaipsniuKelimoSkaicius());
                            PirmasMainMeniu();
                            break;
                        case "6":

                            sk1 = rezultatas;
                            Console.WriteLine(SakniesTraukimoSkaicius());
                            PirmasMainMeniu();
                            break;
                    }


                    break;
                case "3":
                    Console.WriteLine("Exit");
                    return;//System.Environment.Exit(-1);
                    break;
            }
        }
        public static void AntrasSubMeniu()
        {
            Console.WriteLine($" 1. Sudetis \n 2. Atimtis \n 3. Daugyba \n 4. Dalyba \n 5. Laipsniu \n 6. Saknis");
            string pirmasSubmeniu = Convert.ToString(ReadLineFake());
            switch (pirmasSubmeniu)
            {
                case "1":
                    SkaiciuIvedimoMetodas();
                    Console.WriteLine(SudetiSkaicius());
                    PirmasMainMeniu();
                    break;
                case "2":
                    SkaiciuIvedimoMetodas();
                    Console.WriteLine(AtimtiSkaicius());
                    PirmasMainMeniu();
                    break;
                case "3":
                    SkaiciuIvedimoMetodas();
                    Console.WriteLine(DaugintiSkaicius());
                    PirmasMainMeniu();
                    break;
                case "4":
                    SkaiciuIvedimoMetodas();
                    Console.WriteLine(DalintiSkaicius());
                    PirmasMainMeniu();
                    break;
                case "5":
                    Console.WriteLine("Iveskite 1 skaiciu");
                    sk1 = Convert.ToInt32(ReadLineFake());
                    Console.WriteLine(LaipsniuKelimoSkaicius());
                    PirmasMainMeniu();
                    break;
                case "6":
                    Console.WriteLine("Iveskite 1 skaiciu");
                    sk1 = Convert.ToInt32(ReadLineFake());
                    Console.WriteLine(SakniesTraukimoSkaicius());
                    PirmasMainMeniu();
                    break;

                default:
                    break;
            }
        }

        public static double? SudetiSkaicius()
        {
            rezultatas = sk1 + sk2;
            return rezultatas;
        }
        public static double? AtimtiSkaicius()
        {
            rezultatas = sk1 - sk2;
            return rezultatas;
        }
        public static double? DaugintiSkaicius()
        {
            rezultatas = sk1 * sk2;
            return rezultatas;
        }
        public static double? DalintiSkaicius()
        {
            if (sk2 == 0)
            {
                Console.WriteLine("negalima dalinti is nulio");
            }
            rezultatas = sk1 / sk2;
            return rezultatas;
        }
        public static double? LaipsniuKelimoSkaicius()
        {
            int valSqr = 0;
            for (int i = 0, j = 1; i < sk1; i++, j += 2)
                valSqr += j;

            rezultatas = valSqr;
            return rezultatas;
        }
        public static double? SakniesTraukimoSkaicius()
        {
            double root = 1;
            int i = 0;
            double sk1saknis = (double) sk1;
            while (true)
            {
                i = i + 1;
                root = (sk1saknis / root + root) / 2;
                if (i == sk1saknis + 1) { break; }
            }
            rezultatas = root;
            return rezultatas;

        }




        public static double Rezultatas()
        {
            PirmasMainMeniu();
            return rezultatas ?? 0;
        }
        public static void Reset()
        {
            rezultatas = null;
        }



    }



    /* ## Super Skaiciuotuvas ## 
Sukurti skaiciuotuva. Ijungus programa turetume gauti pranešimą “
1. Nauja operacija 2 Iseiti. 

Pasirinkus 1 vada į submeniu:
1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba

Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius,
o gale isvesti rezultata į ekraną. Po rezultato parodymo naudotojui parodomas submeniu su klausimu ar naudotojas nori atlikti nauja operacija ar testi su rezultatu. 
1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. 
Pasirinkus 3 programa turetu issijungti. Visa kita turetu veikti tokiu pat budu.

Pvz:
> 1. Nauja operacija 2 Iseiti. 
_1
> 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
_1
> pasirinktas veiksmas + 
> iveskite pirma skaiciu
_15
> iveskite antra skaiciu
_45
> Rezultatas: 60
> 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
_2
> 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
_2
> pasirinktas veiksmas - 
> Iveskite skaiciu
_10
> Rezultatas: 50
> 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
_1
> 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
_2
> pasirinktas veiksmas * 
> iveskite pirma skaiciu
_2
> iveskite antra skaiciu
_3
> Rezultatas: 6
> 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
_3
> Baigta



BONUS1: Iskelkite operacijas i metodus
BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius. 
- dalyba is nulio, neteisingu ivesciu prevencija 
- kada tikimasi gauti skaiciu, bet gaunamas char arba string.
- neteisingas meniu punkto pasirinkimas
BONUS3: Parasyti unit testus uztikrinant operaciju veikima
BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas

*/





}
