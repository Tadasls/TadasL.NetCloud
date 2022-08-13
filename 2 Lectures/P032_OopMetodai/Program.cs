using P032_OopMetodai.Domain._7_uzd;
using P032_OopMetodai.Domain.Models;
using System;

namespace P032_OopMetodai
{
    internal class Program
    {
        // Vizualizacija Access Modifiers
        // https://raw.githubusercontent.com/gist/michail-peterlis/67ab9f81f16cd2fb074d8ea9c8008653/raw/1b41929acf1cab64b4cb386966659e079a9edef5/access_modifier.svg

        static void Main(string[] args)
        {

            // Get - Reiksmiu istraukimas
            // Set - Reiksmiu ivedimas
            Console.WriteLine("Hello OOP Metodai!");
            var namas1 = new Namas(5, "Vilniaus g. 78"); // <------ this
            Console.WriteLine($"Yra darzas: {namas1.YraDarzas}");
            //foreach(var namoGyventojoVardas in namas1.ZmoniuVardai)
            //{
            //    Console.WriteLine($"Namo gyventojo vardas: {namoGyventojoVardas}");
            //}




            var profesija1 = new Profesija();
            var profesija2 = new Profesija(2, "Destytojas", "University");
            Profesija profesija3 = new Profesija()
            {
                Tekstas = "Student"
            };
            var profesija4 = new Profesija();
            profesija4.Tekstas = "Student";



            var hobis1 = new Hobis();
            var hobis2 = new Hobis(5, "Žvejyba", "Fishing");
            Hobis hobis3 = new Hobis
            {
                tekstas = "Amatour"
            };



            //var bendrabutis = new Bendrabutis()
            //{
            //    BendrabucioId = 5,
            //    KambariuSkaicius = 9,
            //    Kaina = 49,
            //    Zmones = new List<Zmogus>()
            //{

            //    new Zmogus("Petras"),
            //    new Zmogus("Antanina"),
            //    new Zmogus("Janina"),
            //    new Zmogus("Jonas"),
            //    new Zmogus("Ieva"),
            //}
            //};













        }

        /*
         * Uzduotis 4: Atnaujinti kiekvienai is klasiu aprasytu 1 uzduotyje atributus (kontrakta) taip,
        kad atributu reiksmes galima butu skaityti is isores, bet nustatyti reiksmes butu galima tik klases viduje.
        (Savarankiskai: Namas, salis, knyga)
         */

        /*
         * 
         Uzduotis 5:(Savarankiskai)Sukurti klases Hobis ir Profesija 
Klasės interfeise turi būti properčiai: Id (int), TekstasLietuviskai(string) ir Tekstas(string) 
Sukurti tuscia konstruktorių, kuris inicializuoja duotas reikšmes.
Sukurti konstruktorių, kuris inicializuoja duotas reikšmes.
Kintamieji gali būti tik pasiekiami iš išorės, bet reikšmės gali būti nustatomos tik klasės viduje.
Sukurkite po 3 skirtingus hobius ir profesijas(Panaudoti visus 3 ismoktus deklaravimo ir priskyrimo budus. 
        1. Konstruktoriaus pagalba 
        2. Tuscio objekto sukurimas ir pildymas eigoje
        3. Deklaravimo metu priskirti reiksmes)
         */


        /*    Uzduotis 6: (Savarankiskai) Sukurkite klasę “Bendrabutis”. 
        Klasės kontraktas/interfeisas turėtų turėti šiuos atributus:   
        BendrabucioId    
        KambariuSkaicius    
        Kaina
        Sujunkite/sukomponuokite klases “Zmogus” ir “Bendrabutis” taip,
        kad kiekviename bendrabutyje galėtų gyventi daug žmonių,
        tačiau vienas žmogus galėtų gyventi tik viename bendrabutyje. 
          */

        /*  Uzduotis 7: 
         *  Sukurkite 4 klases – Studentas, Mokykla, Mokytojas, PazymiuKnygele, Pamoka 
         *  ir juos sukomponuokite (Sudekite rysius tarp ju).
            Kiekviena mokykla turi nuo 1 iki begalybes mokytoju.
            Kiekvienas mokytojas turi nuo 1 iki begalybes studentu.
            Kiekvienas studentas turi 1 pažymių knygelę.
            Kiekviena pažymių knygelė turi nuo 1 iki begalybės pamokų, 
        
        kurios turi buti saugomos su studentu pazymiais.
        
        Pamoka turi tik pavadinimą ir nuo 1 iki begalybės priskirtų mokytojų.
            Inicializuokite klases su duomenimis (turi buti maziausiai uzpildytos 2 mokyklos) ir sukurkite 3 metodus,
        kurie atspausdinkite ekrane(Šie metodai turetu priimti tik 1 objekta. Objektai gali buti skirtingi tarp metodu):  
            Mokyklos pavadinima
            Kiekviena mokytoja kartu su jo mokiniu vardais
             (Savarankiskai)Kiekviena mokini kartu su kiekvieno is ju pazymiais 
             (Savarankiskai)Kiekvieno studento kiekvienos pamokos pazymiu vidurki
         * */


        public void AtspausdintiMokykla(Mokykla mokykla)
        {
            Console.WriteLine($"Mokyklos pavadinimas: {mokykla.Pavadinimas}");
            foreach (var mokytojas in mokykla.Mokytojai)
            {
                Console.WriteLine($" mokytojas:{mokytojas.Vardas} ");
                foreach (var mokinys in mokytojas.Studentai)
                {
                    Console.WriteLine($" mokino vardas {mokinys.Vardas}");
                }
            }
        }

        static void AtspausdintiMokiniuVidurkius(Mokykla mokykla)
        {
            foreach (var mokytojas in mokykla.Mokytojai)
            {

                foreach (var mokinys in mokytojas.Studentai)
                {
                    foreach (var pamoka in mokinys.PazymiuKnygele.Pamokos)
                    {

                        Console.WriteLine($" mokinys {mokinys.Vardas} \n  pamoka: {pamoka}  \n  - Vidurkis {pamoka.Value}");
                    }
                }
            }
        }

        static double ApskaiciuotiVidurki(List<int> pazymiai)
        {
            var vidurkis = 0;
            foreach (var pazymys in pazymiai)
            {
                vidurkis += pazymys;
            }

            vidurkis = vidurkis / pazymiai.Count;

            return vidurkis;

        }
    }
}