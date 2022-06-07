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

            kintamasis = "tekstas belenkoks";
            Console.WriteLine(kintamasis);
                
        }
    }
}