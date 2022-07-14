using System.Text;
namespace P018_Masyvai
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Masyvai!");

            //bool reiksme = false;
            //Console.WriteLine($"{Convert.ToInt32(reiksme)}");
            //var isWrong = false; //flag

            //while(true)
            //{
            //    reiksme = !reiksme; //false true false true
            //}

            // BinarinisTrikampis();
            // AtbulineSeka();
            
            //trumpas budas kaip patikrinti validuoti ivedama skaiciu

            //int skaicius = SkaiciausTikrinimas(Console.ReadLine());
            //static int SkaiciausTikrinimas(string? tekstas) => int.TryParse(tekstas, out int skaicius) ? skaicius : 0;



            // string[] dienos = new string[7] { "Pirmadienis", "Antradienis", "Treciadienis", "Ketvirtadienis", "Penktadienis", "Sestadienis", "Sekmadienis" };
            
             //                         0            1                2               3                4            5               6 
            string[] dienos = { "Pirmadienis", "Antradienis", "Treciadienis", "Ketvirtadienis", "Penktadienis", "Sestadienis", "Sekmadienis" };
            
            
            
            string vardas = "Vardenis";
            Console.WriteLine(vardas.Length); //ilgi parasys
            Console.WriteLine(dienos[0]);
            Console.WriteLine(dienos[1]);
            Console.WriteLine(dienos[2]);
            Console.WriteLine(dienos[3]);
            Console.WriteLine(dienos[4]);
            Console.WriteLine(dienos[5]);
            Console.WriteLine(dienos[6]);
              //  Console.WriteLine(dienos[7]); uzlinksta nes tokio nera adreso...


            Console.WriteLine(dienos.Length);


            


            int[] pazymiai = new int[10];
            var pazymiai2 = new int[10];

            // skaiciai
            int skaicius1 = 100;
            int skaicius2 = 95;
            int skaicius3 = 92;

            //deklaravimas
            int[] skaiciai = { 100, 95, 92 };
            //tuscio masyvo deklaravimas
            //int[] skaiciai2;
            int[] skaiciai2 = null;

            if (skaicius1 == skaicius2)
            {
                skaiciai2 = new int[7];

            }
            //vietos iskyrimas
            int[] skaiciai3 = new int[10];
            string[] zodziai = new string[3];


            //reiksmiu irasymas
            skaiciai3[0] = 100;
            skaiciai3[1] = 95;
            skaiciai3[2] = 92;



            
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int i = 0; i < length; i++)
            //    {
            //       // dvimatisMasyvas[j, i];  // kiekvieno stulpelio kiekviena eilute
            //       // dvimatisMasyvas[i,j]; //kiekvienos eilutes, iekvienas stulpelis
            //    }
            //}


            // skaiciai3[99] = 999; // gauname klaida 


            int[] intMasyvai1 = new int[] { 100, 95, 92, 87, 55, 50, 40 };
            int[] intMasyvai2 = new [] { 100, 95, 92, 87, 55, 50, 40 };
            int[] intMasyvai3 = new int[1] { 100 };                      // tik vienas elementas
            int[] intMasyvai4 = { 100, 95, 92, 87, 55, 50, 40 };

            //masyvo reiksmes gauti pagal indeksa
            Console.WriteLine(intMasyvai1[8]);


            char[] testinisZodisIsChar = { 't', 'e' };
            string testinisZodis = "testinis";
            for (int i = 0; i < testinisZodis.Length; i++)
            {
                Console.WriteLine(testinisZodis[i]);
            }

            // viso masyvo irasu atspausdinimas
            for (int i = 0; i < testinisZodis.Length; i++)
            {
                Console.WriteLine(dienos[i]);
               // Console.WriteLine(dienos[2]); // treciadieni tik spausdins
            }



            //matricos/Dvimacio masyvo deklaravimas
            int[,] dvimatisMasyvas = new int[4, 5];
            int[][] dvimatisMasyvas2 = new int[4][];

            // dvimacio masyvo iraso deklaravimas

            int[,] dvimatisMasyvas3 = new int[,] { 
                  { 1, 2 }
                , { 3, 4 }
                , { 4, 5 } };


            for (int i = 0; i < dvimatisMasyvas3.GetLength(0); i++)
            {
                for (int i = 0; i < dvimatisMasyvas3.GetLength(1); i++)
                {
                    Console.Write($"{dvimatisMasyvas3[i,j]} ");
                }
                Console.WriteLine();
            }



        }



        /*
        8. Parasykite programa, kuri rastu visus pasikartojancius vardus duotame dvimaciame masyve ir juos atvaizduotu ekrane
        */

        /*
        7. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame dvimaciame masyve ir juos atvaizduotu ekrane
        */

        /*
        6. Programa praso ivesti eiluciu ir stulpeliu kieki.Ivedus turetu sukurti masyva duoto dydzio, paprasyti ivesti kiekvieno elemento skaiciu/reiksme ir atspausdintu matrica is pateiktu skaiciu
            PVZ: Ivedame 2 2. Suvedame 1, 2, 2, 3
                 1 2
                 2 3

        */


        /*
          5. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame masyve ir juos atvaizduotu ekrane
          PVZ: 1,2,2,4,2,7,6,1
          Pasikartojantys skaiciai: 1, 2
         */




        /*

        4. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka.
            Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. 
            Kada visi vardai buna ivesti programa turetu atspausdinti ilgiausia varda ekrane.
            Jei vardai yra vienodo ilgio turetu atspausdinti abu vardus.
            Pvz: 
            3            
            Edvinas 
            Jonas            
            Petras
            ---------------------            
            Edvinas

        */



        /*  3. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka.
        Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. 
        Kada visi vardai buna ivesti programa turetu atspausdinti visu vardus atvirkstine seka.
        Pvz: 
        3
        Edvinas
        Jonas
        Petras
        Petras
        Jonas
        Edvinas
        */





        /* 2. Parasykite programa, kuri paprasytu ivesti skaiciu ir ivesta skaiciu atspausdintu atvirkstine seka. Naudoti tik ciklus ir matematines operacijas.
  Visi kintamieji yra integer tipo. Pvz:
              Ivedam- 12345 (int)
              Rezultatas-54321 (int)
        */
        private static void AtbulineSeka() 
        {
            int skaicius = 0,
             likutis,
            rezultatas = 0;

            bool validu = false;
            
            while (!validu)
            {
                Console.WriteLine("iveskite skaicius:");
            if(int.TryParse(Console.ReadLine(), out skaicius))
                {
                    validu = true;
                }

            }
            while(skaicius != 0)
            {

                likutis = skaicius % 10;
                Console.WriteLine($" Likutis {likutis}");
                rezultatas = rezultatas % 10 + likutis; // 123 
                Console.WriteLine($"Rezultatas {rezultatas}");
                skaicius = skaicius / 10;
                Console.WriteLine($"skaicius {skaicius} ");

            }
            Console.WriteLine($"Rezultatas {rezultatas}");


        }

        /* 1.Parasykite programa, kuri atspausdintu sia figura pvz:
           1
           01
           101
           0101
           10101
            */

        public static void BinarinisTrikampis()
        {

         Console.Write("Kiek norite eiluciu: ");
         int eilutes = int.Parse(Console.ReadLine());
         StringBuilder sb = new StringBuilder();

         for (int i = 1; i <= eilutes; i++)
         Console.WriteLine(sb.Insert(0, i % 2).ToString());

        }





    }
}