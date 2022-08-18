using System.Text;
using System;
using System.Collections.Generic;

namespace P022_Foreach
{
    public class Program
    {
        public const int ilgoZodzioIlgis = 5;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Foreach!");

            // PavyzdiniaiForEachkvietimai();
            //PirmasUzdavinys();
            //AntrasKlasesUzdavinys();
            //TreciasKlasesUzdavinys();
            
            // var rezultatas = SurikiuotiSkaiciusIsTeksto(IstrauktiSkaicius("1sd512sd5"));
            // AtspausdintiSkaicius(rezultatas);

            //var rezultatas = IsmetytiZodzius(" Labas as esu Kodelskis ir labai megstu programuoti");2

            KaladesKonstruktorius();


        }
                

        private static void PavyzdiniaiForEachkvietimai()
        {
            int[] taskuMasyvas = new int[10];

            taskuMasyvas[1] = 1;
            foreach (int taskai in taskuMasyvas)
            {
                Console.WriteLine($"{taskai} - naujas elementas");
            }

            string[] masinos = new string[] { "BMW", "Audi", "Skoda", "Toyota" };


            foreach (var masina in masinos)
            {
                Console.WriteLine($"{masina} - naujas elementas");
            }


            List<int> amziai = new List<int> { 19, 20, 21 };
            foreach (var amzius in amziai)
            {
                Console.WriteLine($"Amzius : {amzius}");
            }


            var vardai = new List<string> { "Ieva", "vardenis", "Tomas" };
            foreach (var vardas in vardai)
            {
                Console.WriteLine($"vardas : {vardas}");
            }


            foreach (var amzius in amziai)
            {
                Console.WriteLine($"Amzius : {amzius + 5}");
            }

            foreach (var vardas in vardai)
            {
                foreach (var amzius in amziai)
                {
                    Console.WriteLine($"aVardas {vardas} ir Amzius : {amzius + 5}");
                }
            }

            foreach (var vardas in vardai)
            {
                if (vardas == "vardenis")
                    break;
                Console.WriteLine($"aVardas {vardas} ir Amzius : ");

            }

            string sakinys = "Buso karta erdve ir ji kazkur paklydo";

            foreach (var raide in sakinys)
            {
                if (raide == 'd')
                    break;
                Console.WriteLine(raide);
            }

            var spalvos = new List<string>();
            spalvos.Add("Melyna");
            spalvos.Add("Zalia");
            spalvos.Add("Geltona");

            foreach (var spalva in spalvos)
            {
                Console.WriteLine($"Spalva:{spalva}");
            }
        }

        /*KLASES DARBAS 1. ## Parasykite programa, kuri apskaiciuotu duoto integer saraso vidurki.*/
        public static void PirmasUzdavinys()
        {
            List<double> skaiciai = new List<double>()
            {
                1,5,8,9,8,5
            };
            var rezultatas = ApskaiciuotiVidurki(skaiciai);
            Console.WriteLine($"pirmo uzdavinio Rezultatas {rezultatas}" );
        }
        public static double ApskaiciuotiVidurki(List<double> skaiciai)
        {
            var vidurkis = 0d;
            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine($"Skaicius :{skaicius}. Suma: {vidurkis}");
                vidurkis += skaicius;
            }
            return vidurkis/skaiciai.Count;    
        }

        /* KLASES DARBAS 2. ## Parasykite metoda, kuris grazina ar skaicius neigiamas ar teigiamas masyve. */

        public static void AntrasKlasesUzdavinys() 
        { 
            List<int> skaiciai = new List<int>() { 1, 5, -8, 9, 0, 8, -5 };
            List<string> rezultatas = TikrintiSkaiciausTeigiamuma(skaiciai);
            foreach (string skaiciausTeigiamumas in rezultatas) 
            { 
                Console.WriteLine($"Ar skaicius teigiamas: {skaiciausTeigiamumas}"); 
            } 
        }
        public static List<string> TikrintiSkaiciausTeigiamuma(List<int> skaiciai) 
        { 
            var skaiciuTeigiamumas = new List<string>();
            foreach (var skaicius in skaiciai)
            {
                if (skaicius >= 0) skaiciuTeigiamumas.Add("Teigiamas");
                else skaiciuTeigiamumas.Add("Neigiamas"); 
            } return skaiciuTeigiamumas;
        }


        /* KLASES DARBAS 3. ## Parasykite metoda, kuris apskaiciuos kiek jums reikes sumoketi GPM nuo duoto imoku saraso. Sio uzdavinio GPM: 15% */
        public static void TreciasKlasesUzdavinys()
        {
            int gpm = 15;
            List<double> imokos = new List<double>() { 100, 150, 188,88, 69, 200 };

            var rezultatas = ApskaiciuotiGPM(imokos, gpm);
            Console.WriteLine($"gpm  {rezultatas.ToString("#.##")}");
        }
        public static double ApskaiciuotiGPM(List<double> imokos, int gpm)
        {
            var galutinisMokestis = 0d;

            foreach (var imoka in imokos)
            {
                galutinisMokestis += imoka;
            }
            return galutinisMokestis * (gpm/100d);
        }


        /*    Uzduotis 1 IstrauktiSkaicius
             
         Parašyti metodą IstrauktiSkaicius, kuris priima teksta, bet grazina tik skaicius egzistuojancius paciame tekste.        
          Isgavus teksta programa turetu naudoti naujai sukurta SurikiuotiSkaiciusIsTeksto metoda, kuris priima "string skaiciaiTekste" ir surikiuoja skaicius        
          didejimo tvarka. SurikiuotiSkaiciusIsTeksto privalo panaudoti foreach, kad suformuotumet nauja List<int>:        
         PVZ: Ivedame: 1sd512sd5. Programa be rusiavimo grazina mums: 15125. Programa su rusiavimu grazina mums: 11255        
        */
        
        //PERPANAUDOJAMI METODAI
        public static int SkaiciausTikrinimas(string? tekstas) => int.TryParse(tekstas, out int skaicius) ? skaicius : 0;     

        public static string IstrauktiSkaicius(string tekstas) 
        {
            var skaiciaiTekste = new StringBuilder();
            foreach (var simbolis in tekstas) 
            {
                if (char.IsDigit(simbolis)) skaiciaiTekste.Append(simbolis); 
            } return skaiciaiTekste.ToString(); 
        }
        public static List<int> SurikiuotiSkaiciusIsTeksto(string skaiciaiTekste) 
        {
            var skaiciai = new List<int>();
            foreach (var skaicius in skaiciaiTekste) 
            { 
                skaiciai.Add(SkaiciausTikrinimas(skaicius.ToString())); 
            } 
            skaiciai.Sort();
            return skaiciai;
        }
        public static void AtspausdintiSkaicius(List<int> skaiciai) 
        { 
            foreach (var skaicius in skaiciai) 
            { 
                Console.Write(skaicius.ToString()); 
            }
        }


        // <summary>  uzdavinys nr 2     
        //  Parašyti metodą IsmetytiZodzius, kuris priima sakini, bet grazina nauja zodziu List sudaryta tik is zodziu, kurie ilgesni 
        // nei 5 raides ir yra surikiuoti abeceles tvarka.
        //  Tada parasykite metoda, kuris priima 2 zodziu sarasus, juos sujungia i viena kolekcija naudojant ciklus ir atspausdina ekrane.        
        //  PRIMINIMAS: Kad isskirti string i atskirus zodzius naudokite pavyzdinisString.Split(' ')       
        //  PVZ: Ivedame: "Labas as esu Kodelskis ir labai megstu programuoti".        
        //  Programa be rusiavimo grazina mums: as esu ir Labas Kodelskis labai megstu programuoti        
        //  Programa su rusiavimu grazina mums: as esu ir Kodelskis labai Labas megstu programuoti       
        // </summary>
                
        public static string[] IstrauktiZodzius(string sakinys) => sakinys.Split(' ');
        public static List<string> IsmetytiZodzius(string sakinys)        
        {
            var zodziai = IstrauktiZodzius(sakinys);
            var ilgiZodziai = SurikiuotiZodzius(IsgautiIlgusZodzius(zodziai));
            var trumpiZodziai = IsvalytiIlgusZodzius(zodziai);
            var galutinisSakinys = SujungtiSarasusZodziu(trumpiZodziai, ilgiZodziai);
            return galutinisSakinys;       
        }        
        public static List<string> IsgautiIlgusZodzius(string[] zodziai, int ilgis = ilgoZodzioIlgis)       
        {            var ilgiZodziai = new List<string>();
            foreach(string zodis in zodziai)          
            {  
                if(zodis.Length >= ilgis)             
                    ilgiZodziai.Add(zodis);           
            }            
            return ilgiZodziai;
        } 
        public static List<string> SurikiuotiZodzius(List<string> zodziai)     
        {    
            zodziai.Sort(); 
            return zodziai;      
        }   
        public static List<string> IsvalytiIlgusZodzius(string[] zodziai, int ilgis = ilgoZodzioIlgis)  
        {      
            var trumpiZodziai = new List<string>();
            foreach(var zodis in zodziai)          
            {  
                if(zodis.Length < ilgis)    
                    trumpiZodziai.Add(zodis);        
            }     
            return trumpiZodziai;    
        }   
        public static List<string> SujungtiSarasusZodziu(List<string> trumpiZodziai, List<string> ilgiZodziai)    
        {    
            var sakinioKonstruktorius = new StringBuilder();   
            var zodziai = new List<string>();     
            zodziai.AddRange(trumpiZodziai);      
            zodziai.AddRange(ilgiZodziai);       
            foreach(var zodis in zodziai)        
            {       
                sakinioKonstruktorius.Append(zodis + " ");    
            }    
            Console.WriteLine(sakinioKonstruktorius);    
            return zodziai;     
        }


        /*SukonstruotiKalade    Parašyti metodą (rusis, kortos). 
        Sis metodas turi sukonstruoti kalade is duotu 2 string sarasu.      
        
        ///  Po to parasyti metoda, kuris surikiuoja jusu kalade pagal abeceles tvarka.        
           
        ///  Ir galiausiai parasyti, kad jusu visas kortas atspausdintu ekrane.       
        ///    PRIMINIMAS:        
        ///    Kortu rusys

        "Sirdziu",
        "Bugnu",
        "Vynu",
        "Kryziu",
        *          
        * Kortos         
        *          
        * "Tuzas",
        "Dviake",
        "Triake",
        "Keturake",
        "Penkake",
        "Sesake",
        "Septynake",
        "Astuonake",
        "Devynakės",
        "Desimtake",
        "Valetas",
        "Dama",
        "Karalius",

               PVZ: Isvedimas - Bugnu Tuzas, Bugnu Dviake...Bugnu Dama, Bugnu Karalius... Kryziu Karalius

              */

        public static void KaladesKonstruktorius()
        {
            var rusys = new List<string>()
            {
                "Sirdziu",
                "Bugnu",
                "Vynu",
                "Kryziu",
            };
            var kortos = new List<string>()
            {
                "Tuzas",
                "Dviake",
                "Triake",
                "Keturake",
                "Penkake",
                "Sesake",
                "Septynake",
                "Astuonake",
                "Devynakės",
                "Desimtake",
                "Valetas",
                "Dama",
                "Karalius",
            };

            var kalade = SurikiuotiKalade(SukonstruotiKalade(rusys, kortos));

            AtspausdintiKalade(kalade);
        }
        public static List<string> SukonstruotiKalade(List<string> rusys, List<string> kortos)
        {
            List<string> kalade = new List<string>();

            foreach (string rusis in rusys)
            {
                foreach (string korta in kortos)
                {
                    kalade.Add($"{rusis} {korta}");
                }
            }

            return kalade;
        }
        public static List<string> SurikiuotiKalade(List<string> kalade)
        {
            kalade.Sort();
            return kalade;
        }
        public static void AtspausdintiKalade(List<string> kalade)
        {
            foreach (string korta in kalade)
            {
                Console.WriteLine(korta);
            }
        }











    }
}