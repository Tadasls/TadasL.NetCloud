using System.Text;
namespace P017_ForUzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, For uzduotys!");

            // ReadIntNumber();
            // IntegerToBinary(233);
            // PakeltiLaipsniu(5, 2);
            // SkaiciuTrikampis();
            // SkaiciuPiramide();
            // SkaiciuEile();

            // PenktaUzduotis();
            // PirmasUzdavinysSkaiciuEile();
            // DaugybosLentele();
            // KetvirtaUzduotis();
             Skaiciuotuvas();



            //Console.WriteLine("iveskite skaiciu");
            //var skaicius = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("iveskite laipsny");
            //var laispnis = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("rezultatas " + PakeltiLaipsniu(skaicius, laispnis));


        }


        /*  3. Sukurti skaiciuotuva.
                
           BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius.
        Pvz: dalyba is nulio, neteisingu ivesciu prevencija pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
           BONUS3: Parasyti unit testus uztikrinant operaciju veikima
           
            */

        public static void Skaiciuotuvas()
        {
            double sk1 = 0;
            double sk2 = 0;
            PirmasMainMeniu(sk1, sk2);
        }


        public static void PirmasMainMeniu(double sk1, double sk2)
            {
            Console.WriteLine(" 1. Nauja operacija \n 2. Testi su rezultatu \n 3. Iseiti. ");
            string mainMeniu = Convert.ToString(Console.ReadLine());
            switch (mainMeniu)
            {
                case "1":
                    // 1. Nauja operacija
                    AntrasSubMeniu(sk1, sk2);
                    break;

                case "2":
                    //  2. Testi su rezultatu
                    Console.WriteLine($" 1. Sudetis \n 2. Atimtis \n 3. Daugyba \n 4. Dalyba \n 5. Laipsniu \n 6. Saknis");
                    string antrasSubmeniu = Convert.ToString(Console.ReadLine());
                    switch (antrasSubmeniu)
                    {
                        case "1":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = SudetiSkaicius(sk1, sk2);
                            sk2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(SudetiSkaicius(sk1, sk2));
                            Skaiciuotuvas();
                            break;
                        case "2":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = AtimtiSkaicius(sk1, sk2);
                            sk2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(AtimtiSkaicius(sk1, sk2));
                            Skaiciuotuvas();
                            break;
                        case "3":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = DaugintiSkaicius(sk1, sk2);
                            sk2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(DaugintiSkaicius(sk1, sk2));
                            Skaiciuotuvas();
                            break;
                        case "4":
                            Console.WriteLine("Iveskite 2 skaiciu");
                            sk1 = DalintiSkaicius(sk1, sk2);
                            sk2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(DalintiSkaicius(sk1, sk2));
                            Skaiciuotuvas();
                            break;
                        case "5":
                            
                            sk1 = LaipsniuKelimoSkaicius(sk1);
                            
                            Console.WriteLine(LaipsniuKelimoSkaicius(sk1));
                            Skaiciuotuvas();
                            break;
                        case "6":
                            
                            sk1 = SakniesTraukimoSkaicius(sk1);
                            ;
                            Console.WriteLine(SakniesTraukimoSkaicius(sk1));
                            Skaiciuotuvas();
                            break;
                    }


                    break;
                case "3":
                    Console.WriteLine("Exit");
                    System.Environment.Exit(-1);
                    break;
            }
            }

        public static void AntrasSubMeniu(double sk1, double sk2)
            {

                Console.WriteLine($" 1. Sudetis \n 2. Atimtis \n 3. Daugyba \n 4. Dalyba \n 5. Laipsniu \n 6. Saknis");
                string pirmasSubmeniu = Convert.ToString(Console.ReadLine());
                switch (pirmasSubmeniu)
                {
                    case "1":
                        Console.WriteLine("Iveskite 1 ir 2 skaiciu");
                        sk1 = Convert.ToInt32(Console.ReadLine());
                        sk2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(SudetiSkaicius(sk1, sk2));
                        Skaiciuotuvas();
                        break;
                    case "2":
                        Console.WriteLine("Iveskite 1 ir 2 skaiciu");
                        sk1 = Convert.ToInt32(Console.ReadLine());
                        sk2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(AtimtiSkaicius(sk1, sk2));
                        Skaiciuotuvas();
                        break;
                    case "3":
                        Console.WriteLine("Iveskite 1 ir 2 skaiciu");
                        sk1 = Convert.ToInt32(Console.ReadLine());
                        sk2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(DaugintiSkaicius(sk1, sk2));
                        Skaiciuotuvas();
                        break;
                    case "4":
                        Console.WriteLine("Iveskite 1 ir 2 skaiciu");
                        sk1 = Convert.ToInt32(Console.ReadLine());
                        sk2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(DalintiSkaicius(sk1, sk2));
                        Skaiciuotuvas();
                        break;
                    case "5":
                        Console.WriteLine("Iveskite 1 skaiciu");
                        sk1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(LaipsniuKelimoSkaicius(sk1));
                        Skaiciuotuvas();
                        break;
                    case "6":
                        Console.WriteLine("Iveskite 1 skaiciu");
                        sk1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(SakniesTraukimoSkaicius(sk1));
                        Skaiciuotuvas();
                        break;

                    default:
                        break;
                }
            }


       

        public static double SudetiSkaicius(double sk1, double sk2)
        {
            double suma = sk1 + sk2;
            return sk1 + sk2;
        }
        public static double AtimtiSkaicius(double sk1, double sk2)
        {
            return sk1 - sk2;
        }
        public static double DaugintiSkaicius(double sk1, double sk2)
        {
            return sk1 * sk2;
        }
        public static double DalintiSkaicius(double sk1, double sk2)
        {
            return (double)sk1 / sk2;
        }
        public static double LaipsniuKelimoSkaicius(double sk1)
        {
                int valSqr = 0;
                for (int i = 0, j = 1; i < sk1; i++, j += 2)
                    valSqr += j;
                return valSqr;
        }
        public static double SakniesTraukimoSkaicius(double sk1)
        {    
            double root = 1;
            int i = 0;
          
            while (true)
            {
                i = i + 1;
                root = (sk1 / root + root) / 2;
                if (i == sk1 + 1) { break; }
            }
            Console.WriteLine("Square root:{0}", root);
            return root;

        }


        /*  NAUJAS 1
          ----------------------------
          Parašykite metodą SkaiciuEile kuri išvestu vienoje eilutėje skaičių grupes tokiu principu: -> 1 -> 11 -> 111 -> 1111 -> 11111 -> ....... 
          programa turi paprašyti nurodyti skaičių ir grupių kiekį
          naudokite for ir StringBuilder
        */

        public static void PirmasUzdavinysSkaiciuEile()
        {
            int input1 = 10;
            int input2 = 10;
            var sb7 = new StringBuilder();

            for (int i = 0; i < input2; i++)
            {
                Console.Write("->");
                sb7.Append(input1);
                Console.Write(sb7);

            }
        }

        /*        2. Sukurkite programa, kuri paprasytu naudotojo ivesti skaiciu.Ivedus skaiciu turetu atspausdinti to skaiciaus daugybos lentele.Pvz
        15 X 1 = 15                                                                                                   
        15 X 2 = 30                                                                                                   
        15 X 3 = 45                                                                                                   
        15 X 4 = 60                                                                                                   
        15 X 5 = 75                                                                                                   
        15 X 6 = 90                                                                                                   
        15 X 7 = 105                                                                                                  
        15 X 8 = 120                                                                                                  
        15 X 9 = 135                                                                                                  
        15 X 10 = 150
        */

        public static void DaugybosLentele()
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                // sb.Append(skaicius).Append(" X ").Append(i).Append(" = ").Append(skaicius * i);
                
                sb.Append($"{skaicius} X {i} = {skaicius * i}").AppendLine();

                Console.WriteLine(sb);
                sb.Clear();
            }
        }
        



        /* DidejanciuSkaiciuPiramide
    Sukurti metodą DidejanciuSkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 
    (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )). 
    Metodas turi grąžinti atitinkamą lygiašonį trikampį (ivestas skaičius 4).
    1
    22
    333
    4444
    333
    22
    1
    */

        //  DidejanciuSkaiciuPiramide 5555 uzdavinio sprendimas kolegos


        public static int SkaiciausTikrinimas(string? txt) => int.TryParse(txt, out int num) == false ? 0 : num;
        public static void PenktaUzduotis()
        {
            int skaicius = 0;
            while (skaicius < 1 || skaicius > 9)
            {
                Console.Write("Iveskite skaiciu: ");
                skaicius = SkaiciausTikrinimas(Console.ReadLine());
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= skaicius; i++)
            {
                sb.Append(skaicius);
                Console.WriteLine(sb.ToString());
            }
            for (int i = skaicius; i >= 1; i--)
            {
                sb.Remove(0, 1);
                Console.WriteLine(sb.ToString());
            }
        }


        /* 77 salyga
         Sukurti metodą SkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
       jeigu įveda netinkamą skaičių
       prašo įvesti vėl, kol įves tinkamą Programa turi atspausdinti atitinkamą lygiašonį trikampį.
        7
        77
        777
        7777
        77777
        777777
        7777777
        777777
        77777
        7777
        777
        77
        7
         */

        public static string SkaiciuPiramide()
        {
            Console.WriteLine("iveskite nuo 1 iki 9");


            int vartSkaicius = Convert.ToInt32(Console.ReadLine());
            bool arSkaiciusGeras = false;
           
                while (vartSkaicius >= 1 && vartSkaicius <= 9)
            {
                StringBuilder sb3 = new StringBuilder();

                for (int i = 1; i < vartSkaicius; i++)
                {
                    for (int j = 1; j < i + 1; j++)
                    {
                        sb3.Append(vartSkaicius);
                    }
                    sb3.AppendLine();
                }

                for (int i = vartSkaicius; i >= 0; i--)
                {
                    for (int j = 1; j < i-1; j++)
                    {
                        sb3.Append(vartSkaicius);
                    }
                    sb3.AppendLine();
                }

                Console.WriteLine(sb3);
                 return sb3.ToString();

            }
            Console.WriteLine("reikia gero skaiciaus");
            return " netinkamas skaicius";
        }

        /* 55 salyga
     Sukurti metodą SkaiciuTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
  (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą).
  Metodas turi grąžinti atitinkamą statųjį trikampį su tiek eilučių koks skaičius įvestas.
  5
  55
  555
  5555
  55555
   */



        private static void KetvirtaUzduotis()
        {
            int skaicius = 0;
            while (skaicius < 1 || skaicius > 9)
            {
                Console.Write("Iveskite skaiciu: ");
                skaicius = SkaiciausTikrinimasNuo1Iki9(Console.ReadLine());
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= skaicius; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sb.Append(Convert.ToString(skaicius));
                }
                sb.AppendLine("");
            }
            Console.WriteLine(sb.ToString());

        }
        private static int SkaiciausTikrinimasNuo1Iki9(string? txt)
        {
            if (int.TryParse(txt, out int num) == false)
                return 0;
            else
                return num;
        }


        //BANDYMAS PER PASKAITA REFACTORINTI
        //
        //public static void SKaiciuuTrikmapis()
        //{
        //    var input1 = string.Empty;

        //    var skaicius = 0;
        //    var arValidu = ArValidu(out input1, out skaicius);

        //}
        //public static string SudeliotiSakini(int skaicius)
        //{
        //    var builder = new StringBuilder();
        //    for (int i =0; i< skaicius; i++)
        //    {

        //    }
        //    return builder;
        //}

        //public static bool ArValidu(out string input1, out int skaicius)
        //{
        //    while (true)
        //    {
        //        input1 = Console.ReadLine();
        //        var arTeiginga = int.TryParse(input1, out skaicius);


        //        if (skaicius <= 9 && skaicius >= 1)
        //        {
        //          break;
        //        }

        //    }
        //    return builder;
        //}


        //public static string SkaiciuTrikampis()
        //{
        //    Console.WriteLine("iveskite nuo 1 iki 9");
        //    bool arSkaiciusTeisingas = false;
        //    int skaiciusVartotojo = Convert.ToInt32(Console.ReadLine());

        //    while (!arSkaiciusTeisingas)
        //    {
        //        skaiciusVartotojo = Console.ReadLine();
        //        arSkaiciusTeisingas = int.TryParse(skaiciusVartotojo, out skaicius6);
        //        if (!arSkaiciusTeisingas) Console.WriteLine("Ivestas neteisingas skaicius, bandykite dar");
        //    }


        //    StringBuilder sb1 = new StringBuilder();

        //    for (int i = 1; i < skaiciusVartotojo; i++)
        //    {

        //        for (int j = 1; j < i + 1; j++)
        //        {
        //            sb1.Append(skaiciusVartotojo);
        //        }
        //        sb1.AppendLine();


        //        Console.WriteLine(sb1);

        //    }

        //    return sb1.ToString();
        //}

        /* laipsniu kelimo metodas salyga
                Sukurti metodą PakeltiLaipsniu , kuris duotą skaičių pakelia nurodytu
             laipsniu ir gautą rezultatą grąžina.Pirmas parametras skaičius, kurį
             kelsime, antras laipsnis, kuriuo pakelti.
             NB! kai laipsnis 0 o skaičius > 0 gąžinama 1
             NB! kai skaičius 0 ir laipsnis = 0 gąžinama 0
             NB! kai laipsnis = 1 gąžinamas tas pats skaičius
                */
        public static int PakeltiLaipsniu(int skaicius, int laipsnis)
        {

            if (laipsnis == 0 && skaicius > 0)
            {
                return 1;
            }
            if (skaicius == 0 && laipsnis == 0)
            {
                return 0;
            }
            if (laipsnis == 1)
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

        /*  IntegerToBinary 
Sukurti metodą IntegerToBinary, 
kuris gautą teigiamą sveikąjį skaičių paverstų į dvejetainį formatą.Reikšmę grąžintų kaip simbolių eilutę.
2 --> 10
7 --> 111
45 --> 101101 
*/

        public static string IntegerToBinary(int integerNumber)
        {
            string binaryNumber = string.Empty;
            while (integerNumber > 0)
            {
                binaryNumber = integerNumber % 2 + binaryNumber;
                integerNumber = integerNumber / 2;
            }
            return binaryNumber;
        }

        /* UŽDUOTIS 1.
Sukurti metodą ReadIntNumber, 
kuris paprašo vartotojo įvesti sveikąjį skaičių ir tą skaičių grąžina.
Jeigu vartotojas įveda blogą skaičių, tai programa turi informuoti, kad
įvestas blogas skaičius ir prašyti įvesti vėl. Kol vartotojas
neįveda tinkamo skaičiaus metodas turi vis prašyti įvesti.
(Hint) -> Panaudoti int.TryParse metodą ir while ciklą.
*/

        public static int ReadIntNumber()
        {
            Console.WriteLine("Įveskite sveikąjį skaičių");

            string skaiciusStr = string.Empty;
            bool arSkaiciusTeisingas = false;
            int skaicius = 0;

            while (!arSkaiciusTeisingas)
            {
                skaiciusStr = Console.ReadLine();
                arSkaiciusTeisingas = int.TryParse(skaiciusStr, out skaicius);
                if (!arSkaiciusTeisingas) Console.WriteLine("Ivestas neteisingas skaicius, bandykite dar");
            }
            Console.WriteLine($"Ivestas skaicius {skaiciusStr}");
            return skaicius;


        }
    }
}