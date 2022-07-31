namespace Paskaita_2_consoles_uzduotys
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Tadas!");
             Console.WriteLine("iveskime varda" + Console.ReadLine());
             Console.WriteLine ("    iveskime varda" + (int)Console.ReadKey().KeyChar);


            
            //nuskaityti pirma raide
            Console.WriteLine(" Iveskime savo vardo pirma Raide");
            //isvedimas i ekrana skaitymas is klaviaturos skaitymas antra karta informacijoss kastinimas matematikos suma ir kompociizija
            Console.WriteLine("   Rezultatas yra {0}", (int)Console.ReadKey().KeyChar + (int)Console.ReadKey().KeyChar-48);
            

            //Konkatinacija

             Console.WriteLine(" (1) Pirkti \n (2) Parduoti \n (3) Likuciai");
            // Console.WriteLine("   Koks jusu pasirinkimas ?  \"   \"   : {0}", Console.ReadKey().KeyChar-48);
             Console.WriteLine($"  \" pasirinkimas : {Console.ReadLine()} \" ");

           




            
            //labas su raides naujose eilutese
             Console.WriteLine(" L\n A \n B \n A \n S ");
            Console.WriteLine(" L  A   B    A     S ");
            Console.WriteLine(@" 
            L
            A
            B
            A
            S ");

            Console.WriteLine("L");
            Console.WriteLine("A");
            Console.WriteLine("B");
            Console.WriteLine("A");
            Console.WriteLine("S");

           

            
            Console.WriteLine(" \" Labas \" ");

            Console.WriteLine(" \u0022 Labas \u0022 ");
            Console.WriteLine(" "+ (char)0x22 + "Labas\0022 ");
            



            //Programa kuri nuskaito 2 raide
            Console.WriteLine("Iveskita savo varda  " + Console.ReadLine()[1]); 


           // parasyti programa kury suskaiciuoja 
             Console.WriteLine("Iveskite varda: ");
              Console.WriteLine("  Iveskita savo varda  " + Console.ReadLine()!.Length);
              Console.WriteLine("  jame yra raidziu  " + Console.ReadLine()!.Count());



              Console.WriteLine("Iveskite varda: ");
                Console.WriteLine("  Iveskita savo varda  " + Console.ReadLine());

            // ivedimas 1 tada ivedimas 2 tada isvedama 2 kintamiej
             Console.WriteLine(" [     {0}  /   {1}  ", Console.ReadLine(), Console.ReadLine() );

            //trimis eilutemis zemiau
            Console.WriteLine(" \n  \n \n   {0}  ", Console.ReadLine() );

            
            //paisymas
            Console.WriteLine(@"

                 --****************--
                ----o---------o------
                ----""""""""""""""""".Replace("*", "\""));

            








        }
    }
}