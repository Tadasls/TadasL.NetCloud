using System.Text;
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

            SkaiciuTrikampis();

            Console.WriteLine("iveskite skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite laipsny");
            var laispnis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("rezultatas " + PakeltiLaipsniu(skaicius, laispnis));


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

        public static string SkaiciuTrikampis()
        {
            Console.WriteLine("iveskite nuo 1 iki 9");
            int skaiciusVartotojo = Convert.ToInt32(Console.ReadLine());

            while (skaiciusVartotojo >= 1 && skaiciusVartotojo <= 9)
            {

                StringBuilder sb1 = new StringBuilder();

                for (int i = 1; i < skaiciusVartotojo; i++)
                {

                    for (int j = 1; j < i + 1; j++)
                    {
                        sb1.Append(i);


                    }

                }
                Console.WriteLine(sb1);
                return sb1.ToString();

            }

            return "nesuveike";

        }


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