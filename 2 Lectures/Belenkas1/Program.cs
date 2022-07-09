using System.Diagnostics;
using System.Globalization;

namespace P014_Debug
{
    public class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, ciklai!");


            for (int i = 0; i <=5 ; i++)
            {
                Console.WriteLine(" reiksme i : {0}", i);
            }
            Console.WriteLine("-----------");
            for (int i = 10-5; i >=0; i--)
            {
                Console.WriteLine(" reiksme i : {0}", i );
            }
            Console.WriteLine("-----------");

            for (int i = 0; i <= 10; i+=3)
            {
                Console.WriteLine(" reiksme i : {0}", i);
            }


            //for (char c = "a"; c >= "z"; c++)
            //{
            //    Console.WriteLine(" reiksme i : {0}", c);

            //}

            int pradinisSKaicius = 30;
            int zmoniuSkaicius = 0;
            //while (zmoniuSkaicius > 10)
            //{
                
            //    Console.WriteLine(pradinisSKaicius);
            //}

            do
            {
               // Console.WriteLine("iveskite sk");
                zmoniuSkaicius  = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(pradinisSKaicius);
            } while (zmoniuSkaicius > 10);




        }








    }
}
