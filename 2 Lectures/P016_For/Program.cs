namespace P016_For
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, For Loop!");

            // ForLoop();
            // ForLoopBack();
            // BreakForLoop();
            // SkipForLoop();
            // ForLoopNesting();



        //    var skaicius = 9999999;
        //    Console.WriteLine(skaicius);
        //    RefNaudojimas(ref skaicius);
        //    Console.WriteLine(skaicius);

        //    var skaicius1 = 888888888;
        //    Console.WriteLine(skaicius);
        //    BeRefNaudojimas(skaicius1);
        //    Console.WriteLine(skaicius1);


        }

        //public static void RefNaudojimas(ref int a)
        //{
        //    a = 10;
        //}

        //public static void BeRefNaudojimas( int a)
        //{
        //    a = 10;
        //}





        public static void ForLoop()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void ForLoopBack()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void BreakForLoop()
        {
            int skaicius = 5;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i==skaicius)
                {
                    break;
                }
            }
        }
        public static void SkipForLoop()
        {
            int iteracijaKuriaNorimePraleisti = 5;
            int pradziosTaskas = 0;
            int pabaigosTaskas = 10;

            for (int i = pradziosTaskas; i < pabaigosTaskas; i++)
            {
                if (i == iteracijaKuriaNorimePraleisti)
                {
                    Console.WriteLine("  skip");
                    continue;
                }
                Console.WriteLine("  " + i);

            }
        }
        public static void ForLoopNesting()
        {
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        public static bool DnrGrandinesValidacija_Replace(string dnr)
        {
            var s = dnr.Replace("-", "")
                .Replace("A", "")
                .Replace("T", "")
                .Replace("C", "")
                .Replace("G", "");
            return s.Length == 0;
        }
        public static bool DnrGrandinesValidacija_For(string dnr)
        {
            for (int i = 0; i < dnr.Length; i++)
            {
                if (dnr[i] != '-' &&
                    dnr[i] != 'A' &&
                    dnr[i] != 'T' &&
                    dnr[i] != 'C' &&
                    dnr[i] != 'G')
                {
                    return false;
                }
            }
            return true;
        }







    }
}