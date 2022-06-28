namespace P10_Metodai
{
    public class Program
    {
        // klaseje turi buti metodai 


         static string Tekstas = " ";




        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Methods!");
            // metodai neturetu buti metode, o turi buti klaseje

            
            
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

            
            
            
            

            // uzdavinys nr 1

            UserioVardoIvedimas();

            // uzdavinys nr 2

            AntrasMetodas();

            //uzdavinys nr 3
            
            /*
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
           */

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
 

            // 4uzdavinys 
           /*---------------------------------------------------
    Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą. 
    - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais 
    - Įvestas tekstas metodui perduodamas per parametrus ir grąžina tarpų kiekį 
    - Main metode į ekraną išveskite tarpų kiekį
    Pvz: 
    > Iveskite teksta:
    _ 'as mokausi programuoti'
    > Tarpu kiekis yra: 2
    */
           
            IvedimoMedotas();


            // uzdavinys nr 5
            /*---------------------------------------------------
       Parašykite programą kurioje vienas metodas. 
       - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
       - Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
          Pvz: 
          > Iveskite teksta:
          _ ' as mokausi      '
          > Teksto ilgis yra: 10
       */

            
            IlgioSkaiciavimoMetodas();
          

            /*
             6 uzduotis   
     
             - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais 
             - Įvestas tekstas metodui perduodamas per parametrus ir grąžina žodžių kiekį 
             - Main metode į ekraną išveskite žodžių kiekį
             Pvz: 
              > Iveskite teksta:
              _ as mokausi programuoti
              > Zodziu kiekis yra: 3
            */
         
            //uzdavinys nr 6
            Console.WriteLine("6 Uzd įvesti betkokį tekstą su tarpais");
            Console.WriteLine($"zodziu skaicius yra {KiekYraZodziu(Console.ReadLine())}");



            /*---------------------------------------------------
    Parašykite programą kurioje vienas metodas. 
    - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
    - Metodas grąžina tarpų kiekį teksto gale
    - Main į ekraną išveda rezultatą
    Pvz: 
    > Iveskite teksta:
    _ ' as mokausi      '
    > Gale yra tarpų: 6
    */
            // uzdavinys nr 7
            int uzdavinys7 = VienasMetodasTekstoPabaigojeTarpai();
            Console.WriteLine($"tarpu gale buvo = {uzdavinys7}");


            /*---------------------------------------------------
     Parašykite programą kurioje vienas metodas. 
     - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
     - Metodas grąžina tarpų kiekį teksto pradžioje
     - Main į ekraną išveda rezultatą
     Pvz: 
     > Iveskite teksta:
     _ ' as mokausi      '
     > Pradžioje yra tarpų: 1
     */

            // uzdavinys nr 8
            int uzdavinys8 = VienasMetodasTekstoPradzioje();
            Console.WriteLine($"tarpu pradzioje buvo = {uzdavinys8}");


            /*---------------------------------------------------
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
   */
            /*
            // uzdavinys nr 9 
            Console.WriteLine("ivesk teksta");
            Console.WriteLine($" kiek tarpu priekyje {KiekYraTarpuPriekyjeIrGale(Console.ReadLine(), out int tarpaiGale)} ");
            Console.WriteLine($" kiek tarpu gale {tarpaiGale} ");
            */


           /* Parašykite programą kurioje yra vienas metodas. 
            -Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais
            -Įvestas teikstas kaip argumentas perduodamas metodui.Metodas grąžina 'a' raidžių kiekį tekste.
            - Main metode į ekraną išveskite metodo darbo rezultatą
            Pvz: 
               > Iveskite teksta:
               _ as mokausi programuoti
               > 'a' raidžių kiekis yra: 3
           */

            // uzdavinys nr 10
            Console.WriteLine("paprašome įvesti betkokį tekstą su tarpais");
            Console.WriteLine($" kiek yra A raidziu skaicius {KiekYraARaidziuTekste("kazkoks tekstas")}");



        }



        public static int KiekYraARaidziuTekste(string? ilgasTekstas)  // 10 uzdavinio metodas
        {
            string pilnasTekstas = Console.ReadLine();
            string naujasTekstas = pilnasTekstas.Replace("a", "").Length; 
            return pilnasTekstas.Length  - naujasTekstas.Length;
        

        }
            

        public static string UserioVardoIvedimas()  // pirmas uzdavinys
        {
            Console.WriteLine($"Iveskite savo Varda: ");
            var vardas = Console.ReadLine();
            Console.WriteLine($"Labas, {vardas}");
            return vardas;
        }

        public static void AntrasMetodas()  // antras uzdavinys paleidzia pirmo uzdavinio metoda
        {
        Console.WriteLine($"Labas tai kas ivesta, {UserioVardoIvedimas()}");
        Console.WriteLine($"Linkiu Jums {UserioVardoIvedimas()} geros dienos");
        }
       
        // trecio uzdavinio metodo vieta


        public static void IvedimoMedotas()  // 4 uzdavinio metodas
        {
            Console.WriteLine("iveskite bet koky teksta su tarpais ");
            string kazkoksTekstas = Console.ReadLine();
            Console.WriteLine($"Tekste tarpu yra {TarpuMetodas(kazkoksTekstas)} ");
        }

        public static void IlgioSkaiciavimoMetodas() // 5 uzdavinio metodas
        {
            Console.WriteLine("iveskite bet koky teksta  ");
            string kazkoksIvestasTekstas = Console.ReadLine();
            Console.WriteLine($"  teksto ilgis yra {kazkoksIvestasTekstas.Length}");
            Console.WriteLine($"({kazkoksIvestasTekstas.Trim()}).");
        }

        public static int KiekYraZodziu(string tekstas)    // 6 uzdavinio metodas
        {
            //return tekstas.Trim().Length - tekstas.Replace(" ", "").Length + 1;
            return tekstas.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }


        public static int VienasMetodasTekstoPabaigojeTarpai() // 7 uzdavinio metodas
        {
            Console.WriteLine("iveskite bet koky teksta  ");
            string betkoksTekstas = Console.ReadLine();

            string sutrumpintasTekstas = betkoksTekstas.TrimEnd();
            int skirtumasPab = betkoksTekstas.Length - sutrumpintasTekstas.Length;

            return skirtumasPab;
        }

        public static int VienasMetodasTekstoPradzioje() // 8 uzdavinio metodas
        {
            Console.WriteLine("iveskite bet koky teksta  ");
            string betkoksTekstas = Console.ReadLine();

            string sutrumpintasTekstas = betkoksTekstas.TrimStart();
            int skirtumasStart = betkoksTekstas.Length - sutrumpintasTekstas.Length;

            return skirtumasStart;
        }

        public static void KiekYraTarpuPriekyjeIrGale(string tekstas, out int priekyje, out int gale)// 9 uzdavinio metodas
        {
            priekyje = tekstas.Length - tekstas.TrimStart().Length;
            gale = tekstas.Length - tekstas.TrimEnd().Length;
        }





        //teorijos metodai


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
            Console.WriteLine("Tu esi kietas");
        }




    }
}