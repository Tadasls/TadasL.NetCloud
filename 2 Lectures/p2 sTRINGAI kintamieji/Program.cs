namespace p2_sTRINGAI_kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String, tai yra kintamieji");
         
            string kintamasis = "Hello world";
            Console.WriteLine(kintamasis);


            var stringKintamasis = "belekoks tekstas";
            string tuscias = "";   // tuscias empty
            string nulas = null;    // nera lygus nieko nera null
            string laisvaErdve = "          "; // white space

            string tekstas = "sfkfknfsjnfskjsfnnsfn lanfsn kfnslkfes fnlkf 1 milijardas simboliu ";

            string konkatinacija = stringKintamasis + kintamasis;
            //konkatinacija
            string kompozicija = string.Format("{0}", stringKintamasis);
            string interpoliacija = $"{stringKintamasis}";
            Console.WriteLine(konkatinacija);
            Console.WriteLine(kompozicija);
            Console.WriteLine(interpoliacija);



            kintamasis = "tekstas belenkoks";
            Console.WriteLine(kintamasis);

            
            /*
            //Taisyklė 1. Kiekvienas kintamasis turi prasidėti mažaja (a-z) arba didžiaja (A-Z) raide arba underscore (_)
            string kintamasis = "1";
            string Kintamasis = "1";
            string _kintamasis = "1";
            //Taisyklė 2. Kintamojo pavadinimas turi aprašyti tai kas jis yra (nurodyti savo paskirtį) 
            string score = "1"; //bet ne s
            string playerScore = "1"; //bet ne ps
            //Taisyklė 3. Trumpinimų ar raidžių pametinėjimų reikėtu vengti. 
            string playerName = "Jonas"; //bet ne plrnm
            //Taisyklė 4. Prefiksų ir postfiksų reikėtu vengti pvz player bet ne strPlayer.
            string player = "Jonas"; //bet ne strPlayer
            //Taisyklė 5. Geriau ilgesni ir aiškesni kintamieji nei raidžių taupymas. Nebijokite ilgų kinamųjų.
            string kaipAsSiandienJauciuosi = "Gerai"; //bet ne savijauta
            //Taisyklė 6. jei kintamasis baigiasi skaičiu, tikriausiai jums reikia geresnio pavadinimos
            int counterOfPeople = 1; //ne counter1
            int counterOfPotatoes = 1; //ir ne counter2
            //Taisyklė 7. Žodžiai “data”, “text”, “number”, and “item” paprastai nieko nereiškia
            string text = "mano šiandienos mintys";
            //Taisyklė 8.  kintamiesiems naudojam žodžių atskyrimą. 
            int PascalCaseKintamasis = 1;
            int camelCaseKintamasis = 1;
            int snake_case = 1;
            //int kebab-case = 1; //Taip negalima

            */







        }
    }
}