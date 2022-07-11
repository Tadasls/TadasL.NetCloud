using System.Diagnostics;
using System.Globalization;

namespace SavarDrbV03DNR
{
    public class Program
    {
        public static bool arbuvonormalizuota = false;
        public static bool arGrandineValidi = false;
        public static string dnrGlobaliGrandine = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";  //globalizacija 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, DNR!"); 
            DNR();
        }
                /*----uzdavinio--Salyga---------------------------------------------
                    Tarkime turime DNR grandinę užkoduotą tekstu var txt =" T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ".
                Galimos bazės: Adenine, Thymine, Cytosine, Guanine
                Parašykite programą kurioje atsiranda MENIU kuriame naudotojas gali pasirinkti:
                1. Atlikti DNR grandinės normalizavimo veiksmus:
                    - pašalina tarpus.
                    - visas raides keičia didžiosiomis. 
                2. Atlikti grandinės validaciją
                    - patikrina ar nėra kitų nei ATCG raidžių
            3. Atlieka veiksmus su DNR grandine (tik tuo atveju jei grandinė yra normalizuota ir validi). 
            Nuspaudus 3 įeinama į sub-meniu
                - Jeigu grandinė yra validi, tačiau nenormalizuota programa pasiūlo naudotojui 
                1) normalizuoti grandinę
                2) išeiti iš programos
                - jei grandinė normalizuota arba kai buvo atlikta normalizacija
                1) GCT pakeis į AGG
                2) Išvesti ar yra tekste CAT 
                3) Išvesti trečia ir penktą grandinės segmentus (naudoti Substring()).
                4) Išvesti raidžių kiekį tekste (naudoti string composition)
                5) Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas 
                6) Prie grandinės galo pridėti iš klaviatūros įvesta segmentą  
                    (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės) 
                7) Iš grandinės pašalinti pasirinką elementą  
                8) Pakeisti pasirinkti segmentą įvestu iš klaviatūros  
                    (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės) 
                9) Gryžti į ankstesnį meniu
           Visoms operacijoms reikalingi testai.
           */

        public static void DNR()
        {

            Console.WriteLine($"Pasirinkite veiksma \n 1) DNR grandinės normalizavimas \n 2) DNR Grandinės validavimas \n 3) Sub-meniu \n ");
            string meniu = Convert.ToString(Console.ReadLine());

            if (meniu == "1")
            {
                arbuvonormalizuota = GrandinesNormalizavimas(ref dnrGlobaliGrandine); //startuoja normalizavimo metodas
                Console.WriteLine(" Grandine buvo Normalizuota");
                DNR(); //gryztama i pagrindini meniu
            }
            else if (meniu == "2")
            {
                arGrandineValidi = GrandinesValidavimas(ref dnrGlobaliGrandine); //startuoja validacija
                Console.WriteLine($"Ar grandine Validi {arGrandineValidi.ToString()} ");
                DNR(); //gryztama i pagrindini meniu
            }
            else if (meniu == "3")
            {
                if (arbuvonormalizuota || arGrandineValidi)   // jei normalizuota arba validuota tada pateikiamas submeniu
                {
                    Console.WriteLine($"Pasirinkite veiksma \n " +
                        $"1) GCT pakeisti į AGG \n " +
                        $"2) Išvesti ar yra tekste CAT \n " +
                        $"3) 3 ir 5 grandinės segmentai\n " +
                        $"4) Raidžių kiekis tekste \n " +
                        $"5) Kiek kartų pasikartoja ivestas segmentas \n " +
                        $"6) Prie grandinės galo pridėti ivesta elementa \n " +
                        $"7) pašalinti pasirinką elementą\n " +
                        $"8) Pakeisti pasirinkti segmentą \n " +
                        $"9) Exit to main meniu \n ");
                    string submeniu = Convert.ToString(Console.ReadLine());

                    switch (submeniu) //state machine
                    {
                        case "1":
                            TreciasSub1(ref dnrGlobaliGrandine);
                            break;
                        case "2":
                            TreciasSub2(ref dnrGlobaliGrandine);
                            break;
                        case "3":
                            TreciasSub3(ref dnrGlobaliGrandine);
                            break;
                        case "4":
                            TreciasSub4(ref dnrGlobaliGrandine);
                            break;
                        case "5":
                            Console.WriteLine("Iveskite triju raidziu koda xxx kuris sudarytas is AGTC");
                            string ivestasSegmentas = Console.ReadLine();
                            TreciasSub5(ivestasSegmentas, ref dnrGlobaliGrandine);  //cia isivedame suvedimas kad galetume testuotis metodus
                            break;
                        case "6":
                            Console.WriteLine("Iveskite triju raidziu koda xxx kuris sudarytas is AGTC");
                            string ivestasSegmentas2 = Console.ReadLine();
                            TreciasSub6(ivestasSegmentas2, ref dnrGlobaliGrandine);
                            break;
                        case "7":
                            Console.WriteLine($"Iveskite segmenta kuri norite salinti is {dnrGlobaliGrandine}");
                            string trinamasElementas = Console.ReadLine();
                            TreciasSub7(trinamasElementas, ref dnrGlobaliGrandine);
                            break;
                        case "8":
                            Console.WriteLine("Iveskite segmenta kuri norite keisti");
                            string pasirinktasElementas = Console.ReadLine();
                            Console.WriteLine("Iveskite segmenta kuriuo norite pakeisiti");
                            string ivestasElementas = Console.ReadLine();
                            TreciasSub8(pasirinktasElementas, ivestasElementas, ref dnrGlobaliGrandine);
                            break;
                        case "9":
                            TreciasSub9(ref dnrGlobaliGrandine);
                            break;
                        default:
                            Console.WriteLine($" tokio meniu nera");
                            break;
                    };
                }
                else
                {
                    Console.WriteLine("1) Normalizuoti Grandine  \n2) Iseiti is programos ");
                    string variantasB = Console.ReadLine();
                    if (variantasB == "1")
                    {
                        arbuvonormalizuota = GrandinesNormalizavimas(ref dnrGlobaliGrandine);
                        GrandinesNormalizavimas(ref dnrGlobaliGrandine);
                        Console.WriteLine(" Grandine buvo Normalizuota");
                        DNR();
                    }
                    else
                    {
                        Console.WriteLine("Exit");
                        System.Environment.Exit(-1);
                    }
                }

            }
            else
            {
                Console.WriteLine("nera tokio pasirinkimo");
            }
        }

        public static bool GrandinesNormalizavimas(ref string dnrGlobaliGrandine)
        {
            dnrGlobaliGrandine = dnrGlobaliGrandine.Trim().ToUpper().Replace(" ", "");
            //Console.WriteLine("Po normalizavimo ! " + dnrGrandine);
            Debug.WriteLine("Ivyko normalizacija pasalinti tarpai ir padarytos didziosios raides");
            return true;
        }
        public static bool GrandinesValidavimas(ref string dnrGlobaliGrandine)
        {
            string sutrumpintaGrandine = dnrGlobaliGrandine.ToUpper().Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "").Replace("-", "").Replace(" ", "");
            bool isDnrValid = sutrumpintaGrandine.Length == 0;
            //Console.WriteLine("pries validavima ! " + dnrGrandine +"\n ir po normalizavimo" + dnrGrandine.ToUpper().Trim().Replace(" ", ""));
            Debug.WriteLine(" Ivyko validacija Tikrintos raides A,T,C,G");
            return isDnrValid;
        }
        public static string TreciasSub1(ref string dnrGlobaliGrandine)
        {
            //3.2.1
            string dnrGrandineUpdated = dnrGlobaliGrandine.Replace("GCT", "AGG");
            Console.WriteLine(dnrGrandineUpdated);
            Console.WriteLine("pakeista GCT i AGG");
            return dnrGrandineUpdated;
        }
        public static bool TreciasSub2(ref string dnrGlobaliGrandine)
        {
            //3.2.2
            Console.WriteLine($"  ar grandineje {dnrGlobaliGrandine} yra CAT  : {dnrGlobaliGrandine.Contains("CAT").ToString()} ");
            return dnrGlobaliGrandine.Contains("CAT");
        }
        public static string TreciasSub3(ref string dnrGlobaliGrandine)
        {
            //3.2.3 
            //String[] reiksmes = dnrGrandine.Split("-");
            //Console.WriteLine($" trecios sekcijos reiksmes : {reiksmes[2]}  penktos sekcijos reiksmes : {reiksmes[4]}");
            Console.WriteLine($" Trecios sekcijos reiksmes : {dnrGlobaliGrandine.Substring(8, 3)}  penktos sekcijos reiksmes : {dnrGlobaliGrandine.Substring(16, 3)} ");
            return dnrGlobaliGrandine.Substring(8, 3) + "-" + dnrGlobaliGrandine.Substring(16, 3);

        }
        public static int TreciasSub4(ref string dnrGlobaliGrandine)
        {
            //3.2.4
            string senagrandine = dnrGlobaliGrandine;
            senagrandine = senagrandine.Replace("-", "");
            Console.WriteLine($"Grandines raidziu kiekis = : {senagrandine.Length}");
            return senagrandine.Length;
        }
        public static int TreciasSub5(string ivestasSegmentas, ref string dnrGlobaliGrandine)
        {
            //3.2.5
            ivestasSegmentas = ivestasSegmentas.ToUpper();
            int kartu = dnrGlobaliGrandine.Split("-").Count(s => s == ivestasSegmentas);
            Console.WriteLine($" ivestas {ivestasSegmentas} kartojasi  - {kartu.ToString()} kartu ");
            return kartu;
        }
        public static string TreciasSub6(string ivestasSegmentas2, ref string dnrGlobaliGrandine)
        {
            //3.2.6
            ivestasSegmentas2 = ivestasSegmentas2.ToUpper();
            if (ivestasSegmentas2.Length == 3 && ivestasSegmentas2.Trim().Replace("A", "").Replace("C", "").Replace("T", "").Replace("G", "").Length == 0) // validacija
            {
                dnrGlobaliGrandine = dnrGlobaliGrandine + "-" + ivestasSegmentas2;
                Console.WriteLine($" Nauja grandine {dnrGlobaliGrandine}");
            }
            else { Console.WriteLine("Neteisingai ivestas elementas"); };
            return dnrGlobaliGrandine;
        }
        public static string TreciasSub7(string trinamasElementas, ref string dnrGlobaliGrandine)
        {
            //3.2.7
            trinamasElementas = trinamasElementas.ToUpper();
            dnrGlobaliGrandine = dnrGlobaliGrandine.Replace(trinamasElementas, "");
            Console.WriteLine($" Grandine po valymo {dnrGlobaliGrandine}");
            return dnrGlobaliGrandine;
        }
        public static string TreciasSub8(string pasirinktasElementas, string ivestasElementas, ref string dnrGlobaliGrandine)
        {
            //3.2.8 
            pasirinktasElementas = pasirinktasElementas.ToUpper();
            ivestasElementas = ivestasElementas.ToUpper();
            if ((pasirinktasElementas.Length == 3 && pasirinktasElementas.Trim().Replace("A", "").Replace("C", "").Replace("T", "").Replace("G", "").Length == 0) && (ivestasElementas.Length == 3 && ivestasElementas.Trim().Replace("A", "").Replace("C", "").Replace("T", "").Replace("G", "").Length == 0)) //validacija
            {
                dnrGlobaliGrandine = dnrGlobaliGrandine.Replace(pasirinktasElementas, ivestasElementas);
                Console.WriteLine($"Nauja grandine {dnrGlobaliGrandine}");
            }
            else { Console.WriteLine("Neteisingai ivesti elementai"); };
            return dnrGlobaliGrandine;
        }
        public static void TreciasSub9(ref string dnrGlobaliGrandine)
        {
            //3.2.9
            DNR();
        }
    }
}