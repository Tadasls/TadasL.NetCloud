using P035_DataReading.Domain.Models;
using P035_DataReading.Domain.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P035_DataReading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello HW Data Reading!");
            
            // 1 uzd 
            FileService duomenuFSKlaseApieVartotojus = new FileService(Environment.CurrentDirectory + "\\InitialData\\UserData1.csv"); 
           // Console.WriteLine(" Vartotoju duomenys is CSV Laikenos");
          //  duomenuFSKlaseApieVartotojus.IstrauktiIsCsvLaikmenosDuomenuPavadinimus();
            // SpausdintiVisusVartotojus(duomenuFSKlaseApieVartotojus.VartotojoDuomenuIsCsvSkaitymoMetodas());

            Console.WriteLine();
            //2 uzd
            FileService hoteliuDuomenuFSKlase = new FileService(Environment.CurrentDirectory + "\\InitialData\\HotelData1.csv");
         //   Console.WriteLine(" Viesbuciu duomenys is CSV Laikenos");
         // SpausdintiViesbuciuInfo(hoteliuDuomenuFSKlase.HotelioDuomenuIsCSVNuskaitymas());

            List<User> users = duomenuFSKlaseApieVartotojus.VartotojoDuomenuIsCsvSkaitymoMetodas(); // vart objektas uzpildytas vart duomenimis is laikmenos
            HotelManager owner = new HotelManager(hoteliuDuomenuFSKlase.HotelioDuomenuIsCSVNuskaitymas()); // own objektas yra klase uzpildyta viesb duomenimis is laikmenos
            owner.AllocateUsersToHotels(users);  // own objektas (HM klase uzpildyta viesb duom) uzpildoma metodo pagalba gyventojais/vartotojais(user)
          //  SpausdintiViesbucioSveciuVidutiniAtlyginima(owner); //paleidziu metoda paduodamas jam HM klases objekta (t.y. uzpildytus duomenis)
            Console.WriteLine();

            //3 uzd
            //SpausdintiViesbucioIvertinima(owner); // i metoda padaviau objekta
                       
            Console.WriteLine("Nauji viesbuciai");
              SpausdintiViesbuciuInfo(owner.NewHotels);//spausdina tik naujus viesb nes padaviau nauju viesbuciu sarasas is HM objekto klases propercio
            KiekNaujuoseGyvena(owner);


            // AtspausdintiViesbSveciuSarasus(owner);

        }
     
        //MenVisitors 


        public static void SpausdintiVisusVartotojus(List<User> users)
        {
            foreach (var user in users)
            {
             Console.WriteLine($"{user.Id}. {user.Name} {user.FamilyName} ({user.Gender}) - {user.Email} "  );
            }
        }
        public static void SpausdintiViesbuciuInfo(List<Hotel> hotels)
        {
            Console.WriteLine(" Viesbuciu sarasas: ");
            foreach (var hotel in hotels)
            {
                Console.WriteLine($" " +
                    $" {hotel.Id, - 3}" +
                    $" {hotel.Name, -40}" +
                    $" {hotel.Rating, -2}" +
                    $" {hotel.PostCode,-5}" +
                    $" {hotel.Creation_date.ToString("yyyy-MM-dd"), -10}");         
            }
        }
        public static void SpausdintiViesbucioSveciuVidutiniAtlyginima(HotelManager owner)
        {
            foreach (var hotel in owner.Hotels)
            {
                Console.WriteLine($"Viesbutyje:  {hotel.Name, -40} Vidutine kliento alga - {(int)hotel.AverageClientSalary}");
            }
        }
        public static void KiekNaujuoseGyvena(HotelManager owner)
        {
            foreach (var hotel in owner.NewHotels)
            {
                Console.WriteLine($"Naujame Viesbutyje:  {hotel.Name,-40} Pastatytas metais - {hotel.Creation_date.Year, -6} Gyventoju yra  - {hotel.Gyventojai.Count}");
            }
        }
        public static void SpausdintiViesbucioIvertinima(HotelManager owner)
        {
            foreach (var hotel in owner.Hotels)
            {
                Console.WriteLine($"Viesbutis:  {hotel.Name,-40} Vidutinis Ivertinimas - {hotel.Rating}");
            }
        }
        public static void AtspausdintiViesbSveciuSarasus(HotelManager owner)
        {
            Console.WriteLine($"Gyventoju sarasai: ");
            foreach (var hotel in owner.Hotels)
            {
                Console.WriteLine($" Viesb Name:{hotel.Name} ");
                Console.WriteLine($" Viesb Gyventoju :{hotel.Gyventojai.Count} ");

                foreach (var gyventojas in hotel.Gyventojai)
                {
                    Console.WriteLine($" svecio vardas {gyventojas.Name}");
                }
            }
         }



        /*   Uzduotis 1 – Sukurkite programa, kuri moketu nuskaityti UserData1.csv failą.
           UserData1.csv galite pasiimti iš Teams pamokos Files sekcijos. 
           Atvaizduokite kiekvieno naudotojo duomenis tokiu formatu:
           ”55. Petras Petraitis (Vyras) – petras@petramail.lt”.
           Headeri turetu atspausdinti pirmoje eiluteje.
        PAGALBA: Tam, kad turėtumėt patogų priėjimu visiems duomenims jums reikės susikurti naują <User> klasę.

            Uzduotis 2 – Sukurkite nauja <Hotel> klase, kuri savyje gali laikyti sarasa <User> 
            (Hoteliu data importuokite is HotelData1.csv).
        Sukurkite nauja <HotelManager> klase, kuri savyje laiko sarasa hoteliu.
        Naujai sukurtai klasei <HotelManager> sukurkite metoda [AllocateUsersToHotels(users)], 
        kuris priskirs kiekviena vartotoja atsitiktiniam (Random) hoteliui.
        Sukurkite atskleidziama <Hotel> property, AverageClientSalary, kuris grazintu besilankanciu klientu 
        vidutine sumuota alga. Turi buti Unit Test Coverage.
       
            Uzduotis 3 - Sukurkite isskleista property <HotelManager> AverageRating, kuris grazintu 
        vidutini hoteliu ivertinima + unit test.
        Sukurkite <HotelManager> klasei isskleidziama property NewHotels, kuris grazintu sarasa visu hoteliu,
        kurie buvo pastatyti veliau nei 2010-01-01. 
        Sukurkite <HotelManager> klasei metoda [AllocateUsersToLuxHotels(users)], kuris turetu naudotojus 
        priskirti tik i hotelius, kuriu ivertinimas yra auksciau 3 ir yra NewHotels sarase.
        Sukurkite <Hotel> klasei [MenVisitors] ir [WomenVisitors] isskleidziamus property, kurie turetu 
        grazinti besilankancius vyrus ir moteris individualiai.
         */



    }
}