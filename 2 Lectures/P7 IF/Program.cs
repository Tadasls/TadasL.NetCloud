namespace P7_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, IF!");


            /*
            int nelyginisSkaicius = 5;
            int lyginisSkaicius = 2;
            bool tiesa = true;

            if (nelyginisSkaicius > lyginisSkaicius)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");
            }

            if (nelyginisSkaicius < lyginisSkaicius)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius}");
            }


            Console.WriteLine(" if else ");
            if (nelyginisSkaicius < lyginisSkaicius)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius}");
            }
            else
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginisSkaicius}");
            }


            Console.WriteLine("if else if else");

            if (nelyginisSkaicius < lyginisSkaicius && tiesa)
            {
                Console.WriteLine($" {nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius} ir tiesa yra true");
            }
            else if (nelyginisSkaicius < lyginisSkaicius && !tiesa )
            {
                Console.WriteLine($" {nelyginisSkaicius} yra mazesnis uz {lyginisSkaicius} ir tiesa yra false");
            }
            else if (nelyginisSkaicius < lyginisSkaicius && tiesa)
            {
                Console.WriteLine($" {nelyginisSkaicius} yra didesnis uz {lyginisSkaicius} ir tiesa yra true");
            }
            else
            {
                Console.WriteLine($" {nelyginisSkaicius} yra didesnis uz {lyginisSkaicius} ir tiesa yra false");
            }



            Console.WriteLine("-------------------");


            var score = 45;
            int pointsNeededToPass = 100;
            bool levelComplete = false;

            if (score >= pointsNeededToPass)
            {
                levelComplete = true;
            }
            else levelComplete = false;
            

            if (levelComplete)
            {
                Console.WriteLine("valio, baigem lygi");
            }


            Console.WriteLine((score >= pointsNeededToPass)? "valio baimgem ": "nevalio");




            Console.WriteLine("----------------------------");
            Console.WriteLine("if kompozicija, nesting");
            int shields = 1, armor = 2;
           // int shields = 1, taip irgi galima  kada tipai skiriasi
           // int armor = 2;

            if (shields <= 0)
            {
                if (armor <= 0)
                {
                    Console.WriteLine("jus mires");
                }
                else
                {
                    Console.WriteLine("jus dar turite armor");
                }
            }
            else
            {
                Console.WriteLine("Jus dar turite galimybiu");
            }

            if (shields <= 0 && armor <= 0)
            {
                Console.WriteLine("jus mires");
            }
            else if (shields <= 0 && armor > 0)
            {
                Console.WriteLine("jus dar turite armor");
            }
            else
            {
                Console.WriteLine("Jus dar turite galimybiu");
            }

            Console.WriteLine("================");
            Console.WriteLine( " null-coalesccing operator (??)");

            bool? nullableBool = true;
            bool normalBool;
            // normalBool = nullableBull;  // taip negalima

            normalBool = nullableBool ?? false;
            // -------
            nullableBool ??= false;
            

                 Console.WriteLine("spuskite enter");
            */
            /*
            //uzduotis 1

            Console.WriteLine($"iveskite skaiciu",Console.ReadLine());
            int ivestisA = Convert.ToInt32(Console.ReadLine());

            if (ivestisA%2 == 0 )

                {
                Console.WriteLine("Skaicius lyginis");
                }


            if (ivestisA < 0)

               {
                Console.WriteLine("skaicius neigiamas");
               } 

            if (ivestisA % 2!= 0 && lyginisSkaicius >0)
            {
                Console.WriteLine("Skaisius" + ivestisA);
            }

            */

            // uzduotis nr 2

            /*
            Console.WriteLine($"iveskite grupes nariu skaiciu");
            int ivestisB = Convert.ToInt32(Console.ReadLine());

            if (ivestisB == 1)
                Console.WriteLine(" tai solo atlikejas");
            else if (ivestisB == 2)
                Console.WriteLine(" tai duetas");
            else if (ivestisB > 2 && ivestisB < 10)
                Console.WriteLine("tai ansamblis");
            else if (ivestisB >= 10)
                Console.WriteLine("tai kamerinis ansamblis");
            else
            {
                Console.WriteLine("klaida");
            }
            */


            // 3 uzduotis 
        

            Console.WriteLine($"iveskite isdirbtas valandas");
            bool arGerasSkaicius = int.TryParse(Console.ReadLine(), out int input);
            int imput;
            if (arGerasSkaicius)
    
            if (input < 160)
            {
                Console.WriteLine($"dar reikia isdirbti  {160 - input} val");
            } 
            else if (input == 160) 
            {
                Console.WriteLine("isdirbtas Etapas");
            }
            else if (input > 160)
            {
                Console.WriteLine($"virsvalandziu  {input - 160 } val");
            }
            else
            {
                Console.WriteLine("klaida");
            }
           










        }
    }
}