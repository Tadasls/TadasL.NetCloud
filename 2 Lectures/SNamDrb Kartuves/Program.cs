namespace SNamDrb_Kartuves
{
    public class Program
    {
     public static string[] varduMasyvas = new string[] { "Akvile", "Titas", "Tadas", "Kristijonas", "Dainius", "Sauleja", "Mikas", "Merunas", "Augustinas", "Justinas" };
     public static string[] miestuMasyvas = new string[] { "Kaunas", "Vilnius", "Klaipeda", "Mazeikiai", "Šiauliai", "Panevezys", "Alytus", "Marijampole", "Palanga", "Nida" };
     public static string[] valstybiuMasyvas = new string[] { "Lietuva", "Lenkija", "Ukraina", "Rusija", "Vengrija", "Norvegija", "Svedija", "Anglija", "Prancuzija", "Belgija" };
     public static string[] kitasMasyvas = new string[] { "kitkas" };

     public static List<string> varduSarasas = varduMasyvas.ToList(); 
     public static List<string> miestuSarasas = miestuMasyvas.ToList(); 
     public static List<string> valstybiuSarasas = valstybiuMasyvas.ToList();
     public static List<string> kitasSarasas = kitasMasyvas.ToList();

     public static List<char> neatspetosRaides;
     public static List<char> atspetosRaides;
     public static char[] raides;
     public static bool[] rodomos;
     public static string pirmasZodisSpejimui;
     public static string teisingasAtsakymas;


        static void Main(string[] args)
    {
        Console.WriteLine("Hello, Kartuvės!");

            PradinisPasirinkimasTemu();
    }

    public static void PradinisPasirinkimasTemu()
    {
        Console.WriteLine("Pasirenkite vieną iš temų: \n 1) VARDAI, \n 2) LIETUVOS MIESTAI,\n 3) VALSTYBES,\n 4) KITA.");
        int.TryParse(Console.ReadLine(), out int temosPasirinkimas);
            Console.Clear();

        switch (temosPasirinkimas)
        {
            case 1:
                AtsitiktinesSekosPadarymas(varduSarasas);
                break;
            case 2:
                AtsitiktinesSekosPadarymas(miestuSarasas);
                break;
            case 3:
                AtsitiktinesSekosPadarymas(valstybiuSarasas);
                break;
            case 4:
                AtsitiktinesSekosPadarymas(kitasSarasas);
                break;
        }

    }



        public static char[] ToCharArray(string[] strArr)
        {
            string str = string.Join("", strArr);
            return str.ToCharArray();
        }






        public static string AtsitiktinesSekosPadarymas(List<string> sarasas)   //cia reikia grazinti char masyva
    {
      Random random = new Random();
      int index = random.Next(sarasas.Count);
      Console.WriteLine("Atsitiktinis zodis spejimui " + sarasas[index]);
      string pirmasZodisSpejimui = sarasas[index];
             KartuvesPradzia(pirmasZodisSpejimui);
      return pirmasZodisSpejimui;
    }

  
    public static void KartuvesPradzia(string pirmasZodisSpejimui)
    {
        string ivedimas;
        int bandymai = 0;
        int prisijungimoStatusas = 0;


       string teisingasAtsakymas = pirmasZodisSpejimui; 

        do
        {
            Console.WriteLine("Iveskite spėjamą raidę arba spėkite žodį: ");
            ivedimas = Console.ReadLine();
                Console.Clear();
           
            if (ivedimas == teisingasAtsakymas)
            {
                prisijungimoStatusas = 1;
                bandymai = 9;
            }
            else
            {
                
                prisijungimoStatusas = 0;
                bandymai++;

            }
        }
        while ((ivedimas != teisingasAtsakymas) && (bandymai != 9)); // bandymusSkaicius turi buti hangman ilgio
        if (prisijungimoStatusas == 0)
        {
            Console.WriteLine("isnaudoti spejimai zaidimas baigtas");
            Environment.Exit(1);
        }
        else if (prisijungimoStatusas == 1)
        {
            Console.WriteLine($"!!! Sveikinimai !!! \n  Atspėjote žodį !!! \n Zodis buvo {teisingasAtsakymas}");

                

                Console.WriteLine("ar Norite testi? T/N ");
                   string tesimas = Console.ReadLine();
                    if (tesimas == "T")
                     {
                     Console.Clear();
                        PanaudotuZodziuIstrinimas(varduSarasas);
                    PradinisPasirinkimasTemu();
                     } else
                     {
                    Environment.Exit(1);
                     };


        }

           
    }

               


        // public static string deadmanFinal = {$"   O      \|/     0      / \   "};



        public static List<string> PanaudotuZodziuIstrinimas(List<string> sarasas)
        {
            int nIndex = 0;
            for (int i = 0; i < sarasas.Count; i++)
            {
                if (sarasas[i] == teisingasAtsakymas) 
                {
                    sarasas.RemoveAt(nIndex);
                    nIndex = i;

                }
            }
                        
            Console.WriteLine(string.Join(", ", sarasas));
            return sarasas;
        }






        /*  Instructions
- Naudotojas pasirenka iš temų: VARDAI, LIETUVOS MIESTAI, VALSTYBES, KITA. 
  (ne mažiau kaip 10 žodžių kiekvienoje grupėje)
- Žodis iš pasirinktos grupės parenkamas atsitiktine tvarka.
- Užtikrinti kad nebūtu duodamas tas pat žodis daugiau kaip 1 kartą per žaidimą
- Užtikrinti, kad programą nenulūžtu jei vartotojas įveda ne tai ko prašoma
- Ėjimas skaitomas tik jei spėjama dar nespėta raidė
- Jei spėjamas visas žodis ir neatspėjama - iškarto pralaimima
- Parodoma atspėtos raidės vieta žodyje
- Parodomos spėtos, bet neatspėtos raidės

Apribojimai:
- Žodžius saugoti masyvuose  arba žodyne.
- Kodą skaidyti į metodus.
- negalima naudoti OOP ir LINQ

        */

        /*  Instructions

- Užtikrinti kad nebūtu duodamas tas pat žodis daugiau kaip 1 kartą per žaidimą

- Užtikrinti, kad programą nenulūžtu jei vartotojas įveda ne tai ko prašoma
- Ėjimas skaitomas tik jei spėjama dar nespėta raidė
- Jei spėjamas visas žodis ir neatspėjama - iškarto pralaimima
- Parodoma atspėtos raidės vieta žodyje
- Parodomos spėtos, bet neatspėtos raidės

Apribojimai:
- negalima naudoti OOP ir LINQ

*/


    }
}