using System.Diagnostics;
using System.Globalization;

namespace P014_Debug
{
    public class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Debug!");
            Main2(null);
        }


        public static void Main2(string[] args)
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
            VeksmoNormalizacija(ref veiksmas);
            if (ArSvekiejiSkaiciai(a, b) && !ArNaujasVeiksmas(veiksmas))
            {
                return Skaiciuotuvas(Convert.ToInt32(a), Convert.ToInt32(b), veiksmas);
            }
            else if (ArSkaiciai(a, b))
            {
                return Skaiciuotuvas(Convert.ToDouble(a), Convert.ToDouble(b), veiksmas);
            }

            return null;
        }

        public static void VeksmoNormalizacija(ref string veiksmas)
        {
            veiksmas = veiksmas.Replace("1", "+");
            veiksmas = veiksmas.Replace("2", "-");
            veiksmas = veiksmas.Replace("3", "*");
            veiksmas = veiksmas.Replace("4", "/");
            veiksmas = veiksmas.Replace("5", "^2");
            veiksmas = veiksmas.Replace("6", "^3");
        }


            public static bool ArSvekiejiSkaiciai(string a, string b) => int.TryParse(a, out _) && int.TryParse(b, out _);
            public static bool ArSkaiciai(string a, string b) => double.TryParse(a, out _) && double.TryParse(b, out _);
            public static bool ArNaujasVeiksmas(string veiksmas) => veiksmas == "^2" || veiksmas == "^3";

            public static double Suma(double a, double b) => a + b;
            public static double Atimtis(double a, double b) => a - b;
            public static double Daugyba(double a, double b) => a * b;
            public static double Dalyba(double a, double b) => a / b;
            public static double Kvadratu(double a) => a * a;
            public static double Kubu(double a) => a * a * a;

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







    }
}
