namespace P017_ForUzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, For uzduotys!");
            //ReadIntNumber();
            // IntegerToBinary(233);
            // PakeltiLaipsniu(5, 2);


            Console.WriteLine("iveskite skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite laipsny");
            var laispnis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("rezultatas ");
            Console.WriteLine(PakeltiLaipsniu2(skaicius, laispnis));
          



        }



        public static int PakeltiLaipsniu(int ivestasSkaicius, int ivestasLaispnis)
        {
           
            Console.WriteLine("Iveskite skaiciu");
            ivestasSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite laipsny");
            ivestasLaispnis = Convert.ToInt32(Console.ReadLine());

            while (true)
            {


            int pakeltasLaipsniuSkaicius = ivestasSkaicius^ivestasLaispnis;
                for (int i = 0; i < ivestasLaispnis; i++)
                {
                    ivestasSkaicius *= ivestasSkaicius;
                }

            Console.WriteLine(pakeltasLaipsniuSkaicius);

            if(ivestasSkaicius == 0 && ivestasLaispnis > 0)
            {
                return 1;
            }
            if (ivestasSkaicius == 0 && ivestasLaispnis == 0)
            {
                return 0;
            }
            return pakeltasLaipsniuSkaicius;

            }


        }

        /*
                Sukurti metodą PakeltiLaipsniu , kuris duotą skaičių pakelia nurodytu
             laipsniu ir gautą rezultatą grąžina.Pirmas parametras skaičius, kurį
             kelsime, antras laipsnis, kuriuo pakelti.
             NB! kai laipsnis 0 o skaičius > 0 gąžinama 1
             NB! kai skaičius 0 ir laipsnis = 0 gąžinama 0
             NB! kai laipsnis = 1 gąžinamas tas pats skaičius
                */
        public static int PakeltiLaipsniu2 (int skaicius, int laipsnis)
        {
           
            
            if (laipsnis == 0 && skaicius > 0)
            {
                return 1;
            }
            if (skaicius == 0 && laipsnis == 0)
            {
                return 0;
            }
            if (laipsnis == 1 )
            {
                return skaicius;
            }


            var rezultatas = skaicius;
            for (int i = 1; i < laipsnis; i++)
            {
                rezultatas = rezultatas * skaicius;
            }

            return rezultatas;
            

        }


        public static string IntegerToBinary(int skaiciusI)
        {
            string binarySk = string.Empty;
            while (skaiciusI > 0)
            {
                binarySk = skaiciusI % 2 + binarySk;
                skaiciusI /= 2;
                // skaiciusI = skaiciusI / 2;
            }
            return binarySk;
            Console.WriteLine(binarySk);
        }

        public static void ReadIntNumber()
        {
            Console.WriteLine("iveskite Sveika skaiciu");
            bool arIvestasSkaiciusTeisingas = false;
            string input = "";

            while (!arIvestasSkaiciusTeisingas) 
            {
                input = Console.ReadLine();
                arIvestasSkaiciusTeisingas = Int32.TryParse(input, out _);
                
               if (!arIvestasSkaiciusTeisingas) 
                {
                    Console.WriteLine("neteisingai ivestas skaicius");
                }
            }
            Console.WriteLine($"Ivestas skaicius {input}");
        }





    }
}