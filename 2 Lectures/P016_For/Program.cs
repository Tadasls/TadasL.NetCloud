using System.Text;

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


        //----------------------------

        public static int KiekKartuPasikartoja_For_Interpoliation(string dnr, string element)
        {
            var count = 0;
            for (int i = 0; i < dnr.Length; i += 4)
            {
                if ($"{dnr[i]}{dnr[i + 1]}{dnr[i + 2]}" == element)
                {
                    count++;
                }
            }
            return count;
        }
        public static int KiekKartuPasikartoja_For_Composition(string dnr, string element)
        {
            var count = 0;
            for (int i = 0; i < dnr.Length; i += 4)
            {
                var s = string.Format("{0}{1}{2}", dnr[i], dnr[i + 1], dnr[i + 2]);
                if (s == element)
                {
                    count++;
                }
            }
            return count;
        }
        public static int KiekKartuPasikartoja_For_Concat(string dnr, string element)
        {
            var count = 0;
            for (int i = 0; i < dnr.Length; i += 4)
            {
                string s = "";
                for (int j = 0; j < 3; j++)
                {
                    s += dnr[i + j].ToString();
                }
                if (s == element)
                {
                    count++;
                }
            }
            return count;
        }
        public static int KiekKartuPasikartoja_For_StringBuilder(string dnr, string element)
        {
            var c = 0;
            for (int i = 0; i < dnr.Length; i += 4)
            {
                var sb = new StringBuilder();
                for (int j = 0; j < 3; j++)
                {
                    sb.Append(dnr[i + j]);
                }
                if (sb.ToString() == element)
                    c++;
            }
            return c;
        }
        public static int KiekKartuPasikartoja_For_StringConstructor(string dnr, string element)
        {
            var count = 0;
            for (int i = 0; i < dnr.Length; i += 4)
            {
                if (new string(new char[] { dnr[i], dnr[i + 1], dnr[i + 2] }) == element)
                {
                    count++;
                }
            }
            return count;
        }

        public static int KiekKartuPasikartoja_For_Substring(string dnr, string element)
        {
            var count = 0;
            for (int i = 0; i < dnr.Length; i += 4)
            {
                if (dnr.Substring(i, 3) == element)
                {
                    count++;
                }
            }
            return count;
        }
        public static int KiekKartuPasikartoja_Replace(string dnr, string element)
        {
            return (dnr.Length - dnr.Replace(element, "").Length) / 3;
        }

        public static int KiekKartuPasikartoja_Split(string dnr, string element)
        {
            return dnr.Split(element).Length - 1;
        }

    }
}