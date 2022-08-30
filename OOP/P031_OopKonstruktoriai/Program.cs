
namespace P031_OopKonstruktoriai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, OopKonstruktoriai!");

            // KonstruktoriuPaleidimai();

            // var masina = new Masina();

            var zmogus1 = new Zmogus();
            var zmogus2 = new Zmogus("Petras", "Petrauskas", 1990, "Vyras", "Lietuva");
            var zmogus3 = new Zmogus(zmogus2)
            {
                vardas = "Jonas"
            };
            var zmogus4 = new Zmogus(new Zmogus());
            var zmogusArgumentas = new Zmogus();
            var zmogus6 = new Zmogus(zmogusArgumentas);

            var masina1 = new Masina();
            var masina2 = new Masina("Toyota", "Yaris", 2012, true, "Jaroslavas");
            var masina3 = new Masina(masina2)
            {
                Gamintojas = "Audi",
                Modelis = "A4",
                GamybosMetai = 2000
            };

            var ismanusisTelefonas1 = new IsmanusisTelefonas();
            var ismanusisTelefonas2 = new IsmanusisTelefonas(50, 64, 4800, new Dekliukas() { Gamintojas = "Tokai", Kaina = 9.99, Medziaga = "Guminis" })
            {
                Dimensija = "4/3",
                Stiklas = "Grudintas",
                Modelis = "iProdus",
                Rezoliucija = "1080x800"
            };

            var ismanusisTelefonas3 = new IsmanusisTelefonas(ismanusisTelefonas2);

            var dekliukas4 = new Dekliukas() { Gamintojas = "Tokai", Kaina = 9.99, Medziaga = "Guminis"  };
            var ismanusisTelefonas4 = new IsmanusisTelefonas(new IsmanusisTelefonas(50, 64, 4800, dekliukas4));


            var namas1 = new Namas();
            var namas2 = new Namas("Zalia", 3, 50, 7, "kauno g");
            var namas3 = new Namas(namas2)
            {
            Spalva = "Raudona",
            Aukstai = 2,
            Plotas = 42,
            Langai = 8,
            Adresas = "Ziglos g. 1",
            };

            //var knyga1 = new Knyga();
            //var knyga2 = new Knyga("Petras", "Petrauskas", 1990, "Vyras", "Lietuva");
            //var knyga3 = new Knyga(zmogus2)
            //{
            //    vardas = "Jonas"
            //};



            //var prieinamumoPavyzdys = new PrieinamumoPavyzdineKlase("Privati pavarde");
            //prieinamumoPavyzdys.vardas = "Prieinamas";
            //Console.WriteLine($"Vardas: {prieinamumoPavyzdys.vardas}\nPavarde: {prieinamumoPavyzdys.Pavarde}");



           
        }

        /*
         Uzduotis 3: Aprasykite kiekvienai is klasiu aprasytu 1 uzduotyje po 3 konstruktorius
         * */




        public static void KonstruktoriuPaleidimai()
        {
            var klientas1 = new Customer();
            Console.WriteLine($"Kliento 1 vardas: {klientas1.Vardas}"); // Stiuartas
            klientas1.Vardas = "Benas";
            Console.WriteLine($"Kliento 1 vardas: {klientas1.Vardas}"); // Benas

            Customer klientas2 = new Customer
            {
                Vardas = "Ieva"
            };

            var klientas3 = new Customer("Aiste");
            Console.WriteLine($"Kliento 3 vardas: {klientas3.Vardas}"); //aiste

            var masina = new Masina();
        }
    }
}