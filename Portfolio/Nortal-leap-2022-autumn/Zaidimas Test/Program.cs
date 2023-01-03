
using TechTalk.SpecFlow.CommonModels;
using static System.Net.Mime.MediaTypeNames;

namespace Zaidimas_Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game zaidimas2 = new Game();
             Console.WriteLine($"trumpiausias kelias yra {zaidimas2.Sprendimas1()} žingsnių ");
            // Sprendimas2();
        }
        public static void Sprendimas2()
        {
            string pradinisLabirintas = Nuskaitymas();

            // Parse our labirintas and display it.
            var masyvas = SukurtiLabirintoMasyva(pradinisLabirintas);
            AtvaizduotiLabirinta(masyvas);
            int zingsniuSkaicius = 0;

            // Read user input and evaluate labirintas.
            while (true)
            {
                Thread.Sleep(100);
                //string line = Console.ReadLine();
                int result = KelioPaisymas(masyvas);
                if (result == 1)
                {
                    Console.WriteLine($"Atlikta per: {zingsniuSkaicius} žingsnių");
                    break;
                }
                else if (result == -1)
                {
                    Console.WriteLine($"Nepavyko: {zingsniuSkaicius} žigsnių");
                    break;
                }
                else
                {
                    Console.Clear();
                    AtvaizduotiLabirinta(masyvas);
                }
                zingsniuSkaicius++;
            }

            var alternatyvuMasyvas = SukurtiLabirintoMasyva(pradinisLabirintas);
            // Get start position.
            for (int i = 0; i < alternatyvuMasyvas.Length; i++)
            {
                var eilute = alternatyvuMasyvas[i];
                for (int j = 0; j < eilute.Length; j++)
                {
                    // Start square is here.
                    if (eilute[j] == 1)
                    {
                        int maziausiaReiksme = int.MaxValue;
                        int pradinisZingsnis = 0;
                        Judejimas(alternatyvuMasyvas, i, j, pradinisZingsnis, ref maziausiaReiksme);
                        Console.WriteLine($"Surasta per: {maziausiaReiksme} zingsniu");
                    }
                }
            }
        }
        public static string Nuskaitymas()
        {
            string txtPath = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\TestData\\map5.txt";
            string[] linijos = File.ReadAllLines(@txtPath);
            string result = string.Join(".", linijos);
            return result;
        }
        public static int[][] SukurtiLabirintoMasyva(string labirintas)
        {
            
            string[] linijos = labirintas.Split(new char[] { '.', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);
            // Create jagged masyvas.
            int[][] masyvas = new int[linijos.Length][];
            for (int i = 0; i < linijos.Length; i++)
            {
                string line = linijos[i];
                // Create eilute.
                var eilute = new int[line.Length];
                for (int x = 0; x < line.Length; x++)
                {
                    // Set ints from chars.
                    switch (line[x])
                    {
                        case '1':
                            eilute[x] = -1;
                            break;
                        case 'X':
                            eilute[x] = -3;
                            break;
                        case '8':
                            eilute[x] = 1;
                            break;
                        default:
                            eilute[x] = 0;
                            break;

                    }
                }
                // Store eilute in jagged masyvas.
                masyvas[i] = eilute;
            }
            return masyvas;
        }
        public static void AtvaizduotiLabirinta(int[][] masyvas)
        {
            // Loop over int data and display as characters.
            for (int i = 0; i < masyvas.Length; i++)
            {
                var eilute = masyvas[i];
                for (int x = 0; x < eilute.Length; x++)
                {
                    switch (eilute[x])
                    {
                        case -1:
                            Console.Write('1');
                            break;
                        case 1:
                            Console.Write('8');
                            break;
                        case -3:
                            Console.Write('X');
                            break;
                        case 0:
                            Console.Write(' ');
                            break;
                        default:
                            Console.Write('@');
                            break;

                    }
                }
                // End line.
                Console.WriteLine();
            }
        }
        public static bool ArGalimaPozicija(int[][] masyvas, int eilute, int tikrinamoLaukelioEilutesIndexas, int tikrinamoLaukelioStulpelioIndexas)
        {
            // ... Ensure position is within the masyvas bounds.
            if (tikrinamoLaukelioEilutesIndexas < 0) return false;
            if (tikrinamoLaukelioStulpelioIndexas < 0) return false;
            if (tikrinamoLaukelioEilutesIndexas >= masyvas.Length) return false;
            if (tikrinamoLaukelioStulpelioIndexas >= masyvas[eilute].Length) return false;
            return true;
        }
        static int[][] galimiJudesiai = {
        new int[] { -1, 0 },
        new int[] { 0, -1 },
        new int[] { 0, 1 },
        new int[] { 1, 0 } };
        public static int KelioPaisymas(int[][] masyvas)
        {
            // Loop over eilutes and then columns.
            for (int eilutesIndexas = 0; eilutesIndexas < masyvas.Length; eilutesIndexas++)
            {
                var eilute = masyvas[eilutesIndexas];
                for (int stulpelioIndexas = 0; stulpelioIndexas < eilute.Length; stulpelioIndexas++)
                {
                    // Find a square we have traveled to.
                    int laukoReiksme = masyvas[eilutesIndexas][stulpelioIndexas];
                    if (laukoReiksme >= 1)
                    {
                        // Try all possible moves from this square.
                        foreach (var judesioKoordinatesVeiksmas in galimiJudesiai)
                        {
                            // Move to a valid square.
                            int tikrinamoLaukelioEilutesIndexas = eilutesIndexas + judesioKoordinatesVeiksmas[0];
                            int tikrinamoLaukelioStulpelioIndexas = stulpelioIndexas + judesioKoordinatesVeiksmas[1];

                            if (ArGalimaPozicija(masyvas, eilutesIndexas, tikrinamoLaukelioEilutesIndexas, tikrinamoLaukelioStulpelioIndexas))
                            {
                                int testineReiksme = masyvas[tikrinamoLaukelioEilutesIndexas][tikrinamoLaukelioStulpelioIndexas];
                                if (testineReiksme == 0)
                                {
                                    // Travel to a new square for the first time.
                                    // ... Record the zingsniuSkaicius of total moves to it.
                                    masyvas[tikrinamoLaukelioEilutesIndexas][tikrinamoLaukelioStulpelioIndexas] = laukoReiksme + 1;
                                    // Move has been performed.
                                    return 0;
                                }
                                else if (testineReiksme == -3)
                                {
                                    // We are at our endpoint.
                                    return 1;
                                }
                            }
                        }
                    }
                }
            }
            // We cannot do anything.
            return -1;
        }
        static int Judejimas(int[][] laikinasMasyvas, int eilutesIndexas, int stulpelioIndexas, int zingsniuSkaicius, ref int maziausiaReiksme)
        {
            // Copy map so we can modify it and then abandon it.
            int[][] masyvas = new int[laikinasMasyvas.Length][];
            for (int i = 0; i < laikinasMasyvas.Length; i++)
            {
                var eilute = laikinasMasyvas[i];
                masyvas[i] = new int[eilute.Length];
                for (int x = 0; x < eilute.Length; x++)
                {
                    masyvas[i][x] = eilute[x];
                }
            }

            int laukoReiksme = masyvas[eilutesIndexas][stulpelioIndexas];
            if (laukoReiksme >= 1)
            {
                // Try all moves.
                foreach (var judesioKoordinatesVeiksmas in galimiJudesiai)
                {
                    int tikrinamoLaukelioEilutesIndexas = eilutesIndexas + judesioKoordinatesVeiksmas[0];
                    int tikrinamoLaukelioStulpelioIndexas = stulpelioIndexas + judesioKoordinatesVeiksmas[1];
                    if (ArGalimaPozicija(masyvas, eilutesIndexas, tikrinamoLaukelioEilutesIndexas, tikrinamoLaukelioStulpelioIndexas))
                    {
                        int testineReiksme = masyvas[tikrinamoLaukelioEilutesIndexas][tikrinamoLaukelioStulpelioIndexas];
                        if (testineReiksme == 0)
                        {
                            masyvas[tikrinamoLaukelioEilutesIndexas][tikrinamoLaukelioStulpelioIndexas] = laukoReiksme + 1;
                            // Try another move.
                            Judejimas(masyvas, tikrinamoLaukelioEilutesIndexas, tikrinamoLaukelioStulpelioIndexas, zingsniuSkaicius + 1, ref maziausiaReiksme);
                        }
                        else if (testineReiksme == -3)
                        {
                            // Endpoint.
                           
                            AtvaizduotiLabirinta(masyvas);
                          
                            // ... Could print the optimal labirintas solution here.

                            if (zingsniuSkaicius + 1 < maziausiaReiksme)
                            {
                                maziausiaReiksme = zingsniuSkaicius;
                            }
                            return 1;
                        }
                    }
                }
            }
            return -1;
        }

       

    }

}
