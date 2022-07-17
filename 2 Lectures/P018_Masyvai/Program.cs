using System.Text;
namespace P018_Masyvai
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Masyvai!");

            // teorija
            #region    
            /*

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
             Console.WriteLine(intMasyvai1[5]); //uzlinks jei ivesim 8 nes tiek nera


             char[] testinisZodisIsChar = { 't', 'e' };
             string testinisZodis = "testinis";
             for (int i = 0; i < testinisZodis.Length; i++)
             {
                 Console.WriteLine(testinisZodis[i]);
             }
             // viso masyvo irasu atspausdinimas

             for (int i = 0; i < dienos.Length; i++)
             {
                 Console.WriteLine(dienos[i]);
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
                 for (int j = 0; j < dvimatisMasyvas3.GetLength(1); j++)
                 {
                     Console.Write($"{dvimatisMasyvas3[i,j]} ");
                 }
                 Console.WriteLine();
             }

             */
            #endregion


            // 3 uzdavinys
            #region

            /*  
              3. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka.
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


            Console.WriteLine("iveskite skaiciu kiek zmonių atejo i pamoka");
            int dalyvaujaPaskaitoje = Convert.ToInt32(Console.ReadLine());
            string[] studentuVardai = new string[dalyvaujaPaskaitoje];

            for (int i = 0; i < dalyvaujaPaskaitoje; i++)
            {
                Console.WriteLine("iveskite atejusio Studento varda");
                studentuVardai[i] = Console.ReadLine();
            }
            Console.WriteLine("I paskaita atejo:  ");
            for (int i = studentuVardai.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(studentuVardai[i]);
            }

            #endregion


            //4 uzdavinys
            #region

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

            Console.WriteLine("iveskite skaiciu kiek zmonių atejo i pamoka");
            int dalyvaujaPaskaitoje2 = Convert.ToInt32(Console.ReadLine());
            string[] studentuVardai2 = new string[dalyvaujaPaskaitoje2];

            for (int i = 0; i < dalyvaujaPaskaitoje2; i++)
            {
                Console.WriteLine("iveskite atejusio Studento varda");
                studentuVardai2[i] = Console.ReadLine();
            }


            int min = studentuVardai2[0].Length;
            int max = studentuVardai2[0].Length;
            string maxx = studentuVardai2[0];
            string minn = studentuVardai2[0];
            for (int i = 1; i <= studentuVardai2.Length; i++)
            {
                int length = studentuVardai2[i].Length;
                if (length > max)
                {
                    maxx = studentuVardai2[i];
                    max = length;
                }
                if (length < min)
                {
                    minn = studentuVardai2[i];
                    min = length;
                    Console.Write("Longest");
                }
            }
            Console.Write("Shortest:" + maxx);
            Console.Write("Longest" + minn);
            Console.ReadKey(true);

            #endregion


            //5 uzdavinys
            #region
            /*
  5. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame masyve ir juos atvaizduotu ekrane
  PVZ: 1,2,2,4,2,7,6,1
  Pasikartojantys skaiciai: 1, 2
 */

            PasikartojantysSkaiciaiMasyve();


            static void PasikartojantysSkaiciaiMasyve()
             {
                 int[] array = { 1, 2, 2, 4, 2, 7, 6, 1 };

                 for (int i = 0; i < array.Length; i++)
                 {
                     int count = 0;
                     for (int j = 0; j < array.Length; j++)
                     {

                         if (array[i] == array[j])
                             count = count + 1;
                     }
                     if (count > 1) Console.WriteLine("\t\n " + array[i] + " occurs " + count + " times");
                     else Console.Write("");
                 }

             }
            


            #endregion


            // 6 uzdavinys
            #region
            /*
6. Programa praso ivesti eiluciu ir stulpeliu kieki.Ivedus turetu sukurti masyva duoto dydzio, paprasyti ivesti kiekvieno elemento skaiciu/reiksme ir atspausdintu matrica is pateiktu skaiciu
    PVZ: Ivedame 2 2. Suvedame 1, 2, 2, 3
         1 2
         2 3

*/
            Console.WriteLine("Iveskite eiluciu kieki");
            int eilutes = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Iveskite stulpeliu kieki");
            int stulpeliai = Convert.ToInt16(Console.ReadLine());

            int[,] masyvas2x2 = new int[eilutes, stulpeliai];

            
            Console.WriteLine("suveskite duomenis");
            for (int i = 0; i < stulpeliai; i++)
            {
                for (int j = 0; j < eilutes; j++)
                {
                    masyvas2x2[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }


            for (int i = 0; i < masyvas2x2.GetLength(0); i++)
            {
                for (int j = 0; j < masyvas2x2.GetLength(1); j++)
                {
                    Console.Write($"{masyvas2x2[i, j]} ");
                }
                Console.WriteLine();
            }


            #endregion


            //7 uzdavinys
            #region
            /*
7. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame dvimaciame masyve ir juos atvaizduotu ekrane
*/





            #endregion


            //8 uzdavinys
            #region

            /*
8. Parasykite programa, kuri rastu visus pasikartojancius vardus duotame dvimaciame masyve ir juos atvaizduotu ekrane
*/




            #endregion


        }


























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