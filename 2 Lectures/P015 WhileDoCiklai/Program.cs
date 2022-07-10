namespace P015_WhileDoCiklai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, While/Do-While Ciklai!");
            // WhileCikloPavyzdys();
            // WhileCikloZaidejoPavyzdys();
            // DoWhilePavyzdys();
            // PirmoSprendimoApskaiciavimas();
            // AntrasUzdavinys();
            // TreciasUzdavinys();
            MathRandomPavyzdys4uzd();
            // SestaUzduotis();



        }

        public static void WhileCikloPavyzdys() // 
        {
            int skaicius = 1;
            while (skaicius <= 10)
            {
                Console.WriteLine(skaicius);
                skaicius++;
            }
        }
        public static void WhileCikloZaidejoPavyzdys()  // tol kol nepatenkina salygos tol kartojamas
        {
            int zaidejuSkaicius = 0;
            while (zaidejuSkaicius < 1 || zaidejuSkaicius > 10)
            {
                Console.WriteLine("Kiek zaideju zais zaidima");
                zaidejuSkaicius = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void DoWhilePavyzdys()
        {
            int zaidejuSkaicius = 9;
            do
            {
                Console.WriteLine("Kiek zaideju zais zaidima");
                zaidejuSkaicius = Convert.ToInt32(Console.ReadLine());

            } while (zaidejuSkaicius < 1 || zaidejuSkaicius > 10);
        }


        /* 1 uzdavinis

        1.Paprašyti vartotojo įvesti bet kokį skaičių.     
        * Išvesti skaičių sumą nuo 1 iki įvesto skaičiaus.       
        */

        public static void PirmoSprendimoApskaiciavimas()
        {
            int i = 0;
            int suma = 0;
          
            Console.WriteLine("iveskite betkoki skaiciu, visu skaiciu sumai nuo 0 iki ivesto skaiciaus gauti");
            i = Convert.ToInt32(Console.ReadLine());

            while (i > 0)
            {
             Console.WriteLine($" skaiciuojama Suma: {suma}");
              suma += i;
                Console.WriteLine($" i: {i}\n");
                i--;
            }
             Console.WriteLine($"--------------");
             Console.WriteLine($" Suma: {suma}");
        }

        /* 2 uzdavinys
          Paprašyti vartotojo įvesti bet kokį skaičių.          
          Išvesti visus lyginius skaičius nuo 0 iki pasirinkto skaičiaus,          
          vienoje eilutėje per kablelį. Pvz.: 0, 2, 4, 6.....         
         */

        public static void AntrasUzdavinys()
        {
            int i = 0;
            int j = 0;
            Console.WriteLine("iveskite betkoki skaiciu, kad gautute visus lyginius skaicius iki ivesto skaiciaus:");
            i = Convert.ToInt32(Console.ReadLine());
            while (j <= i)
            {
               if(j%2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;           
            }
        }

        /*  3 uzdavinys        
           Parasyti programa kuri apskaiciuoja visu ivestu skaiciu suma,          
           kurie buvo ivesti iki ivesto neigiamo skaiciaus         
            PVZ         
            1,23,4,5,7,8,-1        
          */

        public static void TreciasUzdavinys()
        {
            int suma = 0;
            int ivestis = 0;
            do
            {
                suma += ivestis;
                Console.WriteLine("iveskite betkokius skaiciu ir gausite ju suma kai ivesite neigiama skaiciu:");
                ivestis = Convert.ToInt32(Console.ReadLine());

            } while (ivestis > 0);
            Console.WriteLine($"suma : {suma}");
        }

        /* penkta uzduotis
        5. Parasykite programa, kuri paklaustu naudotojo “skaicius ar herbas” ir naudotojas
            galetu zaisti iki kol pasieke arba 10 pergaliu arba 10 pralaimejimu */
        public static void MathRandomPavyzdys4uzd()
        {
            Random random = new Random();
            int moneta = random.Next(1, 3);
            int i = 0;
            int laimejimai = 0;
            int pralaimejimai = 0;
            int target = 10;

            while (laimejimai != target && pralaimejimai != target)
            {
                Console.WriteLine("pasirinkite - 1 - jei skaicius arba - 2 - jei herbas:");
                int ivestis = int.Parse(Console.ReadLine());
                moneta = random.Next(1, 3);
                i++;

                if (moneta == ivestis)
                {
                    laimejimai++;
                    Console.WriteLine($"Atspetas metimas {laimejimai} is 10 ");
                }
                else
                {
                    pralaimejimai++;
                    Console.WriteLine($"Neatspetas metimas {pralaimejimai} is 10");
                }

            } 
              Console.WriteLine($"Atspeti metimai: {laimejimai}, Neatspeti metimai: {pralaimejimai}");


        }

        /*   6 uzduoties salyga     
        6. Parasykite slaptazodzio ivedimo simuliacija. Pirma kompiuteris paprasys, kad nustatytumete slaptazodi 
         tada prasys naudotojo pakartoti slaptazodi. Bet koks neteisingas ivedimas grazina “Slaptazodis neteisingas. 
          Bandykite dar karta”.        
         Kada slaptazodis atspejamas turi buti isvedamas tekstas “Sveikinam! Prisijungete!”.   
         BONUS TASKAI: Padarykite taip, kad po 3 neteisingai ivestu slaptazodzio kartu programa ismestu teksta 
         “Jus uzblokuotas” ir iseitu is ciklo.      
        */
        public static void SestaUzduotis()
        {
            string code, userCode;
            int bandymai = 0;
            int prisijungimoStatusas = 0;
            Console.WriteLine("Iveskite nauja Pin: ");
            userCode = Console.ReadLine();

            do
            {
                Console.WriteLine("Iveskite Pin: ");
                code = Console.ReadLine();
                Console.WriteLine("Bandymas {0} is 3 ", bandymai + 1);
                if (code == userCode)
                {
                    prisijungimoStatusas = 1;
                    bandymai = 3;
                }
                else
                {
                    prisijungimoStatusas = 0;
                    bandymai++;
                }
            }
            while ((code != userCode) && (bandymai != 3));
            if (prisijungimoStatusas == 0)
            {
                Console.WriteLine("Buvo 3 bandymai. Jus uzblokuotas!");
                Environment.Exit(1);
            }
            else if (prisijungimoStatusas == 1)
            {
                Console.WriteLine("Sveikinam! Prisijungete!");
            }



        }
    }
}