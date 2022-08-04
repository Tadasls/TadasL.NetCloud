namespace P030_OopKompozicija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, OOP Kompozicija!");

            //var pavyzdineKlase = new PavyzdineKlase();
            //pavyzdineKlase.vardas = "Testas";
            //pavyzdineKlase.Taskai = 10; // value = 10;

            //    Console.WriteLine(pavyzdineKlase.vardas);
            //Console.WriteLine(pavyzdineKlase.Taskai);

            DirbtiSuPirmaUzduotimi();

        }

        //instancija yra naujas sukurtas objektas
        //instance == object

        public static void DirbtiSuPirmaUzduotimi()
        {
            Zmogus zmogus = new Zmogus();
            zmogus.akiuSpalva = "Melyna";
            zmogus.vardas = "Ricardas";
            zmogus.pavarde = "Gyras";
            zmogus.pareigos = "Aktorius";
            zmogus.megstamiausiasHobis = "Keliones";
            zmogus.augintinis = new Augintinis()
            {
                Budas = "zaismingas",
                GimimoMetai = 2021,
                Vardas = "Babsis",
            };

            Console.WriteLine($"informacija apie {zmogus.vardas}\n amogaus augitinis{zmogus.augintinis.Vardas}" );

            Zmogus zmogus2 = new Zmogus();
            zmogus.akiuSpalva = "Melyna";
            zmogus.vardas = "Ricardas";
            zmogus.pavarde = "Gyras";
            zmogus.pareigos = "Aktorius";
            zmogus.megstamiausiasHobis = "Keliones";

            Console.WriteLine($"zmogaus megstamiausias Hobis  { zmogus.megstamiausiasHobis} \n  vardas {zmogus.vardas}  \n ");

            var masina = new Masina()
            {
                Modelis = "Colora",
                Gamintojas = "Toyota",
                arDrausta = true,
                VariklioGalia = 150,
                DidziausiasGreitis = 200,
                Spalva = "zalia",

                ApsaugosSistema = new Apsaugossistema()
                {
                    Gamintojas = "secure",
                    Lygis = 9,
                    Pavadinimas = "pro",
                    //Rusis = "Blokojantis",
                }

            };


            var masinos = new List<Masina>()
            {
                new Masina() { },  // galima apsirasyti masinas 
                 new Masina(),
                  new Masina(),
                   new Masina(),
                    new Masina(),

            };

            Console.WriteLine($"modelis  {masina.Modelis} \n spalva {masina.Spalva} \n didziasias greitis {masina.DidziausiasGreitis}  ");
            Console.WriteLine($"modelis  {masina.Modelis} \n spalva {masina.Spalva} \n didziasias greitis {masina.DidziausiasGreitis}  ");
            var ismaniejiTelefonai = new Dictionary<int, Telefonas>();
            var samsung = new Telefonas()
            {
                OperacineSistema = "Android",
                Gamintojas = "Samsung",
                Modelis ="Galaxy",
                Dekliukas = new Dekliukas()

            };
            samsung.Dekliukas.Gamintojas = "NewCore";
            //samsung.Dekliukas.Medziaga = "guminis";
            samsung.Dekliukas.Kaina = 9.99;

            var iPhone = new Telefonas();

            ismaniejiTelefonai.Add(1, samsung);
            ismaniejiTelefonai.Add(2, iPhone);

            Console.WriteLine(ismaniejiTelefonai[1].Dekliukas.Gamintojas);
           // Console.WriteLine(ismaniejiTelefonai[1].Dekliukas.Medziaga);
            Console.WriteLine(ismaniejiTelefonai[1].Dekliukas.Kaina);



            var knyga = new Knyga()
            {
                Leidejas = "Alma Litera",
                Pavadinimas = "LOR",
                PuslapiuSkaicius = 500,
                ArVaikamsSkirta = false,
                ArSpalvota = true,
                Autorius = "tolkien",
                Kaina = 9.99,
                Svoris = 1.1,

            };




        }



        /*

        Uzduotis 2: 
            Parasyti kiekvienai is klasiu bent po 1 kompozicijos atributa
            (Naujas atributas turetu buti naujai sukurta klase su bent 3 naujais atributais).
            Kompozicijos atributas yra atributas su kitos klases duomenu tipu kintamuosiuose.
            Pvz: Zmogus gali tureti augintini
        */



        /*
         Uzduotis 1: Apsirašykite klases, kurios atributų pagalba apibūdintų:
        Žmogų++
        Mašiną+
        Namą(Savarankiskai)
        Išmanųjį telefoną+
        Šalį(Savarankiskai)
        Knygą(Savarankiskai)
          */



        class PavyzdineKlase
        {
            //kontraktas/interfeisas - Visi public dalykai esantys klaseje. 
            public string vardas;  // laukas /field vadinsime fieldais
            public string pavarde; // fieldas verte reikme

            public string PilnasVardas
            {
                get { return vardas + " " + pavarde; }  // properties
            }

            #region Atributai - sudaroma is fields ir properties
            //public int Taskai { get; set; } // savybe/property vadisime properciais 
            private int taskai;

            public int Taskai
            {
                get { return taskai; }  //duomenu reikesmes isgavimui galima delioti skritinga logiks seka
                set { taskai = value; } // steris duomenu reikems nustatymui galima delioti skirtinga seka
            }
            #endregion


        }


    }
}