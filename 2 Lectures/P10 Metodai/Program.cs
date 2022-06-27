namespace P10_Metodai
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Methods!");
            // metodas neturetu buti metode, o turi buti klaseje

            Console.WriteLine("Sukuriame pirma savo metoda :) ");
            Console.WriteLine("---------------------------");

            TadoMetodas();//metodo iskvietimas, kai metodas nieko negrazina ir nieko nepriima

            Console.WriteLine("---------------------------");
            float kazkoksSkaicius = GautiRandomSkaiciu();//metodo kvietimas ir grazinamos reiksmes priskyrimas
            Console.WriteLine($" kazkoksSkaicius yra lygus = {kazkoksSkaicius}");
             
            Console.WriteLine("---------------------------");
            
            // nieko negrazina bet priema viena parametra
            int a = 2;
            IveskSkaiciuEkranan(a); //metodas su vienu parametru 
            Console.WriteLine($"skaicius a is Main {a}");

            Console.WriteLine("---------------------------");
            
            int sk1 = 2;
            int sk2 = 2;
            int sudaugintiSuSkaiciai = DaugintiSkaicius(sk1,sk2); //metodas su dviem parametru 
            Console.WriteLine($"sudaugintiSuSkaiciai = {sudaugintiSuSkaiciai}");

            Console.WriteLine("---------------------------");
           
            int sudaugintiTrysSkaiciai = DaugintiSkaicius(sk1, sk2, 2); //metodas su trimis parametru 
            Console.WriteLine($"sudaugintiTrysSkaiciai = {sudaugintiTrysSkaiciai}"); //metodo overloadinimas, metodas priima tris argumentus ir grazina int

            Console.WriteLine("---------------------------");

            double sk1d = 2.1;
            double sk2d = 2.1;
            double sudaugintiDuDoubleSkaiciai = DaugintiSkaicius(sk1d, sk2d); //metodas  tikrina ir pagal parametrus ir pagal tipa
            Console.WriteLine($"sudaugintiDuDoubleSkaiciai = {sudaugintiDuDoubleSkaiciai}");


            Console.WriteLine("---------------------------");

            double sudaugintiDuDoubleSkaiciai1 = DaugintiSkaicius((double)sk1, sk2d); //kiti kintamieji panaudoti todel nesutampa rez.
            Console.WriteLine($"sudaugintiDuDoubleSkaiciai1 = {sudaugintiDuDoubleSkaiciai1}");

            Console.WriteLine("---------------------------");

            IsveskTekstaEkranan(); // neivestas parametras nes neprivalomas
            IsveskTekstaEkranan("kazkoks tekstas paduodamas"); 

            Console.WriteLine("---------------------------");


            IsveskSkaiciuIrTekstaEkranan(1);
            IsveskSkaiciuIrTekstaEkranan(1, "kazkoks tekstas");
            Console.WriteLine("---------------------------");

        }







        public static void IsveskTekstaEkranan(string tekstas = "tesktas neivestas") //default parametras priskiriamas
        {
          Console.WriteLine("tekstas yra " + tekstas);
        }
         
        public static void IsveskSkaiciuIrTekstaEkranan(int skaicius = 1, string tekstas = "tekstas neivestas ")
        {
            Console.WriteLine($"skaicius - {skaicius}, tekstas - {tekstas}");
        }


        public static double DaugintiSkaicius(double sk1d, double sk2d)
        {
            return sk1d * sk2d;
        }


        public static int DaugintiSkaicius(int sk1, int sk2, int sk3)
        {
           return sk1 * sk2 * sk3;
        }

        public static int DaugintiSkaicius(int sk1, int sk2)
        {
           return sk1 * sk2;
        }

        public static void IveskSkaiciuEkranan(int a)
        {
            a = a + 8;
            Console.WriteLine($"skaicius yra{a}");
        }

        public static float GautiRandomSkaiciu()
        {

            float a = 4;
            return a + 4.635228f;

            //double a = 53652;
            //return "asdffas"; blogi pvz kad negrazina kito tipo 

        }

        public static void TadoMetodas()
        {
            Console.WriteLine("Tu esi kietas");
        }





    }
}