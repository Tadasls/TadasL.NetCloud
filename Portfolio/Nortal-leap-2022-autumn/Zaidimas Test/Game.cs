using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas_Test
{
    public class Game
    {

        public int Sprendimas1()
        {
            //nuskaitome informacija
            string filePath = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\TestData\\map2.txt";
            string laikmenosTurinys = File.ReadAllText($"{filePath}");

            //sukuriame kintamuosius

            string[] duomenuMasyvas = laikmenosTurinys.Replace("\n", "").Split("\r");
            int x = duomenuMasyvas[0].Length; //sukurto duomenu masyvo plotis
            int y = duomenuMasyvas.Length; //sukurto duomenu masyvo aukstis
            List<int[]> labirintoIsejimai = new List<int[]> { };
            List<int[]> pakeistaMatrica = new List<int[]> { };
            int[,] laukas = new int[x, y];
            bool zaidimasTesiamas = true;

            // persivadiname visus laukus i skaicius skaiciavimams
            for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        if (duomenuMasyvas[i][j].Equals('X')) {laukas[i, j] = 0;} // pradinis taskas prilyginamas 0
                        if (duomenuMasyvas[i][j].Equals('1')) {laukas[i, j] = -1; } // medziai/sienos  prilyginamas -1
                    else {if (!duomenuMasyvas[i][j].Equals('X')) { laukas[i, j] = -2; } } // visi kiti tusti laukai prilyginami -2
                }
                }
                //susirandame isejimus
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        if (i == 0 || i == y - 1)  //matricos kaire ir desine krastines
                        {
                            if (laukas[i, j] == -2) // -2 jei tai tuscias laukas
                            {
                                int[] isejimoKordinate = { i, j };
                            labirintoIsejimai.Add(isejimoKordinate); // pridedame i sarasa isejimu
                            }
                        }
                        else
                        {
                            if (laukas[i, 0] == -2) //matricos virsutine eilute
                        {
                                int[] isejimoKordinate = { i, 0 };
                            labirintoIsejimai.Add(isejimoKordinate);
                            }
                            if (laukas[i, x - 1] == -2) //matricos apatine eilute
                        {
                                int[] isejimoKordinate = { i, x - 1 };
                            labirintoIsejimai.Add(isejimoKordinate);
                            }
                            j = x;
                        }
                    }
                }

                //uzsipildome aplinkius laukelius galimais ejimais 
                int z = 0; // pradinis taskas turi 0 reiksme
                while (zaidimasTesiamas) 
                {
                    bool aplankytasLaukas = false;
                    for (int i = 0; i < y - 1; i++)
                    {
                        for (int j = 0; j < x - 1; j++)
                        {
                            if (laukas[i, j] == z)
                            {
                                if (laukas[i + 1, j] == -2) { laukas[i + 1, j] = z + 1; aplankytasLaukas = true; } // desine
                                if (laukas[i - 1, j] == -2) { laukas[i - 1, j] = z + 1; aplankytasLaukas = true; } // kaire
                                if (laukas[i, j + 1] == -2) { laukas[i, j + 1] = z + 1; aplankytasLaukas = true; } // virsus
                                if (laukas[i, j - 1] == -2) { laukas[i, j - 1] = z + 1; aplankytasLaukas = true; } // apacia

                            int[] naujaVerte = { i, j };
                            pakeistaMatrica.Add(naujaVerte); // pridedame i sarasa isejimu
                            Display();
                            Console.WriteLine(" ");
                            Thread.Sleep(200);
                            Console.Clear();
                        }
                        }
                    }

                //ieskome optimaliausio ejimo skaiciaus
                //einu per isejimu masyva, ir randu pirma uzpildyta reiksme, kuri nėra lygi -2 t.y. tusciam laukui, reiskia kad tas laukas panaudotas isejimui. 
                foreach (int[] labirintoKoordinates in labirintoIsejimai)
                    {
                        if (laukas[labirintoKoordinates[0], labirintoKoordinates[1]] != -2) // - 2 yra lygu tusciam laukui
                        { int geriausiasRezultatas = laukas[labirintoKoordinates[0], labirintoKoordinates[1]];
                        zaidimasTesiamas = false;
                       // Console.WriteLine(geriausiasRezultatas);
                        return geriausiasRezultatas;
                        }
                    }
                    if (!aplankytasLaukas){ break;} //kai nera daugiau galimu ejimai, baigiama isejimo paieska.
                    z++; //  atsimusus i akligatvi , tikriname sekancias ejimo galimybes
            }
                return -1;

             void Display()
            {
                for (int i = 0; i < duomenuMasyvas[0].Length; i++)
                {
                    for (int j = 0; j < duomenuMasyvas.Length; j++)
                    {
                        if (laukas[i, j] == -2){ Console.Write(" "); } 
                        else if (laukas[i, j] == -1) { Console.Write("|"); }
                        else { Console.Write(laukas[i, j]); }
                    }
                  Console.WriteLine();
                }

            }

        }




    }


}
