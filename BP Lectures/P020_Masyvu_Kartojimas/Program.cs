namespace P020_Masyvu_Kartojimas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Masyvu Kartojimas!");

            // int[] fake = new int[] { 5, 1, 7, 6, 8, 7, 10 };
            //  RikiuotiSkaiciusDidejimoTvarka(fake);

            // char[] massive = new char[] { 'c', 's', 'a' };
            // TrijuRaidziuRikiavimas(); //massive
           
            
            // char[] mas = new char[] { 'c', 's', 'a' };
             // RikiuotiTrisRaides(char[] mas);

        }

        /*    ## Rasti mažiausią ##
             Duotas vienatis sveikų skaičių masyvas.
          Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
               { 5, 3, 7, 6, 8, 7, 10 }
               rezultatas:  3
        */

        public static int RastiMaziausia(int[] mas)
        {
            int maziausias = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (maziausias > mas[i])
                {
                    maziausias = mas[i];
                }
            }
            return maziausias;
        }

        /* 2. ## Rasti didžiausią ##
               Duotas vienatis sveikų skaičių masyvas.
               Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
                { 5, 3, 7, 6, 8, 7, 10 }
                rezultatas:  10
        */

        public static int RastiDidziausia(int[] mas)
        {
            int didziausias = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (didziausias < mas[i])
                {
                    didziausias = mas[i];
                }
            }
            return didziausias;
        }

          /* 3. ## RIKIUOTI SKAICIUS DIDĖJIMO TVARKA ##
            Duotas vienmatis sveikų skaičių masyvas. 
            Parašykite programą, kuri į ekraną išves surikiuotusskaičius nuo 
            mažiausio iki didžiausio
            { 5, 1, 7, 6, 8, 7, 10 }
            rezultatas:  1, 5, 6, 7, 7, 8, 10 
            */

        public static int[] RikiuotiSkaiciusDidejimoTvarka(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        int temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                    
                }
               
            }
            Console.WriteLine(string.Join(", ", mas));
            return mas;
        }


        public static int[] SurikiuotasMasyvas;
        public static int[] Rikiuoti(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        int temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", mas));

            SurikiuotasMasyvas = mas;
            return mas;
        }


        /* 4 ## RIKIUOTI TRIS RAIDES ##
            Parašykite programą kurioje vienas metodas.
            - Naudotojo paprašome įvesti 3 raides (atskirai).
            Būtina validacija kad įvesta tik vienas simbolis.
            - Metodas priima masyvą iš char ir grąžina masyvą iš char - surikiuotas raides pagal abecelę.
            Pvz:
            > Iveskite pirma raide:
            _ C
            > Iveskite antra raide:
            _ D
            > Iveskite trecia raide:
            _ B
            >  B, C, D 

             */

        public static char[] TrijuRaidziuRikiavimas()  //char[] massive
        {
            char[] massive = new char[3];
            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine("Iveskite Raide");
                massive[i] = Console.ReadKey().KeyChar;
                if (massive[i].ToString().Length > 1) { Console.WriteLine("Error"); }
            }

                       
            int count = massive.Length;
            bool apkeista;
            do
            
            {
                apkeista = false;
                for (int i = 0; i < count -1; i++)
                {
                    if (massive[i] > massive[i + 1])
                    {
                        char c = massive[i];
                        massive[i] = massive[i + 1];
                        massive[i + 1] = c;
                        apkeista = true;
                    }
                    count--;
                }
            } while (apkeista);

            Console.WriteLine(" ");
            Console.WriteLine(string.Join(", ", massive));

            return massive;
        }


        public static char[] RikiuotiTrisRaides(char[] mas)
        {

            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        char temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }


            Console.WriteLine(string.Join(", ", mas));
            return mas;
        }




        /* 5 ## RIKIUOTI KETURIAS RAIDES ##
        Parašykite programą kurioje vienas metodas.
        - Naudotojo paprašome įvesti 4 raides (atskirai).
          Būtina validacija kad įvesta tik vienas simbolis.
        - Metodas priima masyvą iš string (su prielaidai kad kiekvienas string yra tik 1 raide)
          ir grąžina string (NB! ne masyvą) - surikiuotas raides pagal abecelę atskirtas -.
        Pvz:
        > Iveskite pirma raide:
        _ C
        > Iveskite antra raide:
        _ A
        > Iveskite trecia raide:
        _ B
        > Iveskite ketvirtą raide:
        _ E
        > A-B-C-E
        */

        public static string RikiuotiKeturiasraides(string[] raides)
        {

            char[] charMas = new char[raides.Length];

            for (int i = 0; i < raides.Length; i++)
            {
                string raide = raides[i];
                charMas[i] = raides[i][0];
            }

          RikiuotiTrisRaides(charMas);

            // charMas =  RikiuotiTrisRaides(charMas);    nebuytina nurodyti charMas del ref typo, duomenis priskiriami ir keliauja toliau.


            return string.Join("-", charMas);
          
        }




        //issiaiskinti kaip tai veikia
        /// <summary>
        /// Uzduotis 3 (Kartojimas)
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int[] Sort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }
        public static char[] Sort(char[] character)
        {
            for (int i = 0; i < character.Length - 1; i++)
            {
                for (int j = 0; j < character.Length - i - 1; j++)
                {
                    if (character[j] > character[j + 1])
                    {
                        char temp = character[j];
                        character[j] = character[j + 1];
                        character[j + 1] = temp;
                    }
                }
            }
            return character;
        }
        public static char[] CharArrayInput()
        {
            char[] chars = new char[3];

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine("Iveskite {0} raide:", i + 1);
                chars[i] = CharInput();
            }
            return Sort(chars);
        }
        public static string[] CharArrayInputStr()
        {
            string[] chars = new string[4];

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine("Iveskite {0} raide:", i + 1);
                chars[i] = CharInput().ToString();
            }
            return chars;
        }
        public static char CharInput()
        {
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine(Environment.NewLine);
            while (!Char.IsUpper(letter))
            {
                Console.WriteLine("Raide nera didzioji{0}", Environment.NewLine);
                letter = Console.ReadKey().KeyChar;
            }
            return letter;
        }
        public static string SortLetters(string[] chars)
        {
            char[] characters = new char[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                characters[i] = chars[i][0];
            }

            return String.Join('-', Sort(characters));


        }


        }
}