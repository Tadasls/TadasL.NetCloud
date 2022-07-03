namespace P10_Metodai
{
    public class Program
    {
        // klaseje turi buti metodai 

         static string Tekstas = " ";  //globalus kintamasis

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Methods!");
            // metodai neturetu buti metode, o turi buti klaseje


            // teorija
            #region  

            /*
            
            Console.WriteLine("Iveskite teksta");
            Tekstas = Console.ReadLine();
            IsvestiIvestaTeksta();  //1
            


            Console.WriteLine("---------------------------");
            Console.WriteLine("Sukuriame pirma savo metoda :) ");
            TadoMetodas();//metodo iskvietimas, kai metodas nieko negrazina ir nieko nepriima


            Console.WriteLine("---------------------------");
            float kazkoksSkaicius = GautiRandomSkaiciu();//metodo kvietimas ir grazinamos reiksmes priskyrimas
            Console.WriteLine($" kazkoksSkaicius yra lygus = {kazkoksSkaicius}");
            

            Console.WriteLine("---------------------------");
            // nieko negrazina bet priema viena parametra
            int a = 2;
            IveskSkaiciuEkranan(a); //metodas su vienu parametru 
            Console.WriteLine($"skaicius a is Main {a}");


            Console.WriteLine("---------------------------");
            int sk1 = 2;
            int sk2 = 2;
            int sudaugintiSuSkaiciai = DaugintiSkaicius(sk1,sk2); //metodas su dviem parametru 
            Console.WriteLine($"sudaugintiSuSkaiciai = {sudaugintiSuSkaiciai}");


            Console.WriteLine("---------------------------");
            int sudaugintiTrysSkaiciai = DaugintiSkaicius(sk1, sk2, 2); //metodas su trimis parametru 
            Console.WriteLine($"sudaugintiTrysSkaiciai = {sudaugintiTrysSkaiciai}"); //metodo overloadinimas, metodas priima tris argumentus ir grazina int


            Console.WriteLine("---------------------------");
            double sk1d = 2.1;
            double sk2d = 2.1;
            double sudaugintiDuDoubleSkaiciai = DaugintiSkaicius(sk1d, sk2d); //metodas  tikrina ir pagal parametrus ir pagal tipa
            Console.WriteLine($"sudaugintiDuDoubleSkaiciai = {sudaugintiDuDoubleSkaiciai}");


            Console.WriteLine("---------------------------");
            double sudaugintiDuDoubleSkaiciai1 = DaugintiSkaicius((double)sk1, sk2d); //kiti kintamieji panaudoti todel nesutampa rez.
            Console.WriteLine($"sudaugintiDuDoubleSkaiciai1 = {sudaugintiDuDoubleSkaiciai1}");

            Console.WriteLine("---------------------------");
            IsveskTekstaEkranan(); // neivestas parametras nes neprivalomas
            IsveskTekstaEkranan("kazkoks tekstas paduodamas"); 
            

            Console.WriteLine("---------------------------");
            IsveskSkaiciuIrTekstaEkranan(1);
            IsveskSkaiciuIrTekstaEkranan(1, "kazkoks tekstas");
            
            
            Console.WriteLine("---------------------------");
            int patikrinimas = SkaiciausPatikrinimas(20, 50, 100);
            Console.WriteLine($"patikrinimas {patikrinimas}" );


            //paduodami pavadinti parametrai
            int patikrinimas1 = SkaiciausPatikrinimas(max:100, min:50, skaicius : 51); //kad kodas butu skaitomesnis
            Console.WriteLine($"patikrinimas {patikrinimas1}");
            //parametrus reikia paduoti is eiles 
            Console.WriteLine("---------------------------");

            Console.WriteLine("Vidurkis metotas" + Vidurkis(2,3));
            Console.WriteLine("Vidurkis metotas" + Vidurkis(2, 3, 8));
            Console.WriteLine("Vidurkis metotas" + Vidurkis(2, 3, 325, 355, 1551));

            Console.WriteLine("---------------------------");

            GautiSkaiciu(out int gautasSkaicius);
            Console.WriteLine($"gautas skaicius {gautasSkaicius}");
            
            Console.WriteLine("---------------------------");
            int rsk = 2;
            Console.WriteLine($"rsk yra lygu {rsk}");  //pasieme is cia skaiciu

            ReferenceSkaicius(ref rsk); // reikesmes perdavimas per reference keicia kvieciamajame metote
            Console.WriteLine($"rsk yra lygu {rsk}"); // pasieme su referencu skaiciu is metodo

            Console.WriteLine("---------------------------");
            //lokalios funkcijos
            int Add(int a, int b)
            {
                return a + b;   
            }
            Console.WriteLine(Add(2,2)); //nera prasmes kurioje vietoje patalpiname
            */
            
            #endregion


            //Uzdaviniai
            #region
            /*
            // uzdavinys nr 1
            SveikiVisi();
            LinkiuJumsGerosDienos();



            // uzdavinys nr 2
            NuskaitytiIrIsvestiVarda();
            LinkiuJumsGerosDienos1();

                       
            //uzdavinys nr 3

            Console.WriteLine("Iveskite 1 skaiciu  ");
            string ss1 = Console.ReadLine();
            Console.WriteLine("Iveskite 2 skaiciu  ");
            string ss2 = Console.ReadLine();

            bool arSkai1 = int.TryParse(ss1, out int intSs1);
            bool arSkai2 = int.TryParse(ss2, out int intSs2);

            if (arSkai1 && arSkai2)
            {
                SkaiciuSuma(intSs1, intSs2);
            }
            else { Console.WriteLine(" nesigauna suma"); }


            // 4 uzdavinys
            IvedimoMedotas();
                  
            
            // uzdavinis nr 5
            Console.WriteLine("  Įveskite bet kokį tekstą: 5 UZD");
            string tekstas = Console.ReadLine();
            Console.WriteLine($" Teksto ilgis yra: {TekstoIlgisBeTarpu(tekstas)}");
                     
            //uzdavinys nr 6
            Console.WriteLine("6 Uzd įvesti betkokį tekstą su tarpais  6 ");
            Console.WriteLine($"zodziu skaicius yra {KiekYraZodziu(Console.ReadLine())}");
                        
            // uzdavinys nr 7
            Console.WriteLine("7 uzd įvesti betkokį tekstą su tarpais  7 ");
            Console.WriteLine($"Metodas grąžina tarpų kiekį teksto gale {TarpaiGale(Console.ReadLine())}");
                        
            // uzdavinys nr 8
            Console.WriteLine("8 uzd įvesti betkokį tekstą su tarpais  8 ");
            Console.WriteLine($"Metodas grąžina tarpų kiekį teksto priekyje {TarpaiPradzioje(Console.ReadLine())}");

            // uzdavinys nr 9 
            Console.WriteLine("9 uzd įvesti betkokį tekstą su tarpais  9 ");
            Console.WriteLine($" kiek tarpu priekyje {KiekYraTarpuPriekyjeIrGale(Console.ReadLine(), out int tarpaiGale)} ");  // grazina reiksme is metodo
            Console.WriteLine($" kiek tarpu gale {tarpaiGale} "); // grazina paima reiksme is parametro
            
            // uzdavinys nr 10
            Console.WriteLine("paprašome įvesti betkokį tekstą su tarpais  10 ");
            Console.WriteLine($" kiek yra A raidziu skaicius {KiekYraARaidziuTekste(Console.ReadLine())}");
           
            // uzdavinys nr 11 a
            Console.WriteLine("paprašome įvesti betkokį tekstą su tarpais   11 A ");
            Console.WriteLine($" jei zodis mokausi yra tekste gauname reiksme -  {IeskomeZodzioMokausiTekste(Console.ReadLine())}");
            #endregion
            
            */
            #endregion


            // uzdavinys nr 11 b
            Console.WriteLine("paprašome ' as labai mokausi programuoti     '  11 b uzduotis");
            Console.WriteLine($" jei zodis mokausi yra tekste nesulipes  gauname reiksme -  {IeskomeZodzioMokausiEkstraTekste(Console.ReadLine()) }");
        
            // uzdavinys nr 12
            Console.WriteLine("paprašome įvesti _ as mokausi programuoti  ");
            Console.WriteLine($" ivestame  tekste 'a' raides vieta yra: - {ARaidesVietaTekste(Console.ReadLine())} ");

            

            


        }

        
        //Metodai
        #region

        public static void SveikiVisi()// 1 uzdavinio metodas
        {
            Console.WriteLine("Sveiki visi");
        }
        public static void LinkiuJumsGerosDienos()
        {
            Console.WriteLine("Linkiu jums geros dienos");
        }
                                
           public static string NuskaitytiIrIsvestiVarda()  // 2 uzdavinio  1 metodas
        {
            Console.WriteLine("Iveskite savo varda");
            var vardas = Console.ReadLine();
            Console.WriteLine($"Labas {vardas}");
            return vardas;
        }
        public static void LinkiuJumsGerosDienos1()  // 2 uzdavinio  2 metodas
        {
            Console.WriteLine($"Linkiu jums {NuskaitytiIrIsvestiVarda()} geros dienos");
        }


        // 3 uzdavinio metodo vieta 

        public static void IvedimoMedotas()  // 4 uzdavinio metodas
        {
            Console.WriteLine("iveskite bet koky teksta su tarpais ");
            string kazkoksTekstas = Console.ReadLine();
            Console.WriteLine($"Tekste tarpu yra {TarpuMetodas(kazkoksTekstas)} ");
        }

       
        public static int TekstoIlgisBeTarpu(string tekstas)// 5 uzdavinio metodas
        {
          return tekstas.Length - tekstas.Trim().Length;
        }

        public static int KiekYraZodziu(string tekstas)    // 6 uzdavinio metodas
        {
            //return tekstas.Trim().Length - tekstas.Replace(" ", "").Length + 1;
            return tekstas.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int TarpaiGale(string? tekstas) // 7 uzdavinio metodas
        {
            return tekstas.Length - tekstas.TrimEnd().Length;
        }

        public static int TarpaiPradzioje(string? tekstas) // 8 uzdavinio metodas 
        {
            return tekstas.Length - tekstas.TrimStart().Length;
        }

        public static int KiekYraTarpuPriekyjeIrGale(string tekstas, out int gale)//9 uzd metodas  kai grazina per metoda ir  parametra                                                                                      
        {
            gale = tekstas.Length - tekstas.TrimEnd().Length;
            return tekstas.Length - tekstas.TrimStart().Length;
        }

        public static void KiekYraTarpuPriekyjeIrGale(string tekstas, out int priekyje, out int gale)// 9a metodas grazina per dvejus parametrus                                                                        
        {
            gale = tekstas.Length - tekstas.TrimEnd().Length;
            priekyje = tekstas.Length - tekstas.TrimStart().Length;
        }

        public static int KiekYraARaidziuTekste(string tekstas)  // 10 uzdavinio metodas
        {
      
            return tekstas.Length - tekstas.Replace("a", "").Length;
        }


        
        public static string IeskomeZodzioMokausiTekste(string tekstas) // 11a uzdavinys
        {
             return tekstas.Contains("mokausi", StringComparison.OrdinalIgnoreCase) ? "Taip" : "Ne";             
        }
        



        public static string IeskomeZodzioMokausiEkstraTekste(string tekstas)  // 11b uzdavinys
        {
            bool isMokausi = tekstas.Contains("mokausi", StringComparison.OrdinalIgnoreCase);
            int indexOfMokausi = tekstas.IndexOf("mokausi");
            int tekstoIlgis = tekstas.Length;

            var simbolisPriesais = indexOfMokausi - 1;
            var simbolisGale = indexOfMokausi + 7;

            string galimisimboliai = " \\\"\\(\\)\\!\\,\\?"; 

            bool isPriekyjeSimbolisGalimas = (simbolisPriesais >0) ? galimisimboliai.Contains(tekstas[simbolisPriesais]):true;
            bool isGaleSimbolisGalimas = (simbolisGale < tekstoIlgis-1) ? galimisimboliai.Contains(tekstas[simbolisGale]):true;
                      
            if (isMokausi && isPriekyjeSimbolisGalimas && isGaleSimbolisGalimas) 
               return "Taip";
            else
               return "Ne";

        }

        public static int ARaidesVietaTekste(string tekstas) // 12 uzdavinys
        {
            tekstas = " " + tekstas + " ";
            int aVieta = tekstas.IndexOf("a")+1;  //+1 ?
            return aVieta;
        }


        #endregion



        //teorijos metodai
        #region
        public static void IsvestiIvestaTeksta() //1
        {
            Console.WriteLine($" ivestas tekstas {Tekstas} ");
        }

        public static int TarpuMetodas(string kazkoksTekstas)
        {
            int visasTekstoIlgis = kazkoksTekstas.Length;
            kazkoksTekstas = kazkoksTekstas.Replace(" ", "");
            return visasTekstoIlgis - kazkoksTekstas.Length;
        }

        public static void SkaiciuSuma(int intSs1, int intSs2)
        {
            Console.WriteLine($" {intSs1} + {intSs2}  = {intSs1 + intSs2}");
        }

        public static void Pasisveikinimas()
        {
            Console.WriteLine("Sveiki visi");
        }

        public static void Palinkejimas()
        {
            Console.WriteLine("Linkiu jums geros dienos");
        }

        public static void ReferenceSkaicius(ref int skaicius) 
        {
            skaicius = 900;
        }

        public static void GautiSkaiciu(out int skaicius)
        {
            skaicius = 2;   
        }

         public static double Vidurkis(params int[] skaiciai)
        {
            double total = 0;
            foreach (var skaicius in skaiciai)
            {
                total += skaicius;
            }
            return total / skaiciai.Length;
        }
                  
        public static int SkaiciausPatikrinimas(int skaicius, int min, int max)
        {
            if (skaicius < min)
            {
                return min;

            }
            if (skaicius > max)
            {
                return max;
            }
            return skaicius;
        }

        public static void IsveskTekstaEkranan(string tekstas = "tesktas neivestas") //default parametras priskiriamas
        {
          Console.WriteLine("tekstas yra " + tekstas);
        }
         
        public static void IsveskSkaiciuIrTekstaEkranan(int skaicius = 1, string tekstas = "tekstas neivestas ")
        {
            Console.WriteLine($"skaicius - {skaicius}, tekstas - {tekstas}");
        }
        public static double DaugintiSkaicius(double sk1d, double sk2d)
        {
            return sk1d * sk2d;
        }

        public static int DaugintiSkaicius(int sk1, int sk2, int sk3)
        {
           return sk1 * sk2 * sk3;
        }

        public static int DaugintiSkaicius(int sk1, int sk2)
        {
           return sk1 * sk2;
        }
        public static void IveskSkaiciuEkranan(int a)
        {
            a = a + 8;
            Console.WriteLine($"skaicius yra{a}");
        }

        public static float GautiRandomSkaiciu()
        {
            float a = 4;
            return a + 4.635228f;
            //double a = 53652;
            //return "asdffas"; blogi pvz kad negrazina kito tipo 
        }
        public static void TadoMetodas()
        {
            Console.WriteLine("Tau pavyks, Tu gali!!!");
        }

        #endregion


    }
}


// uzdaviniu salygos

#region
/*
 // 1 uzdavinys
---------------------------------------------------
       Parašykite programą kurioje yra 2 metodai. 
       - Pirmas metodas į konsolę išveda "Sveiki visi"
       - Antrtas metodas į konsolę išveda "Linkiu jums geros dienos"

  
// 2 uzdavinys
---------------------------------------------------
       Parašykite programą kurioje yra 2 metodai. 
        - Pirmas metodas naudotojo paprašo įvesti savo vardą ir  į konsolę išveda "Labas tai_kas_ivesta" 
          ir grąžina tai kas ivesta.
        - Antras metodas į konsolę išveda "Linkiu jums tai_kas_ivesta_pirmame_metode geros dienos"
       Pvz: 
       > Iveskite savo Varda:
       _ Petras
       > Labas Petras
       > Linkiu jums Petras geros dienos
       


//3 uzdavinys
---------------------------------------------------
Parašykite programą kurioje yra vienas metodas priimantis du skaitmeninio tipo argumentus. 
 - Main metode naudotojo paprašome įvesti 2 skaičius ir perduokite juos metodui. 
   N.B. būtina validacija
 - Į ekraną išveskite argumentų matematinę sumą.
 Pvz: 
 > Iveskite pirmą skaičių:
 _ 15
 > Iveskite antrą skaičių:
 _ 16
 > Rezultatas: 31



// 4uzdavinys 
---------------------------------------------------
Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą. 
- Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais 
- Įvestas tekstas metodui perduodamas per parametrus ir grąžina tarpų kiekį 
- Main metode į ekraną išveskite tarpų kiekį
Pvz: 
> Iveskite teksta:
_ 'as mokausi programuoti'
> Tarpu kiekis yra: 2

// uzdavinys nr 5
---------------------------------------------------
 Parašykite programą kurioje vienas metodas. 
 - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
 - Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
    Pvz: 
    > Iveskite teksta:
    _ ' as mokausi      '
    > Teksto ilgis yra: 10

   


// 6 uzduotis   
 ----------------------------------------
 - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais 
 - Įvestas tekstas metodui perduodamas per parametrus ir grąžina žodžių kiekį 
- Main metode į ekraną išveskite žodžių kiekį
   Pvz: 
    > Iveskite teksta:
    _ as mokausi programuoti
     > Zodziu kiekis yra: 3

// 7 uzdavinys
 ---------------------------------------------------
Parašykite programą kurioje vienas metodas. 
- Naudotojo paprašome įvesti betkokį tekstą Main metode. 
- Metodas grąžina tarpų kiekį teksto gale
- Main į ekraną išveda rezultatą
Pvz: 
> Iveskite teksta:
_ ' as mokausi      '
> Gale yra tarpų: 6


// 8 uzdavinys
 --------------------------------------------------
Parašykite programą kurioje vienas metodas. 
- Naudotojo paprašome įvesti betkokį tekstą Main metode. 
- Metodas grąžina tarpų kiekį teksto pradžioje
- Main į ekraną išveda rezultatą
Pvz: 
> Iveskite teksta:
_ ' as mokausi      '
> Pradžioje yra tarpų: 1


// 9 uzdavinys 
---------------------------------------------------
Parašykite programą kurioje vienas metodas. 
- Naudotojo paprašome įvesti betkokį tekstą Main metode. 
- Metodas grąžina dvi reikšmes pirmoji - tarpų kiekį teksto pradžioje, antroji - tarpų kiekį teksto gale
<hint> naudoti out 
- Main į ekraną išveda rezultatą
Pvz: 
> Iveskite teksta:
_ ' as mokausi      '
> Pradžioje yra tarpų: 1
> Gale yra tarpų: 6


// 10 uzdavinys
---------------------------------------------------
 Parašykite programą kurioje yra vienas metodas. 
-Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais
-Įvestas teikstas kaip argumentas perduodamas metodui.Metodas grąžina 'a' raidžių kiekį tekste.
- Main metode į ekraną išveskite metodo darbo rezultatą
Pvz: 
         > Iveskite teksta:
         _ as mokausi programuoti
         > 'a' raidžių kiekis yra: 3
   


 11 A uzdavinys
---------------------------------------------------
  Parašykite programą kurioje vienas metodas. 
    - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
    - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. N.B. grąžinama string, o ne bool.
    -  Išvesti rezultatą Main metode.
    Pvz: 
    > Iveskite teksta:
    _ ' as labai mokausi programuoti     '
    > Ar yra mokausi: Taip
    Pvz: 
    > Iveskite teksta:
    _ ' as_labai_mokausi_programuoti     '
    > Ar yra mokausi: Taip
    Pvz3:  
    > Iveskite teksta:
    _ ' as_labai_MOKAUSI_programuoti     '
    > Ar yra mokausi: Taip  
   


 11 B uzdavinys
---------------------------------------------------
    Parašykite programą kurioje vienas metodas. 
    - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
    - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. 
        Bet tik tuo atveju jei žodis 'mokausi' nesulipęs su kitu žodžiu.
        N.B. grąžinama string, o ne bool.
    -  Išvesti rezultatą Main metode.
    Pvz: 
    > Iveskite teksta:
    _ ' as labai mokausi programuoti     '
    > Ar yra mokausi: Taip
    Pvz2: 
    > Iveskite teksta:
    _ ' as_labai_mokausi_programuoti     '
    > Ar yra mokausi: Ne
    Pvz3: 
    > Iveskite teksta:
    _ 'mokausi programuoti labai    '
    > Ar yra mokausi: Taip
   


// 12 uzdavinys
---------------------------------------------------
 Parašykite programą kurioje yra vienas metodas. 
 - Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais 
 - Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina pirmos 'a' raidės vietą tekste.
 - Main metode į ekraną išveskite metodo darbo rezultatą
 Pvz: 
 > Iveskite teksta:
 _ as mokausi programuoti
 > 'a' raides vieta yra: 0




Namu darbo užduotis būtuL
UŽDUOTIS 11A (sunkense) + testai

 Parašykite programą kurioje vienas metodas. 
    - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
    - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. 
        Bet tik tuo atveju jei žodis 'mokausi' nesulipęs su kitu žodžiu.
        N.B. grąžinama string, o ne bool.
    -  Išvesti rezultatą Main metode.
    Pvz: 
    > Iveskite teksta:
    _ ' as labai mokausi programuoti     '
    > Ar yra mokausi: Taip
 
    Pvz2: 
    > Iveskite teksta:
    _ 'aslabaimokausiprogramuoti'
    > Ar yra mokausi: Ne

    Pvz3: 
    > Iveskite teksta:
    _ 'mokausi programuoti labai    '
    > Ar yra mokausi: Taip  
        
    Pvz4: 
    > Iveskite teksta:
    _ 'as mokausi, labai stipriai'
    > Ar yra mokausi: Taip
    Pvz5: 
    > Iveskite teksta:
    _ 'as mokausi!'
    > Ar yra mokausi: Taip
    Pvz6: 
    > Iveskite teksta:
    _ 'as mokausi?'
    > Ar yra mokausi: Taip
    Pvz7: 
    > Iveskite teksta:
    _ 'as studijuoju (mokausi)'
    > Ar yra mokausi: Taip
    Pvz8: 
    > Iveskite teksta:
    _ 'as studijuojumokausi)'
    > Ar yra mokausi: Ne

*/
#endregion


