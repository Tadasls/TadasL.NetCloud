namespace P020_Masyvu_Kartojimas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Masyvu Kartojimas!");


        }

        /*     
       ## Rasti mažiausią ##
             Duotas vienatis sveikų skaičių masyvas.
          Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
               { 5, 3, 7, 6, 8, 7, 10 }
               rezultatas:  3
        */

       public static int MaziausioSkaiciausMasyvePaieska(int[] mas)
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

        /*
                2. ## Rasti didžiausią ##
               Duotas vienatis sveikų skaičių masyvas.
               Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
                { 5, 3, 7, 6, 8, 7, 10 }
                rezultatas:  10
        */

        public static int DidziausioSkaiciausMasyvePaieska(int[] mas)
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

        /*
        1 elementas ir sekanciame ieskome ar nera mazesnio
            ir tada keiciame vietomis
        3. ## RIKIUOTI SKAICIUS DIDĖJIMO TVARKA ##
       Duotas vienmatis sveikų skaičių masyvas. 
       Parašykite programą, kuri į ekraną išves surikiuotusskaičius nuo 
        mažiausio iki didžiausio
       { 5, 1, 7, 6, 8, 7, 10 }

       rezultatas:  1, 5, 6, 7, 7, 8, 10
         */


        public static void RikiavimassMasyve(int[] mas)
        {
           
            mas = new int[] { 5, 1, 7, 6, 8, 7, 10 };
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] > mas[i+1])
                {
                    mas[i] = mas[i+1];
                    mas[i + 1] = mas[i];
                }
            }
            Console.WriteLine(mas);
            //return mas[];
        }



    }
}