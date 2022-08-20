using P035_DataReading.Domain.Models;
using P035_DataReading.Domain.Services;
using P035_DataReading_Apsirasymas.InitalData;
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
            Console.WriteLine("Hello Data Reading!");
            string path = Environment.CurrentDirectory;
            SakninioFolderioSuradimas(path);
            //SkaitymasIsTxtFailoEilutemisAtskiraiSuUsing();
            FileService animalFileService = new FileService(Environment.CurrentDirectory + "\\InitialData\\AnimalData.txt");
            List<Animal> animals = animalFileService.FetchAnimalTxtRecords();
            animalFileService.ReadStreamSymbolsFromFile();


            FileService basicUserFileService = new FileService(Environment.CurrentDirectory + "\\InitialData\\UserFirstNameBaseData1.csv");
            Console.WriteLine(basicUserFileService.ExtractBasicUserCsvHeaders());
            PrintAllBasicUsers(basicUserFileService.FetchBasicUserCsvRecords());


        }


        public static void PrintAllBasicUsers(List<User> basicUsers)
        {
            foreach (var user in basicUsers)
            {
                Console.WriteLine($" {user.Id}  {user.Name} ");
            }
        }
     
            



        /*      Sukurkite klasę Society
          1- Sukurkite propertį People (List of persons) +
          2- sukurkite metodą FillPeople kuris užpildys People sąrašą iš klasės PersonInitialData. +
          3- Sukurkite propertį OldPeople (List of persons). Grąžinkite visus asmenis iš People kurie gimė prieš 2001m. (unit-test) +
          4- Sukurkite properčius Men (List of persons)  ir Women (List of persons) . +
          5- Sukurkite metodus FillMen ir FillWomen, kurie iš PersonInitialData surašys vyrus ir moteris (unit-test)
          6- sukurkite metodą SortByAge(), kuris Men ir Women sąrašuose esančius asmenis surikiuotu pagal amžių nuo jauniausio iki vyriausio. (unit-test) +
          7- Padarykite metodą kuris People, Men ir Women properčiuose esančius asmenis  rikiuos nuo A iki Z arba nuo Z iki A.  (unit-test)
             Pagal Vardą arba Pavardę
             tokiu principu: SortByFirstName().Asc()
                             SortByLastName().Desc()
            <hint> return this
         */
        static void PirmasEnumUzdavinys()
        {
            Society society = new Society();
            society.FillPeople(PersonInitialData.DataSeed.ToList());

            foreach (Person person in society.People)
            {
                Console.WriteLine($"Vardas: {person.FirstName}");
            }
        }

        #region KARTOJIMAS
        static void SakninioFolderioSuradimas(string path)
        {
            //string rootDirectoryPath = new DirectoryInfo(path).Parent.Parent.FullName;
            Console.WriteLine($"Sakninis katalogas yra {path}");
        }

        public static void SkaitymasIsIvesties()
        {
            int userColumnCount = 2;
            Console.WriteLine("Suveskite vartotojus tokiu formatu: 1, Antanas; 2, Ieva");
            string[] usersInText = Console.ReadLine()
                .Replace(" ", "") // Istriname tarpus visame stringe
                .Split(';'); // Atskiriame pagal eilutes

            List<User> users = new List<User>();

            foreach (string user in usersInText)
            {
                string[] userData = user.Split(',');

                if (userData.Length < userColumnCount) break;

               User newUser = new User(Convert.ToInt32(userData[0]), userData[1]);
                users.Add(newUser);
            }

            Console.WriteLine("Aplikacijoje turime siuos vartotojus:");
            foreach (User user in users)
            {
                Console.WriteLine($"{user.Name} ID: {user.Id}");
            }

            string naudotojoIvestis;

            Console.WriteLine("Suveskite vartotojus tokiu formatu: 1, Antanas");

            while ((naudotojoIvestis = Console.ReadLine()) != "")
            {
                Console.WriteLine("Pridedame nauja vartotoja..");
                string[] userData = naudotojoIvestis.Split(',');

                if (userData.Length < userColumnCount) break;

                User newUser = new User(Convert.ToInt32(userData[0]), userData[1]);
                users.Add(newUser);
            }

            Console.WriteLine("Aplikacijoje turime siuos vartotojus:");
            foreach (User user in users)
            {
                Console.WriteLine($"{user.Name} ID: {user.Id}");
            }
        }

        public static void SkaitymasIsStaticKlases()
        {
            List<Person> people = PersonInitialData.DataSeed.ToList();

            Console.WriteLine("Skaitant is Static Klases radome siuos zmones:");
            foreach (Person person in people)
            {
                Console.WriteLine($"Vardas Pavarde: {person.FirstName} {person.LastName}");
            }
        }
        #endregion

        // + Greitas sprendimas reikalaujantis nedaug laiko ir mazai ziniu
        // - Reikalauja papildomu split operaciju
        // - Uzloadina visa teksta i aktyvia atminti
        // - Kol skaito teksta nieko kito aplikacijoje negali vykti su veikianciu threadu
        // - Nesiples darbas su dideliais failais
        public static void SkaitymasIsTxtFailo()
        {
            int animalColumnCount = 2;
            List<Animal> animals = new List<Animal>();
            //string filePath = "C:\\Users\\Edvinas\\source\\repos\\CA.NET2\\OOP\\P035_DataReading\\P035_DataReading\\InitialData\\AnimalData.txt";
            string filePath = Environment.CurrentDirectory + "\\InitialData\\AnimalData.txt";
            Console.WriteLine(filePath);
            string text = File.ReadAllText(filePath);
            string[] animalStringData = text.Split(Environment.NewLine);

            Console.WriteLine(text);

            foreach (string animal in animalStringData)
            {
                string[] animalData = animal.Split(',');

                if (animalData.Length != animalColumnCount) break;

                Animal newAnimal = new Animal(animalData);
                animals.Add(newAnimal);
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }

        // + Greitas sprendimas reikalaujantis nedaug laiko ir mazai ziniu
        // - Uzloadina visa teksta i aktyvia atminti
        // - Kol skaito teksta nieko kito aplikacijoje negali vykti su veikianciu threadu
        // - Nesiples darbas su dideliais failais
        public static void SkaitymasIsTxtFailoEilutemis()
        {
            int animalColumnCount = 2;
            List<Animal> animals = new List<Animal>();
            string filePath = Environment.CurrentDirectory + "\\InitialData\\AnimalData.txt";

            string[] animalStringData = File.ReadAllLines(filePath);

            foreach (string animal in animalStringData)
            {
                string[] animalData = animal.Split(',');

                if (animalData.Length != animalColumnCount) break;

                Animal newAnimal = new Animal(animalData);
                animals.Add(newAnimal);
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }

        public static void SkaitymasIsTxtFailoEilutemisAtskirai()
        {
            int animalColumnCount = 2;
            List<Animal> animals = new List<Animal>();
            string filePath = Environment.CurrentDirectory + "\\InitialData\\AnimalData.txt";

            // IDisposable resursai butu elementai kaip: Streamai, Listeneriai, duombazes komunikacijos repositorijos, webiniai iskvietimai ir t.t.
            StreamReader sr = new StreamReader(filePath);

            string animalLine;
            //Console.WriteLine(line);
            //string line2 = sr.ReadLine();
            //Console.WriteLine(line2);

            while ((animalLine = sr.ReadLine()) != null)
            {
                string[] animalData = animalLine.Split(',');

                if (animalData.Length != animalColumnCount) break;

                Animal newAnimal = new Animal(animalData);
                animals.Add(newAnimal);
            }

            // Su .Close() mes pasakome GarbageCollector, kad reikia isvalyti duomenis priklausancius siam objektui
            sr.Close();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }

        public static void SkaitymasIsTxtFailoEilutemisAtskiraiSuUsing()
        {
            int animalColumnCount = 2;
            List<Animal> animals = new List<Animal>();
            string filePath = Environment.CurrentDirectory + "\\InitialData\\AnimalData.txt";

            using StreamReader sr = new StreamReader(filePath);
                string animalLine;


            while ((animalLine = sr.ReadLine()) != null)
            {
                string[] animalData = animalLine.Split(',');

                if (animalData.Length != animalColumnCount) break;

                Animal newAnimal = new Animal(animalData);
                animals.Add(newAnimal);
            }
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

        }




        /*     Uzduotis 1– Sukurkite programa, kuri moketu nuskaityti UserData1.csv failą. UserData1.csv galite pasiimti iš Teams pamokos Files sekcijos. Atvaizduokite kiekvieno naudotojo duomenis tokiu formatu:”55. Petras Petraitis (Vyras) – petras@petramail.lt”.
Headeri turetu atspausdinti pirmoje eiluteje.
PAGALBA: Tam, kad turėtumėt patogų priėjimu visiems duomenims jums reikės susikurti naują <User> klasę.
       Uzduotis 2 – Sukurkite nauja <Hotel> klase, kuri savyje gali laikyti sarasa <User> (Hoteliu data importuokite is HotelData1.csv).
Sukurkite nauja <HotelManager> klase, kuri savyje laiko sarasa hoteliu.
Naujai sukurtai klasei <HotelManager> sukurkite metoda [AllocateUsersToHotels(users)], kuris priskirs kiekviena vartotoja atsitiktiniam (Random) hoteliui.
Sukurkite atskleidziama <Hotel> property, AverageClientSalary, kuris grazintu besilankanciu klientu vidutine sumuota alga. Turi buti Unit Test Coverage.
       Uzduotis 3- Sukurkite isskleista property <HotelManager> AverageRating, kuris grazintu vidutini hoteliu ivertinima + unit test.
Sukurkite <HotelManager> klasei isskleidziama property NewHotels, kuris grazintu sarasa visu hoteliu, kurie buvo pastatyti veliau nei 2010-01-01.
Sukurkite <HotelManager> klasei metoda [AllocateUsersToLuxHotels(users)], kuris turetu naudotojus priskirti tik i hotelius, kuriu ivertinimas yra auksciau 3 ir yra NewHotels sarase.
Sukurkite <Hotel> klasei [MenVisitors] ir [WomenVisitors] isskleidziamus property, kurie turetu grazinti besilankancius vyrus ir moteris individualiai.
 
         
         */




    }
}