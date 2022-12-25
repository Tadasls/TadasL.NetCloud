using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Schema;
using System;
using System.Globalization;

namespace testavimaiTLS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Advent Time!");
            // PirmasSuskaiciavimoMetodas();
            // AntrasSuskaiciavimoMetodas();
            // AntrasSuskaiciavimoMetodas2Dalis();
            // TreciaDienaASuskaiciavimoMetodas();
            // KetvirtaDienaASuskaiciavimoMetodas();

            // NemanoSprendimas3();

            // PenktadienaSprendimas();
            // SestaDienaSprendimas();

            // SestAntraDalis();
            //Console.WriteLine(Penkt()); //15

            Laikas();
        }
        public static void PirmasSuskaiciavimoMetodas()
        {
            string filename = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\input.txt";

            List<int> skaiciuSarasasMasyvas = new List<int>();

            int elfai = 0;
            string[] duomenuMasyvas = System.IO.File.ReadAllLines(filename);
            foreach (string example in duomenuMasyvas)
            {
                if (example == "")
                {
                    ++elfai;
                }
            }
            Console.WriteLine($" Viso elfu yra {elfai}");

            int[] skaiciuMasyvas = new int[Convert.ToInt32(elfai) + 1];

            int skaitliukas = 0;

            foreach (string example in duomenuMasyvas)
            {
                if (example != "")
                {
                    int suma = Convert.ToInt32(example);
                    skaiciuMasyvas[skaitliukas] += suma;
                }
                else if (example == "")
                {
                    ++skaitliukas;
                }

            }

            Console.WriteLine($" max -  {skaiciuMasyvas.Max()}");
            // 1 - 72511

            Array.Sort(skaiciuMasyvas);
            Array.Reverse(skaiciuMasyvas);

            int totalSuma = Convert.ToInt32(skaiciuMasyvas[0]) + Convert.ToInt32(skaiciuMasyvas[1]) + Convert.ToInt32(skaiciuMasyvas[2]);
            Console.WriteLine($"Top 3 suma {skaiciuMasyvas[0]} + {skaiciuMasyvas[1]} + {skaiciuMasyvas[2]}");
            Console.WriteLine(totalSuma);

            //2 - 212117

        }

        public static void AntrasSuskaiciavimoMetodas()
        {
            string filename = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\input2.txt";
            string[] duomenuMasyvas = System.IO.File.ReadAllLines(filename);

            //x pralaimeti 
            //Y lygiosios
            //z laimejimas




            var AYeiluciuSkaicius = 0;
            var AXeiluciuSkaicius = 0;
            var AZeiluciuSkaicius = 0;
            var eiluciuSkaicius = 0;

            foreach (string example in duomenuMasyvas)
            {
                eiluciuSkaicius++;
                if (example == "A Y") // laimejimas 2+6=8
                {
                    ++AYeiluciuSkaicius; //*8
                }
                if (example == "A X") // lygiosios 1+3 =4
                {
                    ++AXeiluciuSkaicius; //*2
                }
                if (example == "A Z") // pralaimejimas 3+0=3
                {
                    ++AZeiluciuSkaicius; //*3
                }
            }

            var BYeiluciuSkaicius = 0;
            var BXeiluciuSkaicius = 0;
            var BZeiluciuSkaicius = 0;

            foreach (string example in duomenuMasyvas)
            {
                eiluciuSkaicius++;
                if (example == "B Y") //  2+3=5  paper / paper lygu
                {
                    ++BYeiluciuSkaicius; //*4
                }
                if (example == "B X") //  1+0=1  paper / Rock pralaimi
                {
                    ++BXeiluciuSkaicius; //*1
                }
                if (example == "B Z") //  3+6=9  paper /zirkles laimi
                {
                    ++BZeiluciuSkaicius; //*9
                }

            }

            var CYeiluciuSkaicius = 0;
            var CXeiluciuSkaicius = 0;
            var CZeiluciuSkaicius = 0;

            foreach (string example in duomenuMasyvas)
            {
                eiluciuSkaicius++;
                if (example == "C Y") //  2+0=2  zirk / paper pralaimi
                {
                    ++CYeiluciuSkaicius; //*2
                }
                if (example == "C X") //  1+6=7  zirk / Rock laimi
                {
                    ++CXeiluciuSkaicius; //*7
                }
                if (example == "C Z") //  3+3=6  zirk /zirkles lygu
                {
                    ++CZeiluciuSkaicius; //*6
                }

            }




            Console.WriteLine(eiluciuSkaicius);

            Console.WriteLine(AYeiluciuSkaicius * 8);
            Console.WriteLine(AXeiluciuSkaicius * 4);
            Console.WriteLine(AZeiluciuSkaicius * 3);

            Console.WriteLine(BYeiluciuSkaicius * 5);
            Console.WriteLine(BXeiluciuSkaicius * 1);
            Console.WriteLine(BZeiluciuSkaicius * 9);

            Console.WriteLine(CYeiluciuSkaicius * 2);
            Console.WriteLine(CXeiluciuSkaicius * 7);
            Console.WriteLine(CZeiluciuSkaicius * 6);

            var total =
            AYeiluciuSkaicius * 8 +
            AXeiluciuSkaicius * 4 +
            AZeiluciuSkaicius * 3 +
            BYeiluciuSkaicius * 5 +
            BXeiluciuSkaicius * 1 +
            BZeiluciuSkaicius * 9 +
            CYeiluciuSkaicius * 2 +
            CXeiluciuSkaicius * 7 +
            CZeiluciuSkaicius * 6;

            Console.WriteLine($"viso bus - {total}");
            //13221


            string A = "Rock";  //1 akmuo
            string B = "Paper"; // 2 popierius
            string C = "Scissors"; // 3 zirkles

            string X = "Rock"; //1 akmuo
            string Y = "Paper"; //2 popierius
            string Z = "Scissors"; // 3 zirkles




        }

        public static void AntrasSuskaiciavimoMetodas2Dalis()
        {
            string filename = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\input2.txt";
            string[] duomenuMasyvas = System.IO.File.ReadAllLines(filename);

            string A = "Rock";  //1 akmuo
            string B = "Paper"; // 2 popierius
            string C = "Scissors"; // 3 zirkles

            string X = "Rock"; //1 akmuo
            string Y = "Paper"; //2 popierius
            string Z = "Scissors"; // 3 zirkles

            //x pralaimeti 
            //Y lygiosios
            //z laimejimas

            var AYeiluciuSkaicius = 0;
            var AXeiluciuSkaicius = 0;
            var AZeiluciuSkaicius = 0;


            var eiluciuSkaicius = 0;

            foreach (string example in duomenuMasyvas)
            {
                eiluciuSkaicius++;
                if (example == "A Y") // lygiosios  X 1+3 =4
                {
                    ++AYeiluciuSkaicius; //*4
                }
                if (example == "A X") // praleimeti Z 
                {
                    ++AXeiluciuSkaicius; //*3
                }
                if (example == "A Z") // laimeti Y 2+6 =8
                {
                    ++AZeiluciuSkaicius; //*8
                }
            }

            var BYeiluciuSkaicius = 0;
            var BXeiluciuSkaicius = 0;
            var BZeiluciuSkaicius = 0;

            foreach (string example in duomenuMasyvas)
            {
                eiluciuSkaicius++;
                if (example == "B Y") // lygiosios y 2 +3 =5
                {
                    ++BYeiluciuSkaicius; // *5
                }
                if (example == "B X") //  pralaimeti X 1+0 =1
                {
                    ++BXeiluciuSkaicius; // *1
                }
                if (example == "B Z") //  laimeti Z 3+6 =9
                {
                    ++BZeiluciuSkaicius; // *9
                }

            }

            var CYeiluciuSkaicius = 0;
            var CXeiluciuSkaicius = 0;
            var CZeiluciuSkaicius = 0;

            foreach (string example in duomenuMasyvas)
            {
                eiluciuSkaicius++;
                if (example == "C Y") // lygiosios Z 3+3 = 6
                {
                    ++CYeiluciuSkaicius; // * 6
                }
                if (example == "C X") // pralaimeti Y 2+0=2
                {
                    ++CXeiluciuSkaicius; // *2
                }
                if (example == "C Z") //  laimeti X 1+6 =7
                {
                    ++CZeiluciuSkaicius; // *7
                }

            }



            var total =
            AYeiluciuSkaicius * 4 +
            AXeiluciuSkaicius * 3 +
            AZeiluciuSkaicius * 8 +
            BYeiluciuSkaicius * 5 +
            BXeiluciuSkaicius * 1 +
            BZeiluciuSkaicius * 9 +
            CYeiluciuSkaicius * 6 +
            CXeiluciuSkaicius * 2 +
            CZeiluciuSkaicius * 7;

            Console.WriteLine($"viso bus - {total}");

            //13131



        }

        public static void TreciaDienaASuskaiciavimoMetodas()
        {
            string filename = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\input3.txt";
            string[] duomenuMasyvas = System.IO.File.ReadAllLines(filename);

            var eiluciuSkaicius = 0;
            List<string> sarasasRaidziu = new List<string> { };

            foreach (string example in duomenuMasyvas)
            {
                eiluciuSkaicius++;


                string pirmaPuse = example.Substring(0, (example.Length) / 2);
                string antraPuse = example.Substring((example.Length) / 2);

                var intersect = pirmaPuse.Intersect(antraPuse).FirstOrDefault();

                // Console.WriteLine($"{eiluciuSkaicius} - {pirmaPuse} - {antraPuse} = {intersect} ");


                sarasasRaidziu.Add(intersect.ToString());

            }
            Console.WriteLine();

            foreach (var item in sarasasRaidziu)
            {
                Console.Write(item);
            }

            // Console.WriteLine(sarasasRaidziu.Count());

            Console.WriteLine();
        }

        public static void NemanoSprendimas3()
        {
            Dictionary<char, int> ValueLookup = new Dictionary<char, int>();

            var c = 'a';
            int val = 1;
            while (c <= 'z')
                ValueLookup.Add(c++, val++);
            c = 'A';
            while (c <= 'Z')
                ValueLookup.Add(c++, val++);


            string filename = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\input3.txt";


            Part1();
            Part2();

            void Part1()
            {
                var krepsiai = System.IO.File.ReadAllLines(filename);
                int daiktuKiekis, puse, sum = 0;
                char[] a, b;
                char intersect;
                foreach (var kuprine in krepsiai)
                {
                    daiktuKiekis = kuprine.Length;
                    puse = daiktuKiekis / 2;
                    a = kuprine.Substring(0, puse).ToCharArray();
                    b = kuprine.Substring(puse).ToCharArray();
                    intersect = a.Intersect(b).Single();
                    sum += ValueLookup[intersect];
                }
                Console.WriteLine($"Prioitry Sum: {sum}");
            }

            //8153

            void Part2()
            {

                var sacks = System.IO.File.ReadAllLines(filename);
                const int GroupSize = 3;
                char[] a, b, c;
                char intersect;
                int sum = 0;
                for (int i = 0; i < sacks.Length; i += GroupSize)
                {
                    a = sacks[i].ToCharArray();
                    b = sacks[i + 1].ToCharArray();
                    c = sacks[i + 2].ToCharArray();
                    intersect = a.Intersect(b).Intersect(c).Single();
                    sum += ValueLookup[intersect];
                }
                Console.WriteLine($"Group Prioitry Sum: {sum}");
            }

            //2342

        }

        public static void KetvirtaDienaASuskaiciavimoMetodas()
        {
            string filename = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\input4.txt";
            string[] duomenuMasyvas = System.IO.File.ReadAllLines(filename);


            var range = new Regex("(\\d+)-(\\d+)");

            var data = (from line in File.ReadAllLines(filename)
                        where !string.IsNullOrWhiteSpace(line)
                        select line.Split(",")
                        .Select(r => range.Match(r))
                        .Select(m => (low: long.Parse(m.Groups[1].Value),
                                       high: long.Parse(m.Groups[2].Value)))
                        .ToArray())
                        .ToArray();

            var result = 0L;
            foreach (var pair in data)
            {
                if (pair[0].low <= pair[1].low && pair[0].high >= pair[1].high)
                {
                    result++;
                }
                else if (pair[1].low <= pair[0].low && pair[1].high >= pair[0].high)
                {
                    result++;
                }
            }

            Console.WriteLine("ats");
            Console.WriteLine(result);
            //471

            var result2 = 0L;
            foreach (var pair in data)
            {
                if (pair[0].low >= pair[1].low && pair[0].low <= pair[1].high)
                {
                    result2++;
                }
                else if (pair[0].high >= pair[1].low && pair[0].high <= pair[1].high)
                {
                    result2++;
                }
                else if (pair[1].low >= pair[0].low && pair[1].low <= pair[0].high)
                {
                    result2++;
                }
                else if (pair[1].high >= pair[0].low && pair[1].high <= pair[0].high)
                {
                    result2++;
                }
            }
            Console.WriteLine("ats2");
            Console.WriteLine(result2);

            //888

        }

        public static void PenktadienaSprendimas()
        {

            string filename = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\input5.txt";
            var duomenuMasyvas = System.IO.File.ReadLines(filename);

            //(string header, list<string> linijos = duomenuMasyvas.Split("\n\n").ToArray().As(x=>x, x=>x);

            //foreach (var line in duomenuMasyvas)
            //{

            //}

        }


        public static void SestaDienaSprendimas()
        {

            string filename = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\input6.txt";
            var duomenuMasyvas = System.IO.File.ReadLines(filename);


            char[] charArray = { };

            foreach (var line in duomenuMasyvas)
            {
                charArray = line.ToCharArray();
            }


            for (int i = 0; i <= charArray.Count() - 5; i++)
            {
                bool arSutampa1 = charArray[i].Equals(charArray[i + 1]);
                bool arSutampa2 = charArray[i].Equals(charArray[i + 2]);
                bool arSutampa3 = charArray[i].Equals(charArray[i + 3]);
                bool arSutampaA2 = charArray[i + 1].Equals(charArray[i + 2]);
                bool arSutampaA3 = charArray[i + 1].Equals(charArray[i + 3]);
                bool arSutampaB3 = charArray[i + 2].Equals(charArray[i + 3]);

                if (arSutampa1 || arSutampa2 || arSutampa3 || arSutampaA2 || arSutampaA3 || arSutampaB3)
                {

                    //Console.Write(charArray[i]);
                    //Console.Write(charArray[i + 1]);
                    //Console.Write(charArray[i + 2]);
                    //Console.Write(charArray[i + 3]);



                    //Console.WriteLine(" - Pasikartojimas");
                } else
                {
                    Console.Write($" - Ats ???{i + 4}??? - ");
                    Console.Write(charArray[i]);
                    Console.Write(charArray[i + 1]);
                    Console.Write(charArray[i + 2]);
                    Console.Write(charArray[i + 3]);
                    Console.WriteLine();

                }

                //1876

            }


        }


        public static void SestAntraDalis()
        {
            string filename = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\input6.txt";

            var data = (from eilute in File.ReadLines(filename)
                        where !string.IsNullOrEmpty(eilute)
                        select eilute).ToArray();



            var line = data[0];

            for (var idx = 0; idx < line.Length - 3; ++idx)
            {
                if (line.Substring(idx).Take(14).Distinct().Count() == 14)
                {
                    Console.WriteLine(idx + 14);
                }




            }


            //2202


        }

        public static string Penkt()
        {
            string filename = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\input15.txt";
            var input = File.ReadAllLines(filename).ToList();
            List<int[]> data = new List<int[]>();

        Regex rx = new Regex(@"Sensor at x=(-?\d+), y=(-?\d+): closest beacon is at x=(-?\d+), y=(-?\d+)", RegexOptions.Compiled);
           
            foreach (var s in input)
            {
                int[] pars = new int[4];
                Match m = rx.Match(s);
                for (int i = 1; i <= 4; i++) pars[i - 1] = int.Parse(m.Groups[i].Value);
                data.Add(pars);
            }


            //List<int> ranges = new List<int>();
            //HashSet<int> bcount = new HashSet<int>();
            //int target = 2000000;
            //foreach (var pars in data)
            //{
            //    var db = Math.Abs(pars[0] - pars[2]) + Math.Abs(pars[1] - pars[3]);
            //    var dy = Math.Abs(pars[1] - target);
            //    if (dy <= db)
            //    {
            //        ranges.Add(2 * (pars[0] - (db - dy)));
            //        ranges.Add(2 * (pars[0] + (db - dy)) + 1);
            //    }
            //    if (pars[3] == target) bcount.Add(pars[3]);
            //}
            //ranges.Sort();
            //int count = 0, start = 0, tot = 0;
            //foreach (var r in ranges)
            //{
            //    if (r % 2 == 0 && ++count == 1) start = r / 2;
            //    if (r % 2 == 1 && --count == 0) tot += r / 2 - start + 1;
            //}
            //tot -= bcount.Count;
            //Console.WriteLine("ats pirmas");
            //Console.WriteLine(tot.ToString());

            
                long range = 4000000;
                for (long target = 0; target < range; target++)
                {
                    List<long> ranges = new List<long>();
                    foreach (var pars in data)
                    {
                        long db = Math.Abs(pars[0] - pars[2]) + Math.Abs(pars[1] - pars[3]);
                        long dy = Math.Abs(pars[1] - target);
                        long a = pars[0] - (db - dy), b = pars[0] + (db - dy);
                        if (dy <= db && a <= range && b >= 0)
                        {
                            if (a < 0) a = 0;
                            if (b > range) b = range;
                            ranges.Add(2 * a);
                            ranges.Add(2 * b + 1);
                        }
                    }
                    ranges.Sort();
                    long count = 0, start = 0, tot = 0;
                    foreach (long r in ranges)
                    {
                        if (r % 2 == 0 && ++count == 1) start = r / 2;
                        if (r % 2 == 1 && --count == 0) tot += r / 2 - start + 1;
                        if (count == 0 && tot < range) return (tot * 4000000 + target).ToString();
                    }
                }
                return "";
           


        }


        public static void Laikas()
        {



            //Calendar calendar = CultureInfo.CurrentCulture.Calendar;
            //  int weekOfYear = calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            //  Console.WriteLine("Week of the year: " + weekOfYear);

        


        }
    } 
}




 































