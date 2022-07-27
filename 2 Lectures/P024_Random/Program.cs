using System.Text;

namespace P024_Random
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Random!");

            //konstruojamas naujas random

            Random random = new Random();

            int aRandomNumber = random.Next(); // betkoks skaicius nuo 0 iki Int32.MaxValue 
            int aRandomNumber1 = random.Next(4); //bus sugeneruota 0,1,2, arba 3.
            int aRandomNumber2 = random.Next(1, 4); // bus sugeneruota 1,2, arba 3.

            double dRandomNumber = random.NextDouble(); //bus sugeneruota  >= 0.0 iki 1.0


            Console.WriteLine(RandomMetodasDebuginamas()); // neimanoma testuoti (tik debuginimas
            Console.WriteLine(RandomMetodas(random)); // testuojamas


            // atsitiktinis parinkimas is aerray ir list

            Random rnd = new Random();
            Console.WriteLine("------------------------- ");

            Console.WriteLine("atsitiktinims");
            string[] maleNames = { "Tadas", "Tomas", "Titas" };
            List<string> femaleNames = new List<string> { "Toma", "Juste", "Giedre", "Monika", "Robertas" };

            int mIndex = rnd.Next(maleNames.Length);
            Console.WriteLine("Vyriskas vardas yra " + maleNames[mIndex]);

            int fIndex = rnd.Next(femaleNames.Count);
            Console.WriteLine("Moteriskas vardas " + femaleNames[fIndex]);

            //atsitiktine reiksme is dictionary
            Console.WriteLine("dictionary pasirinkimas");

            Dictionary<string, int> miestai = new Dictionary<string, int>()
            {
                {"Vilnius", 2654}, //reiksmes zodyne nera suindeksuotas
                {"Kaunas", 16546},
                {"Klaipeda", 16546},
                {"Siauliai", 215414}

            };

            List<string> miestaiKeys = new List<string>(miestai.Keys);
            int miestasIndex = rnd.Next(miestaiKeys.Count);
            string miestasKey = miestaiKeys[miestasIndex];
            int gyventojuSkaicius = miestai[miestasKey]; // 

            Console.WriteLine($" mieste {miestasKey} atsitiktinis miestas { gyventojuSkaicius} is zodyno " + miestaiKeys[miestasIndex]);

            Console.WriteLine("--------------");
            Console.WriteLine(" atsitiktinio zodzio parinkimas tekste"); 
            string lorem = "asd afd ad ga fdgtr gh tr t f s hth a gha hbjh bjkhb jsdbhjfg jhbs hb jh sd. sdffsdf ";
            string[] loremArr = lorem.Split(' ');
            string  zodis = loremArr[rnd.Next(loremArr.Length)];
            Console.WriteLine(zodis);


            Console.WriteLine("--------------");
            Console.WriteLine("atsitiktiniu raidziu generavimas");
            int raidziuKiekis = 10;
            int A = 65, Z = 90;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < raidziuKiekis; i++)
            {

                sb.Append((char)rnd.Next(A, Z + 1));

                
            }
            Console.WriteLine(sb.ToString());


            Console.WriteLine("--------------");
            Console.WriteLine("atsitiktiniu boolyno  generavimas");
            bool arTrue = rnd.Next(2) == 1;
            Console.WriteLine(arTrue);



            Console.WriteLine("--------------");
            Console.WriteLine("atsitiktiniu skaiciu surasymas i array");

            int skaiciuKiekis = 20;
            int minumumas = 0;
            int maximumas = 10;
            int[] skaiciai = new int[skaiciuKiekis];
            Console.WriteLine(String.Join(", ", skaiciai));
            for (int i = 0; i < skaiciuKiekis; i++)
            {
                skaiciai[i] = rnd.Next(minumumas, maximumas + 1);

            }
            Console.WriteLine(String.Join(", ",skaiciai));


            Console.WriteLine("--------------");
            Console.WriteLine("atsitiktiniu skaiciu surasymas i lista");
            List<int> listas = new List<int>();
            Console.WriteLine("listas  :" + string.Join(", ", listas));
            for (int i = 0; i < skaiciuKiekis; i++)
            {
                listas.Add(rnd.Next(minumumas, maximumas + 1));
            }
            Console.WriteLine("listas :" + string.Join(", ", listas));


            Console.WriteLine("--------------");
            Console.WriteLine("atsitiktiniu rikiavimas");
            List<string> skaiciai1 = new List<string> { "1", "2", "3", "4", "5", "6","7","8" };
            skaiciai1.Sort((a,b)=>rnd.Next(10)-rnd.Next(10));
            Console.WriteLine(String.Join(",", skaiciai1));



            //system.security.cryptography.ramdomNumberGeneratot
            Console.WriteLine("---system.security.cryptography.ramdomNumberGeneratot---------");

            for (int i = 0; i < 20; i++)
            {
                var randNumber = System.Security.Cryptography.RandomNumberGenerator.GetInt32(0, 10);
                Console.Write(" " + randNumber);
            }
            Console.WriteLine();

            Console.WriteLine("------------");
            Console.WriteLine("---GUID---------");
            Guid uid = Guid.NewGuid();

            updateGuid(ref uid);

            Console.WriteLine(uid);

            void updateGuid(ref Guid tmGuid)
            {
                tmGuid = Guid.NewGuid();
            }

           // var guid1 = Guid.Parse("asd sd adsf ad df");
           // Console.WriteLine("guid1:" + guid1);

            bool isGuidParsed = Guid.TryParse("asd sd asdffasf adsf ad df", out var guid2);
            Console.WriteLine("Guid:" + guid2);



            Console.WriteLine("------------");
            Console.WriteLine("---GUID atsitiktinis rikiavimas---------");

            List<string> skaiciai2 = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8" };
             skaiciai2.Sort((a,b) => Guid.NewGuid().CompareTo(Guid.NewGuid()));
            Console.WriteLine(String.Join(", ", skaiciai2));



            Console.WriteLine("-----seed-------");
            //seed 
            Random rnd1 = new Random(10);
            Random rnd2 = new Random(10);
            for(int i = 0; i < 5; i++)
            {
                Console.Write(rnd1.Next(100) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(rnd2.Next(100) + " ");
            }
            Console.WriteLine();
        }









        static string RandomMetodasDebuginamas()
        {
            Random rnd = new Random();
            return rnd.Next(1,10)>5 ? "dideja": "mazeja";
        }

        static string RandomMetodas(Random rnd)
        {
            return rnd.Next(1,10) > 5 ? "dideja" : "mazeja";
        }



    }
}