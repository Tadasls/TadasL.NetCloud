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
                Budas = "Zaismingas",
                GimimoMetai = 2021,
                Rusis = "Suo",
                Vardas = "Bapsis"
            };


            Console.WriteLine($"Informacija apie {zmogus.vardas} zmogaus augintini:\n---------------------\nVardas: {zmogus.augintinis.Vardas}\nRusis: {zmogus.augintinis.Rusis}\nGimimo metai: {zmogus.augintinis.GimimoMetai}\nBudas: {zmogus.augintinis.Budas}");

            Zmogus zmogus2 = new Zmogus();
            zmogus.akiuSpalva = "Melyna";
            zmogus.vardas = "Ricardas";
            zmogus.pavarde = "Gyras";
            zmogus.pareigos = "Aktorius";
            zmogus.megstamiausiasHobis = "Keliones";

            Console.WriteLine($"zmogus.akiuSpalva:{zmogus.akiuSpalva}\nzmogus.vardas:{zmogus.vardas}\nzmogus.pavarde:{zmogus.pavarde}\nzmogus.pareigos:{zmogus.pareigos}\nzmogus.megstamiausiasHobis:{zmogus.megstamiausiasHobis}");

            var masina = new Masina()
            {
                Modelis = "Corolla",
                Gamintojas = "Toyota",
                ArDrausta = true,
                DidziausiasGreitis = 180,
                EmisijuKiekis = 0,
                KedziuKiekis = 4,
                Spalva = "Raudona",
                VariklioTipas = "Elektrinis",
                ApsaugosSistema = new ApsaugosSistema()
                {
                    Gamintojas = "SecurCo",
                    Lygis = 9,
                    Pavadinimas = "ProSecure",
                    Rusis = "Blokuojanti, garsine"
                }
            };


            var masinos = new List<Masina>()
            {
                new Masina(),
                new Masina(),
                new Masina(),
                new Masina(),
                new Masina()
            };

            Console.WriteLine($"Modelis:{masina.Modelis}\nmasina.Gamintojas:{masina.Gamintojas}\nmasina.DidziausiasGreitis:{masina.DidziausiasGreitis}\nmasina.Spalva:{masina.Spalva}\n------------------------\nSaugos sistema:\nPavadinimas: {masina.ApsaugosSistema.Pavadinimas}\nGamintojas: {masina.ApsaugosSistema.Gamintojas}");

            var ismaniejiTelefonai = new Dictionary<int, IsmanusisTelefonas>();

            var samsung = new IsmanusisTelefonas()
            {
                OperacineSistema = "Android",
                Gamintojas = "Samsung",
                Modelis = "Galaxy S22",
                Dekliukas = new Dekliukas()
            };

            samsung.Dekliukas.Gamintojas = "NewCore";
            samsung.Dekliukas.Medziaga = "Guminis";
            samsung.Dekliukas.Kaina = 9.99;

            var iPhone = new IsmanusisTelefonas();

            ismaniejiTelefonai.Add(1, samsung);
            ismaniejiTelefonai.Add(2, iPhone);

            Console.WriteLine(ismaniejiTelefonai[1].Dekliukas.Gamintojas);
            Console.WriteLine(ismaniejiTelefonai[1].Dekliukas.Medziaga);
            Console.WriteLine(ismaniejiTelefonai[1].Dekliukas.Kaina + "$");



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
                Paveiksliukai = new Paveiksliukai()
                {
                    Autorius = "Mikelandzelas",
                    Spalvos = 6,
                    Pavadinimas = "Venera",
                    Dydis = "5px",

                }




            };
            var gimtiNamai = new Namas()
            {
                Spalva = "balta",
                Aukstai = 2,
                Plotas = 88,
                Langai = 5,
                Adresas = "ziglos g",
                KvadraturaGyvenama = 55,
                Garazas = new Garazas()
                {
                    Spalva ="red",
                    Aukstis = 6,
                    Talpa = 10,
                }
            };
        }

        /*  Namų darbas savaitgaliui.

         Susikurti “Kambarys” klasę ir aprašyti bent 10 objektų esančių jūsų kambaryje
        arba objektų kurie galėtų egzistuoti kambaryje kaip klases.
        Visos naujais aprašytos klasės turėtų turėti bent po 5 atributus 
        (Kontraktas/interfeisas) ir turėtų būti priskirtos kaip properties(savybe)
        “Kambarys” klasei.Bent 2 iš aprašytų klasių turėtų turėti kompoziciją su kitomis klasėmis
        pvz:”Kambarys” turi “Spinta”, kuri gali turėti List<Drabuzis>

        */



        /*        Uzduotis 2: 
            Parasyti kiekvienai is klasiu bent po 1 kompozicijos atributa
            (Naujas atributas turetu buti naujai sukurta klase su bent 3 naujais atributais).
            Kompozicijos atributas yra atributas su kitos klases duomenu tipu kintamuosiuose.
            Pvz: Zmogus gali tureti augintini
        */



        /*         Uzduotis 1: Apsirašykite klases, kurios atributų pagalba apibūdintų:
        Žmogų++
        Mašiną+
        Namą(Savarankiskai)
        Išmanųjį telefoną+
        Šalį(Savarankiskai)
        Knygą(Savarankiskai)
          */



        class PavyzdineKlase
        {
            // Kontraktas/intefeisas - Visi public dalykai esantys klaseje
            #region Atributai - Sudaroma is fields ir properties
            public string vardas; // Laukas/Field. Vadinsime fieldais.
            public string pavarde;

            public string PilnasVardas
            {
                get { return vardas + " " + pavarde; }
            }

            //public int Taskai { get; set; } // Savybe/Property. Vadinsime properciais.

            private int taskai;

            public int Taskai
            {
                get { return taskai; } // Duomenu/reiksmes isgavimui. Galima delioti skirtinga logikos seka.
                set { taskai = value + 100; } // Duomenu/reiksmes nustatymui. Galima delioti skirtinga logikos seka.
            }
            #endregion


        }

         
    }
}