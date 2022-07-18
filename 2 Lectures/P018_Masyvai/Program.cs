using System.Text;
namespace P018_Masyvai
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Masyvai!");

            //1 BinarinisTrikampis();
            //1b Pyramid(5); // kolegos Tauro versija
            //2 IsgautiAtvirksciaSkaiciu();
            //3 Lankomumas();
            //4 StudentuVardaiIlgiausi();
            //5 PasikartojantysSkaiciaiMasyve();
            //5b int[] skaiciuMasyvas = new int[8] { 1, 2, 2, 4, 2, 7, 6, 1 };
            //5b Ieskotipasikartojimu(skaiciuMasyvas);
            //6 MatricosSukurimasIrDuomenuSuvedimas();
            // PasikartojantysSkaiciaiDvigubameMasyve();
            // PasikartojantysZodziaiDvigubameMasyve();

        }

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


        /* 1. uzdavinys Parasykite programa, kuri atspausdintu sia figura pvz:
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
        public static void Pyramid(int count)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            bool flag = true;
            for (int i = 0; i < count; i++)
            {
                if (flag)
                {
                    sb1.Insert(0, 1);
                    flag = false;
                }
                else
                {
                    sb1.Insert(0, 0);
                    flag = true;
                }

                sb2.Append(sb1).Append(Environment.NewLine);
            }
            Console.WriteLine(sb2.ToString());
        }
        
        /* 2. uzdavinys. Parasykite programa, kuri paprasytu ivesti skaiciu ir ivesta skaiciu atspausdintu atvirkstine seka. Naudoti tik ciklus ir matematines operacijas.
  Visi kintamieji yra integer tipo. Pvz:
              Ivedam- 12345 (int)
              Rezultatas-54321 (int)
        */
        public static void IsgautiAtvirksciaSkaiciu()
        {
            int skaicius = 0,
                likutis,
                rezultatas = 0;

            bool validu = false;

            while (!validu)
            {
                Console.WriteLine("Iveskite skaicius:");
                if (int.TryParse(Console.ReadLine(), out skaicius))
                {
                    validu = true;
                }
            }

            while (skaicius != 0)
            {
                likutis = skaicius % 10;
                Console.WriteLine($"Likutis: {likutis}");
                rezultatas = rezultatas * 10 + likutis; // 123
                Console.WriteLine($"Rezultatas: {rezultatas}");
                skaicius = skaicius / 10;
                Console.WriteLine($"Skaicius: {skaicius}");
            }

            Console.WriteLine($"Rezultatas: {rezultatas}");
        }

        /* 3. Uzdavinys. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka.
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

        static void Lankomumas()
            {
                Console.WriteLine("iveskite skaiciu kiek zmonių atejo i pamoka");
               // int dalyvaujaPaskaitoje = Convert.ToInt32(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out int dalyvaujaPaskaitoje);

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
            }

        /* 4. Uzdavinys. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka.
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
        static void StudentuVardaiIlgiausi()
        {

            int maxLength = 0;
            Console.WriteLine("iveskite skaiciu kiek zmonių atejo i pamoka");
            int.TryParse(Console.ReadLine(), out int dalyvaujaPaskaitoje2);
            string[] studentuVardai2 = new string[dalyvaujaPaskaitoje2];

            for (int i = 0; i < dalyvaujaPaskaitoje2; i++)
            {
                Console.WriteLine("iveskite atejusio Studento varda");
                studentuVardai2[i] = Console.ReadLine();

                if (studentuVardai2[i].Length > maxLength) { maxLength = studentuVardai2[i].Length; }

            }
            Console.WriteLine("-----------");
            for (int i = 0; i < studentuVardai2.Length; i++)
            {
                if (studentuVardai2[i].Length == maxLength) { Console.WriteLine(studentuVardai2[i]); }
            }
        }
   
        /* 5. Uzdavinys. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame masyve ir juos atvaizduotu ekrane
              PVZ: 1,2,2,4,2,7,6,1
              Pasikartojantys skaiciai: 1, 2
         */        
        static void PasikartojantysSkaiciaiMasyve1()
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


        public static string PasikartojantysSkaiciaiMasyve(int[] mas)
        {
            var sb = new StringBuilder();

            var skaiciai = string.Join(";", mas);
            for (int i = 0; i < mas.Length; i++)
            {
                var ind = skaiciai.IndexOf(mas[i].ToString());
                var indLast = skaiciai.LastIndexOf(mas[i].ToString());
                if (ind != indLast)
                {
                    sb.Append(mas[i] + ",");
                }
                skaiciai = skaiciai.Replace(mas[i].ToString(), string.Empty);
            }

            return sb.ToString().TrimEnd(',');
        }

            public static string Ieskotipasikartojimu(int[] skaiciuMasyvas)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < skaiciuMasyvas.Length; i++)
            {
                for (int j = i; j < skaiciuMasyvas.Length; j++)
                {
                    if (skaiciuMasyvas[i] == skaiciuMasyvas[j] && !sb.ToString().Contains(skaiciuMasyvas[j].ToString()) && i != j) { sb.Append(skaiciuMasyvas[j]).Append(','); }
                }
            }
            Console.WriteLine($"pasikartojantys skaiciai masyve: {sb.ToString()}");
            return sb.ToString().Trim(',');

        }

        /* 6. Uzdavinys. Programa praso ivesti eiluciu ir stulpeliu kieki.Ivedus turetu sukurti masyva duoto dydzio, paprasyti ivesti kiekvieno elemento skaiciu/reiksme ir atspausdintu matrica is pateiktu skaiciu
               PVZ: Ivedame 2 2. Suvedame 1, 2, 2, 3
                 1 2
                 2 3
        */
        static void MatricosSukurimasIrDuomenuSuvedimas()
            {
                Console.WriteLine("Iveskite eiluciu kieki");
                int.TryParse(Console.ReadLine(), out int eilutes);
                Console.WriteLine("Iveskite stulpeliu kieki");
                int.TryParse(Console.ReadLine(), out int stulpeliai);
                
                int[,] masyvas2x2 = new int[eilutes, stulpeliai];

                Console.WriteLine("suveskite duomenis");

                for (int i = 0; i < stulpeliai; i++)
                {
                    for (int j = 0; j < eilutes; j++)
                    {
                        masyvas2x2[i, j] = int.Parse(Console.ReadLine());
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
            }

        /* 7. Uzdavinys. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame dvimaciame masyve ir juos atvaizduotu ekrane */
        static void PasikartojantysSkaiciaiDvigubameMasyve()
        {
            int[,] skaiciuDvigumasMasyvas = new int[3, 3] {{ 1, 1, 2},{ 3, 4, 8},{ 5, 4, 7}};
            int arrIndex = 0;
            int[] oneDimesionNumbers = new int[skaiciuDvigumasMasyvas.Length];

            for (int i = 0; i < skaiciuDvigumasMasyvas.GetLength(0); i++)  // getlength ?? 
            {
                for (int j = 0; j < skaiciuDvigumasMasyvas.GetLength(1); j++)
                {
                    oneDimesionNumbers[arrIndex] = skaiciuDvigumasMasyvas[i, j];
                    arrIndex++;
                }
            }

        Ieskotipasikartojimu(oneDimesionNumbers);
        }

        /* 8. Uzdavinys. Parasykite programa, kuri rastu visus pasikartojancius vardus duotame dvimaciame masyve ir juos atvaizduotu ekrane */
        public static string Ieskotipasikartojimu(string[] varduMasyvas)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < varduMasyvas.Length; i++)
            {
                for (int j = i; j < varduMasyvas.Length; j++)
                {
                    if (varduMasyvas[i] == varduMasyvas[j] && !sb.ToString().Contains(varduMasyvas[j].ToString()) && i != j) { sb.Append(varduMasyvas[j]).Append(','); }
                }
            }
            return sb.ToString().Trim(',');
        }
        public static void PasikartojantysZodziaiDvigubameMasyve()
        {
            string[,] varduMasyvas = new string[3, 3] {{ "Mantas", "Mantas", "Matas"},{ "Algirdas", "Titas", "Matas"},{ "Petras", "Tadas", "Povilas"}};
            int masyvoIndeksas = 0;
            string[] viengubasMasyvas = new string[varduMasyvas.Length];

           // StringBuilder sb = new StringBuilder();

            for (int i = 0; i < varduMasyvas.GetLength(0); i++)
            {
                for (int j = 0; j < varduMasyvas.GetLength(1); j++)
                {
                    viengubasMasyvas[masyvoIndeksas] = varduMasyvas[i, j];
                    masyvoIndeksas++;
                }
            }
           Console.Write($"pasikartojantys vardai masyve: {Ieskotipasikartojimu(viengubasMasyvas)}");
            
        }





    }
}