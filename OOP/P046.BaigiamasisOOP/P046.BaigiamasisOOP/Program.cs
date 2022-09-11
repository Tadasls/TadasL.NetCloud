using Domain.Models;
using Domain.Services;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace P046.BaigiamasisOOP
{
    public class Program
    {
        public static char input;
        public static bool gameOver = false;
        public static int sekosLogeris = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, TOWER OF HANOI!");
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);

            Loger zaidimoLogas = new Loger();

            Tower b1 = new Tower();
            Tower b2 = new Tower();
            Tower b3 = new Tower();

            b1.UzpildytiBokstaDuomenis();  //uzpildomas tik pirmas bokstas, nes kiti tusti

            Tower[] bokstai = new Tower[] { b1, b2, b3 };

            DrawHanoi(bokstai); // pradinis piesinys
            Console.WriteLine();

            DateTime pradziosdata = DateTime.Now;

            do
            {
                int isKurPaimtas = -1;
                int paimtasDiskas = -1;
                bool ivestas = false;

                do
                {
                    DrawHanoi(bokstai); //pirmos ivesties piesinys

                    isKurPaimtas = IvestisSuMeniu("Prasome pasirinkti boksta:");
                    paimtasDiskas = bokstai[isKurPaimtas - 1].SurastiVirsutinioDiskoIndeksa(); // need fix 

                    if (paimtasDiskas != -1)
                    {
                        ivestas = true;
                    }
                    else 
                    { 
                        TuscioDiskoKlaidosPranesimas();
                    }

                } while (!ivestas);

                int iKurPadetas = -1;
                bool idetas = false;
                do
                {
                    DrawHanoi(bokstai); //antros ivesties piesinys

                    iKurPadetas = IvestisSuMeniu($"Prasome pasirinkti boksta i kuri padesite diska : {paimtasDiskas}");
                    idetas = bokstai[iKurPadetas - 1].PadetiDiskaINaujaVieta(paimtasDiskas);
                    if (idetas)
                    {
                        sekosLogeris++;
                        zaidimoLogas.WriteLog(isKurPaimtas, paimtasDiskas, iKurPadetas, bokstai, pradziosdata, sekosLogeris);
                    }
                    else
                    {
                        DiskoDydzioKlaidosPranesimas();
                    }

                } while (!idetas);

                if (bokstai[2].Bokstas[1] == 1)//zaidimo pabaigos check
                {
                    gameOver = true;
                    zaidimoLogas.WriteLog(isKurPaimtas, paimtasDiskas, iKurPadetas, bokstai, pradziosdata, sekosLogeris, true);
                }

            } while (!gameOver);

            DrawHanoi(bokstai); //finalinis piesimas

            GameOwerScreen();
        }



        static void TuscioDiskoKlaidosPranesimas()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("STULPELYJE NĖRA DISKO");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
        }
        static void DiskoDydzioKlaidosPranesimas()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NEGALIMA DIDESNIO DISKO DĖTI ANT MAŽESNIO");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
        }
        static void IvestiesKlaidosPranesimas()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NETEISINGA ĮVESTIS");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
        }
        static void GameOwerScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"žaidimas baigtas per {sekosLogeris} ėjimų");
            Console.ForegroundColor = ConsoleColor.White;
        }




        static void DrawHanoi(Tower[] bokstai, int bokstas = -1, int diskas = -1)
        {
            Console.Clear();
            Console.WriteLine($"Ejimas : {sekosLogeris}");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                string eilute = $"Eilutė {i + 1} ";
                for (int j = 0; j < 3; j++)
                {
                    string diskoSonas = new string('#', bokstai[j].Bokstas[i]);
                    string tusciaDalis = new string(' ', 4 - bokstai[j].Bokstas[i]);
                    eilute += $"  {tusciaDalis}{diskoSonas}|{diskoSonas}{tusciaDalis}  ";
                }
                Console.WriteLine(eilute);
            }

            if (diskas > 0)
            {
                string bokstas1 = (bokstas == 1) ? $"__^^^[{1}]^^^__" : $"_____[{1}]_____";
                string bokstas2 = (bokstas == 2) ? $"__^^^[{2}]^^^__" : $"_____[{2}]_____";
                string bokstas3 = (bokstas == 3) ? $"__^^^[{3}]^^^__" : $"_____[{3}]_____";
                Console.WriteLine($"Eilute {6} {bokstas1}{bokstas2}{bokstas3}");
                string diskoSonas = new string('#', diskas);

                Console.WriteLine($"Pasirinktas {diskoSonas}|{diskoSonas} dydzio diskas");
            }
            else { Console.WriteLine($"Eilute {6} {$"_____[{1}]_____"}{$"_____[{2}]_____"}{$"_____[{3}]_____"}"); }

        }
        static int IvestisSuMeniu(string koklaust)
        {
            do
            {
                List<string> skaiciai = new List<string> { "1", "2", "3" };
                Console.WriteLine(koklaust);

                input = Console.ReadKey().KeyChar;
                if (input == '\u001b')
                {
                    Environment.Exit(0);
                }
                if (input.ToString().ToLower().Equals("h"))
                {
                    Environment.Exit(0); // todo Helpo metodus
                }


                string testas = input.ToString().ToLower();

                if (skaiciai.Contains(input.ToString()))
                {
                    return Convert.ToInt32(input.ToString());
                }
                else
                {
                    IvestiesKlaidosPranesimas();
                }



            } while (input != '1' && input != '2' && input != '3');

            return -1;



           
        }
       
        #region // uzdavinio salyga


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
    
}