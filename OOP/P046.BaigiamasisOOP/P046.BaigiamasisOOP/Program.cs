using Domain.Models;

namespace P046.BaigiamasisOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, TOWER OF HANOI!");
            #region    

            string D0 = "      |      ";
            string D1 = "     #|#     ";
            string D2 = "    ##|##    ";
            string D3 = "   ###|###   ";
            string D4 = "  ####|####  ";
            string aEil = "       ----1stulp-------2stulp-------3stulp----";



            string L0 = $"{D0}{D0}{D0}";
            string L1 = $"{D1}{D0}{D0}";
            string L2 = $"{D2}{D0}{D0}";
            string L3 = $"{D3}{D0}{D0}";
            string L4 = $"{D4}{D0}{D0}";

            List<string> C1 = new List<string>() { D0, D0, D0 };
            List<string> C2 = new List<string>() { D0, D0, D0 };
            List<string> C3 = new List<string>() { D0, D0, D0 };



            Console.WriteLine($"1eil. {L0}");
            Console.WriteLine($"2eil. {L1}");
            Console.WriteLine($"3eil. {L2}");
            Console.WriteLine($"4eil. {L3}");
            Console.WriteLine($"5eil. {L4}");
            Console.WriteLine(aEil);

            int sekosLogeris = 0;
            ConsoleKeyInfo input;



            do
            {


                do
                {

                    Console.WriteLine("Pasirenkite vieną iš 3 stulpelių");
                    input = Console.ReadKey();
                    if (input.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }

                } while (input.KeyChar == '1' && input.KeyChar == '2' && input.KeyChar == '3' && input.KeyChar == 'H' && input.KeyChar == 'h');



                switch (input.Key)
                {

                    case ConsoleKey.NumPad1:
                        Console.WriteLine("pirmas stulpelis");
                        sekosLogeris++;



                        break;

                    case ConsoleKey.NumPad2:
                        Console.WriteLine("antras stulpelis");
                        sekosLogeris++;
                        break;


                    case ConsoleKey.NumPad3:
                        Console.WriteLine("trecias stulpelis");
                        sekosLogeris++;

                        break;
                    case ConsoleKey.H:
                        Console.WriteLine("Help");


                        break;

                    default:
                        Console.WriteLine("NETEISINGA ĮVESTIS");
                        break;
                }


                Console.WriteLine("Ėjimas " + sekosLogeris);
                Console.WriteLine("Diskas rankoje: " + input); //todo
            } while (true);


            #endregion
            #region  // salyga zaidimo

            /*
              Ėjimas 0

              Diskas rankoje: 

              1eil.       |            |            |
              2eil.      #|#           |            |      
              3eil.     ##|##          |            |      
              4eil.    ###|###         |            |      
              5eil.   ####|####        |            |      
                   ---- -[1]----------[2]----------[3]------

              Norėdami išeiti paspauskite 'Esc'
              Pagalbai paspauskite 'H'
              Pasirinkite stulpelį iš kurio paimti

            
             ŽAIDIMO TAISYKLĖS:
- ŽAIDŽIAMAS 4 DISKŲ IR 3 STULPELIŲ ŽAIDIMAS
- NUDOTOJAS ĮVEDA STULPELIO NR IŠ KURIO PAIMTI VIRŠUTINĮ DISKĄ
- PAIMTI GALIMA TIK VIENĄ IR TIK VIRŠUTINĮ DISKĄ
- NAUDOTOJAS TURI MATYTI KOKĮ DISKĄ PAĖMĖ

- NAUDOTOJAS TURI MATYTI IŠ KURIO STULPELIO PAĖMĖ DISKĄ KURĮ TURI RANKOJE
- VIENĄ ĖJIMĄ SUDARO VIRŠUTINIO DISKO PAĖMIMAS IR PADĖJIMAS
- ĖJIMAI TURI BŪTI SKAIČIUOJAMI
- NEGALIMA DIDESNĮ DISKĄ PADĖTI ANT MAŽESNIO 
(TOKES ĖJIMAS NESKAIČIUOJAMAS)
(RAUDONA SPALVA IŠVESTI 'NEGALIMA DIDESNIO DISKO DĖTI ANT MAŽESNIO')
- JEI SULPELYJE NĖRA DISKŲ NIEKO PAIMTI NEGALIMA
(TOKES ĖJIMAS NESKAIČIUOJAMAS)
(RAUDONA SPALVA IŠVESTI 'STULPELYJE NĖRA DISKO')
- JEI ĮVESTAS NEEGZISTUOJANTIS SULPELIS 
(TOKES ĖJIMAS NESKAIČIUOJAMAS)
(RAUDONA SPALVA IŠVESTI 'NETEISINGA ĮVESTIS')
- NUSPAUDUS 'ESC' KLAVIŠĄ ŽAIDIMAS TURI BAIGTIS
- NUSPAUDUS 'H' KLAVIŠĄ IŠKVIEČIAMA PAGALBA (APRAŠYMAS TOLIAU)
UŽDUOTYS:
1. KIEKVIENAS ĖJIMAS TURI BŪTI ĮRAŠOMAS. 
- ĮRAŠYMAS VYKDOMAS Į SKIRTINGUS FAILĄ(-US) (IŠPLĖTIMAS NURODYTAS) 
- GALIMO FAILŲ TURINIO FORMATAI (TIKSLŪS KONTRAKTAI APRAŠYTI ŽEMIAU):
(.csv) CSV  
(.html) HTML <table>....</table> 
(.txt) NATŪRALI KALBA PVZ: "žaidime kuris pradėtas 2022-01-01 12:00, ėjimu nr 2 dviejų dalių diskas buvo paimtas iš pirmo stulpelio ir padėtas į trečią" 
- BŪTINAS UNIT-TEST AR TEISINGAI SUFORMUOTAS FAILO TURINYS
- GALI BŪTI PASIRINKTAS VIENAS ARBA VISI FORMATAI. 
- NEGALIMA NEPASIRINKTI NEI VIENO. 
- PASIRINKIMAS PADAROMAS PROGRAMOS PALEIDIMO METU PESKAIČIUS KONFIGURACINĮ FAILĄ game.config
2. TURI BŪTI GALIMYBĖ PERŽIŪRĖTI ŽAIDIMO STATISTIKĄ.
- SKAITANT ŽAIDIMŲ ĮRAŠUS TURI BŪTI GALIMA SUGENERUTUOTI IR PAMATYTI ATASKAITĄ  (UNIT-TEST)
- JEI ŽAIDIMAS BUVO NEBAIGTAS VIETOJ KIEKIO IŠVESTI N/B. POKYČIUI SKAIČIUOTI ŠIS ŽAIDIMAS NENAUDOJAMAS. PRIE POKYČIO IŠVESTI N/G.
- SUSKAIČIUOTI ĖJIMŲ POKYTĮ NUO PASKUTINIO ŽAIDIMO
- TURI BŪTI GALIMYBĖ ATASKAITOS STULPELĮ "Ėjimų kiekis iki laimėjimo" 
PAKEISTI STULPELIU "Perteklinių ėjimų kiekis" (minimalus ėjimų kiekis yra 15)
NAUDOTOJAS PASIRENKA KOKIOS FORMOS ATASKAITA NORI MATYTI
- ATASKAITA TURI BŪTI IŠVEDAMA Į KONSOLĘ.
- SERVISAI TURI MOKĖTI SKAITYTI VISUS FORMATUS (csv, html ir txt), TAČIAU PRIORITETAS TEIKIAMAS TOKIA TVARKA TXT -> HTML -> CSV (UNIT-TEST)
-------------------------------------------------------------- 
| Žaidimo data       | Ėjimų kiekis iki laimėjimo | Pokytis  |
-------------------------------------------------------------- 
|  2022-01-01 12:05  |    40                      |    N/G   |
--------------------------------------------------------------
|  2022-01-02 12:05  |    41                      |    +1    |
-------------------------------------------------------------- 
|  2022-01-02 12:10  |    N/B                     |    N/G   |
-------------------------------------------------------------- 
|  2022-01-02 12:15  |    15                      |   -26    |
-------------------------------------------------------------- 
-------------------------------------------------------------- 
| Žaidimo data       | Perteklinių ėjimų kiekis   | Pokytis  |
-------------------------------------------------------------- 
|  2022-01-01 12:05  |    25                      |    N/G   |
--------------------------------------------------------------
|  2022-01-02 12:05  |    26                      |    +1    |
-------------------------------------------------------------- 
|  2022-01-02 12:10  |    N/B                     |    N/G   |
-------------------------------------------------------------- 
|  2022-01-02 12:15  |    0                       |   -26    |
-------------------------------------------------------------- 
3. ŽAIDIMO METU ŽAIDĖJAS TURI TURĖTI GALIMYBĘ PAPRAŠYTI KOMPIUTERIO PAGALBOS
- PAGALBOS SERVISAS NUSKAITO FAILO(-Ų) TURINĮ IR IEŠKO ĮRAŠYTOS ESAMOS SITUACIJOS (UNIT-TEST)
- SERVISAS TURI MOKĖTI SKAITYTI VISUS FORMATUS (csv, html ir txt), TAČIAU PRIORITETAS TEIKIAMAS TOKIA TVARKA CSV -> HTML-> TXT (UNIT-TEST)
- SURADUS JAU ŽAISTĄ TOKIĄ SITUACIJĄ SERVISAS PASIŪLO ĖJIMĄ su tekstu "paimkite diską iš ...... stulpelio padėkite į ......." (UNIT-TEST) 
- JEI SITUACIJA NEBUVO RASTA, IŠVEDAMAS PRANEŠIMAS 'PAGALBA NEGALIMA' (UNIT-TEST)
- JEI BUVO RASTOS KELIOS TOKIOS SITUACIJOS ATRENKAMA TAS ĖJIMAS KURIS GREIČIAUSIAI PRIVEDĖ PRIE LAIMĖJIMO (UNIT-TEST)
- BŪTINAS UNIT-TEST AR TEISINGAI PADEDAMA, IR AR TIKRAI PARENKAMA GERIAUSIA ĮRAŠYTA PAGALBA              
        ↑↑↑↑↑        ↓↓↓↓↓
1eil.       |            |            |      
2eil.      #|#           |            |      
3eil.     ##|##          |            |      
4eil.    ###|###         |            |      
5eil.   ####|####        |            |      
    -----[1]----------[2]----------[3]------
<pagalba> - paimkite diską iš pirmo stulpelio ir padėkite į antrą
Norėdami išeiti paspauskite 'Esc' 
Pagalbai paspauskite 'H' 
Pasirinkite stulpelį iš kurio paimti
4. BAIGIAMOJO DARBO KOREKTIŠKAM VEIKIMUI PATIKRINTI NAUDOJAMI TESTINIAI DUOMENYS .CSV, .HTML IR .TXT FAILUOSE
- ĮRAŠYTI TIE PATYS DUOMENYS GALI KARTOTIS KELIUOSE FAILUOSE. UNIKALUS RAKTAS YRA ŽAIDIMO DATA IR LAIKAS.
- DALIS ŽAIDIMO DUOMENŲ BUS VIENAME, DALIS KITAME FAILE, O DALIS KARTOSIS PER KELIS AR VISUS FAILUS, TODĖL NUSKAITYTI REIKIA VISUS
- BŪTINA LAIKYTIS ŽEMIAU PATEIKIAMŲ KONTRAKTŲ (atsiskaitymo metu dėstytojas gali paprašyti sudėti jo pateiktus testinius duomenis):
** CSV KONTRAKTAS
zaidimo_pradzios_data, ejimo_nr, disko_1_vieta, disko_2_vieta, disko_3_vieta, disko_4_vieta 
PVZ:
2022-01-01 12:00,1,2,1,1,1
2022-01-01 12:00,2,2,3,1,1
** HTML LENTELĖS 
PVZ:
<table border>
<tr>
<th>ŽAIDIMO PRADŽIOS DATA</td>
<th>ĖJIMO NR</td>
<th>DISKO 1 VIETA</td>
<th>DISKO 2 VIETA</td>
<th>DISKO 3 VIETA</td>
<th>DISKO 4 VIETA</td>
</tr>
<tr>
<td>2022-01-01 12:00</td>
<td>1</td>
<td>2</td>
<td>1</td>
<td>1</td>
<td>1</td>
</tr>
<tr>
<td>2022-01-01 12:00</td>
<td>2</td>
<td>2</td>
<td>3</td>
<td>1</td>
<td>1</td>
</tr>
</table>
** NATŪRALIOS KALBOS VIENA EILUTĖ FORMUOJAMA TAIP:
"žaidime kuris pradėtas {zaidimo_pradzios_data}, ėjimu nr {ejimo_nr} {disko_dydis} dalių diskas buvo paimtas iš {is_stulpelio_nr_zodziu} sulpelio ir padėtas į {i_stulpelio_nr_zodziu}" 
PVZ: 
žaidime kuris pradėtas 2022-01-01 12:00, ėjimu nr 1, 1 dalies diskas buvo paimtas iš pirmo stulpelio ir padėtas į antrą
žaidime kuris pradėtas 2022-01-01 12:00, ėjimu nr 2, 2 dalių diskas buvo paimtas iš pirmo stulpelio ir padėtas į trečią 
5. (BONUS) 
-
-
-
-
APRIBOJIMAI:
- TAIKYTI "Dependency inversion principle". t.y. VISI SERVISAI TURI BŪTI KONSTRUOJAMI Į INTERFACE
- TAIKYTI "Single-responsibility principle". t.y. KLASĖS TURI ATLIKTI TIK VIENOS ATSAKOMYBĖS UŽDUOTIS IR GALI BŪTI KEIČIAMOS TIK DĖL VIENOS PRIEŽASTIES 


            */


            #endregion

        }

        static void Hanoi()
        {


            List<Disk> aTower = new List<Disk>();
            aTower.Add(new Disk(1, 3, ConsoleColor.Green));//bottom
            aTower.Add(new Disk(2, 2, ConsoleColor.White));//mid
            aTower.Add(new Disk(3, 1, ConsoleColor.Red));//top
            List<Disk> bTower = new List<Disk>();
            List<Disk> cTower = new List<Disk>();
            List<List<Disk>> abcTowers = new List<List<Disk>>();
            abcTowers.Add(aTower);
            abcTowers.Add(bTower);
            abcTowers.Add(cTower);

            bool keepPlaying = true;

            int numberOfMoves = 0;

            while (keepPlaying)
            {
                Console.Clear();
                DrawHanoi(abcTowers);
                Console.Write("Paimkite diska iš: ");
                char itemToMove = Console.ReadKey().KeyChar;
                Console.Write(" padėkite ant bokšto: ");
                char moveTo = Console.ReadKey().KeyChar;
                UpdateHanoi(ref abcTowers, itemToMove, moveTo, ref keepPlaying, ref numberOfMoves);
            }
        } // spalvoti hanoi
        static void UpdateHanoi(ref List<List<Disk>> towers, char itemToMove, char moveTo, ref bool keepPlaying, ref int numberOfMoves)
        {
            int itemToMoveParse;
            int moveToParse;
            Int32.TryParse(itemToMove.ToString(), out itemToMoveParse);
            Int32.TryParse(moveTo.ToString(), out moveToParse);
            if (Int32.TryParse(itemToMove.ToString(), out itemToMoveParse) && Int32.TryParse(moveTo.ToString(), out moveToParse))
            {
                Disk disc = getDisc(towers, itemToMoveParse);
                if (discFree(towers[findTower(towers, itemToMoveParse) - 1], itemToMoveParse) && movePossible(towers, disc, moveToParse))
                {
                    numberOfMoves++;
                    MoveDisc(disc, ref towers, moveToParse);
                    if (towers[2].Count == 3 && towers[1].Count == 0 && towers[0].Count == 0)
                    {
                        keepPlaying = false;
                        Console.Clear();
                        DrawHanoi(towers);
                        Console.WriteLine(Environment.NewLine + "You won in " + numberOfMoves.ToString() + " moves, congratulations!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + "Illegal move");
                    Console.ReadKey();
                }
            }
        }
        static Disk getDisc(List<List<Disk>> towers, int discNumber)
        {
            foreach (List<Disk> tower in towers)
            {
                foreach (Disk disc in tower)
                {
                    if (disc.Number == discNumber)
                    {
                        return disc;
                    }
                }
            }
            return new Disk(0, 0, ConsoleColor.Black);
        }
        static bool discFree(List<Disk> tower, int discNumber)
        {
            if (tower.Last().Number == discNumber)
            {
                return true;
            }
            return false;
        }
        static int findTower(List<List<Disk>> towers, int discNumber)
        {
            int t = 0;
            foreach (List<Disk> tower in towers)
            {
                t++;
                foreach (Disk d in tower)
                {
                    if (d.Number == discNumber)
                    {
                        return t;
                    }
                }
            }
            return 1;
        }
        static bool movePossible(List<List<Disk>> towers, Disk disc, int moveToParse)
        {
            int i = 0;
            foreach (List<Disk> tower in towers)
            {
                i++;
                if (moveToParse == i)
                {
                    if (tower.Count == 0 || (tower.Count > 0 && tower.Last() != null && tower.Last().Size > disc.Size))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static void MoveDisc(Disk disc, ref List<List<Disk>> towers, int moveTo)
        {
            towers[findTower(towers, disc.Number) - 1].Remove(disc);
            towers[moveTo - 1].Add(disc);
        }
        static void DrawHanoi(List<List<Disk>> towers)
        {
            Console.WriteLine("Move all discs to tower 3" + Environment.NewLine);
            for (int a = 0; a < towers.Count; a++)
            {
                Console.WriteLine("Tower " + (a + 1).ToString() + ":");
                for (int i = towers[a].Count - 1; i >= 0; i--)
                {
                    Disk d = towers[a][i];
                    string discString = new string(' ', d.Size) + d.Number + new string(' ', d.Size);

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(new string(' ', d.Number));

                    Console.BackgroundColor = d.Color;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(discString);

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(new string(' ', d.Number));

                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


        static void Game()  // sprendimui rasti metodas
            {
                Tower tower = new Tower(); // naujas objektas sukuriamas
                Console.Write("Enter the number of discs: ");
                string cnumdiscs = Console.ReadLine();
                tower.numdiscs = Convert.ToInt32(cnumdiscs);
                tower.movetower(tower.numdiscs, 1, 3, 2);
                Console.ReadLine();
                
            }


        

       
        





      


    }
}