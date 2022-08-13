using P033_OopMetodai.Domain;
using P033_OopMetodai.Domain.Models; // Atkreipkite demesi koks namespace yra jusu Program.Main ir koks namespace yra tarp jusu naudojamu Klasiu
using System;
using System.Collections.Generic;

namespace P033_OopMetodai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello OOP Metodai!");
            //OopKartojimoSestaUzduotis();
            //var plotas = ApskaiciuotiPlota(10, 10);

            // paskaitoje

            // StaciakampioSkaiciavimas();
            // GyvunuKalbejimas();

            //namu darbai

            Skaiciuoklis(); //2 uzd  neveikia resetas !!!!!!!!
            // ProduktoMetodas(); // 3uzd
            // SkaiciuVidurkioSkaiciavimai(); // 4 uzd


        }

        private static void SkaiciuVidurkioSkaiciavimai()
        {
            var skaiciuEile = new SkaiciuKrepselis();
            skaiciuEile.PridėtiSkaiciu(1);
            skaiciuEile.PridėtiSkaiciu(3);
            skaiciuEile.PridėtiSkaiciu(7);
            skaiciuEile.PridėtiSkaiciu(2);
            skaiciuEile.PridėtiSkaiciu(2);
            Console.WriteLine($"skaiciu vidurkis : {skaiciuEile.ApskaiciuotiVidurki()}");
        }

        public static void ProduktoMetodas()
        {
            var produktas = new Produktas(1.50, 3, "Kivis");
            produktas.SpausdintiProdukta();
        }

        private static void StaciakampioSkaiciavimas()
        {
            var staciakampis1 = new Staciakampis(5, 5);

            Console.WriteLine($"Staciakampio 1 plotas yra: {staciakampis1.ApskaiciuotiPlota()}");
            staciakampis1.PakeistiIlgi(8);
            Console.WriteLine($"Staciakampio 1 plotas yra: {staciakampis1.ApskaiciuotiPlota()}");
        }

        private static void Skaiciuoklis()
        {
            var skaicius = new Skaiciuoklis(5);
            skaicius.Atspausdinti();
            skaicius.Didinti();
            skaicius.Didinti();
            skaicius.Atspausdinti();
            skaicius.Mazinti();
            skaicius.Mazinti();
            skaicius.Mazinti();
            skaicius.Mazinti();
            skaicius.Atspausdinti();
            skaicius.Perkrauti();
            skaicius.Atspausdinti();         
            skaicius.Atspausdinti();
            skaicius.Didinti();
            skaicius.Atspausdinti();
            skaicius.Mazinti();
            skaicius.Mazinti();
            skaicius.Mazinti();
            skaicius.Mazinti();
            skaicius.Mazinti();
            skaicius.Mazinti();
            skaicius.Mazinti();
            skaicius.Mazinti();
            skaicius.Mazinti();
            skaicius.Mazinti();
            skaicius.Mazinti();
            skaicius.Didinti();
            skaicius.Atspausdinti();
            skaicius.Perkrauti();
            skaicius.Atspausdinti();
            skaicius.Mazinti();
            skaicius.Atspausdinti();
        }

        private static void GyvunuKalbejimas()
        {
            var sunsKalbejimas = new Kalbejimas("Au");
            var katesKalbejimas = new Kalbejimas("Miau");
            var pauksciukoKalbejimas = new Kalbejimas("Cip cip");

            sunsKalbejimas.Kalbeti();
            katesKalbejimas.Kalbeti();
            pauksciukoKalbejimas.Kalbeti();
        }

        private static void OopKartojimoSestaUzduotis()
        {
            var gyventojai = new List<Zmogus>()
            {
                new Zmogus("Petras"),
                new Zmogus("Ieva"),
                new Zmogus("Jonas"),
            };

            var bendrabutis2 = new Bendrabutis(3);

            var gyventojoPavyzdys = new Zmogus(new Bendrabutis(2));
            var zmogus3 = new Zmogus("Benas", bendrabutis2);
            var zmogus4 = new Zmogus("Piteris", bendrabutis2);
            var zmogus5 = new Zmogus("Aiste", bendrabutis2);

            foreach (var bendrabutis2Gyventojas in zmogus3.GyvenamojiVieta.Gyventojai)
            {
                Console.WriteLine($"Gyventojas {bendrabutis2Gyventojas.Vardas} gyvena {bendrabutis2Gyventojas.GyvenamojiVieta.BendrabucioId} bendrabutyje");
            }

            // Mes inicializuojame bendrabuti naudodami konstruktoriu, kuris priima gyventoju <Zmogus> sarasa.
            // Tam, kad kiekvienam gyventojui priskirti naujai sukurta bendrabuti, mes naudojame zodi "this"
            // tam, kad galetume referuoti pati bendrabuti kiekvieno "gyventojo" viduje
            var bendrabutis = new Bendrabutis(gyventojai) // <----- this (new Bendrabutis)
            {
                BendrabucioId = 1,
                Kaina = 200,
                KambariuSkaicius = 50
            };

            foreach (var gyventojas in bendrabutis.Gyventojai)
            {
                Console.WriteLine($"Gyventojas {gyventojas.Vardas} gyvena bendrabutyje identifikaciniu numeriu: {gyventojas.GyvenamojiVieta.BendrabucioId}");
            }
        }

        //static double ApskaiciuotiPlota(double ilgis, double plotis) // Statinis Program Main metodas
        //{
        //    return ilgis * plotis;
        //}

        /*
         * 1.	OopMetodai – Parasykite klase Kalbejimas, kuri turetu string „garsas“ konstruktoriu 
         *  ir turetu metoda „Kalbeti“, kuri i ekrana isvestu musu "garsas"
         *  
         *  2.	Parasykite klase „Skaiciuoklis“, kuris turetu 1 private property pavadinimu Skaicius ir 3 metodus: Didinti (Padidina Skaicius 1), Mazinti(Sumazina Skaicius 1), Atspausdinti()
            a.	Padarykite, kad Mazinti() metodas negaletu sumazinti <Skaicius> maziau 0
            b.	Sukurkite metoda Perkrauti() <Reset>, kuris turetu grazinti <Skaicius> i pradine busena (Perkrauti metodas turetu nepriimti jokiu parametru)
         */

        /* namu darbai
        2.    Parasykite klase „Skaiciuoklis“, kuris turetu 1 private property pavadinimu Skaicius ir 3 metodus: Didinti(Padidina Skaicius 1), Mazinti(Sumazina Skaicius 1), Atspausdinti()
            a.Padarykite, kad Mazinti() metodas negaletu sumazinti<Skaicius> maziau 0
            b.Sukurkite metoda Perkrauti() <Reset>, kuris turetu grazinti<Skaicius> i pradine busena(Perkrauti metodas turetu nepriimti jokiu parametru)

        3. Sukurkite „Produktas“ klase, kuri turetu 3 properties su pasleptais seteriais – Kaina, kiekis, pavadinimas.Sukurkite
         „Produktas“ metoda void SpausdintiProdukta(), kuris atspausdintu informacija apie produkta tokiu formatu „Kivis kaina 1,50$: 3 vnt“

        4. Pasirašyti klasę<SkaiciuKrepselis>, kuris turėtų <private List<int>> skaiciu sarasa.Skaiciu sąrašui užpildyti sukurkite naują metodą<void PridėtiSkaiciu(int skaicius)>. Taip pat sukurkite
         naują metodą<double ApskaiciuotiVidurki()>, kuris apskaiciuoja visu sarase esanciu skaiciu vidurki.

        5. Parašyti po 1 metoda kiekvienai iš jūsų <Kambarys> namų darbo klasei (~12 klasių). Stenkitės pasipraktuokuoti skirtingus gražinimo duomenų tipus ir gal net vienam ar kitam metodui pridėkite po kokį nors parametrą.Papildomai galite ~6 klasėms sukurti po konstruktorių, kuris kelis jūsų pasirinktus<private set> properties(Siuo metu visi yra public) inicijuotų per kontruktoriu paduotas reiksmes.

      */

    }
}