namespace NamuDarbasSkaiciuotuvas
{
    public class Program
    {

        public static double rezultatas;
        public static double sk1;
        public static double sk2;

       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Skaiciuotuve!");
            PirmasMainMeniu();
        }
       
        public static void SkaiciuIvedimoMetodas()
        {
            Console.WriteLine("Iveskite 1 skaiciu");
            string sk1temp = Console.ReadLine();
            bool success1 = double.TryParse(sk1temp, out sk1);
            if (!success1) Console.WriteLine("neskaicius ");

            Console.WriteLine("Iveskite 2 skaiciu");
            string sk2temp = Console.ReadLine();
            bool success2 = double.TryParse(sk2temp, out sk2);
            if (!success2) Console.WriteLine("neskaicius ");
        }
        public static void PirmasMainMeniu()
        {
            Console.WriteLine(" 1. Nauja operacija \n 2. Testi su rezultatu \n 3. Iseiti. ");
            string mainMeniu = Convert.ToString(Console.ReadLine());
            switch (mainMeniu)
            {
                case "1":
                    // 1. Nauja operacija
                    AntrasSubMeniu();
                    break;

                case "2":
                    //  2. Testi su rezultatu
                    Console.WriteLine($" 1. Sudetis \n 2. Atimtis \n 3. Daugyba \n 4. Dalyba \n 5. Laipsniu \n 6. Saknis");
                    string antrasSubmeniu = Convert.ToString(Console.ReadLine());
                    switch (antrasSubmeniu)
                    {
                        case "1":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = rezultatas;
                            sk2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(SudetiSkaicius());
                            PirmasMainMeniu();
                            break;
                        case "2":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = rezultatas;
                            sk2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(AtimtiSkaicius());
                            PirmasMainMeniu();
                            break;
                        case "3":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = rezultatas;
                            sk2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(DaugintiSkaicius());
                            PirmasMainMeniu();
                            break;
                        case "4":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = rezultatas;
                            sk2 = Convert.ToInt32(Console.ReadLine());
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
                    System.Environment.Exit(-1);
                    break;
            }
        }
        public static void AntrasSubMeniu()
        {
            Console.WriteLine($" 1. Sudetis \n 2. Atimtis \n 3. Daugyba \n 4. Dalyba \n 5. Laipsniu \n 6. Saknis");
            string pirmasSubmeniu = Convert.ToString(Console.ReadLine());
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
                    sk1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(LaipsniuKelimoSkaicius());
                    PirmasMainMeniu();
                    break;
                case "6":
                    Console.WriteLine("Iveskite 1 skaiciu");
                    sk1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(SakniesTraukimoSkaicius());
                    PirmasMainMeniu();
                    break;

                default:
                    break;
            }
        }

        public static double SudetiSkaicius()
        {
            rezultatas = sk1 + sk2;
            return rezultatas;
        }
        public static double AtimtiSkaicius()
        {
            rezultatas = sk1 - sk2;
            return rezultatas;
        }
        public static double DaugintiSkaicius()
        {
            rezultatas = sk1 * sk2;
            return rezultatas;
        }
        public static double DalintiSkaicius()
        {
            if (sk2 == 0)
            {
                Console.WriteLine("negalima dalinti is nulio");
            }
            rezultatas = sk1 / sk2;
            return rezultatas;
        }
        public static double LaipsniuKelimoSkaicius()
        {
            int valSqr = 0;
            for (int i = 0, j = 1; i < sk1; i++, j += 2)
                valSqr += j;

            rezultatas = valSqr;
            return rezultatas;
        }
        public static double SakniesTraukimoSkaicius()
        {
            double root = 1;
            int i = 0;

            while (true)
            {
                i = i + 1;
                root = (sk1 / root + root) / 2;
                if (i == sk1 + 1) { break; }
            }
            rezultatas = root;
            return rezultatas;

        }


        /* 3 skaiciuotuvo uzdavinio salyga
                3. Sukurti skaiciuotuva.Ijungus programa mes turetume gauti pranesima “1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”. Pasirinkus 1 turetu ismesti ”
        1. Sudetis
        2. Atimtis
        3. Daugyba
        4. Dalyba”
        Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius, o gale isvesti rezultata ant ekrano ir uzklausti ar naudotojas nori atlikti nauja operacija ar testis u rezultatu. Sudeties pvz:
        “1
        15
        45
        Rezultatas: 60
        1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
        Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. Pasirinkus 3 programa turetu issijungti.Visa kita turetu veikti tokiu pat budu.
        BONUS1: Iskelkite operacijas i metodus
        BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius.Pvz: dalyba is nulio, neteisingu ivesciu prevencija pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
        BONUS3: Parasyti unit testus uztikrinant operaciju veikima
        BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas
        */


    }
}