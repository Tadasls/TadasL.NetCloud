
using System.Diagnostics;
using System.Globalization;

namespace P014_Debuginimas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //  Pinigas();
            Console.WriteLine(DecimalHour(Console.ReadLine()));
            

        }
         

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









        }






    }
}