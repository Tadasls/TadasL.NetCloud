using P035_DataReading.Domain.Models;
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
            //PirmasEnumUzdavinys();

            string path = Environment.CurrentDirectory;
            SakninioFolderioSuradimas(path);
            // SkaitymasIsIvesties();
            // SkaitymasIsStaticKlases();
            // SkaitymasIsTxtFailo();
            SkaitymasIsTxtFailoEilutemis();
        }

        /*         Sukurkite klasę Society
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
                Console.WriteLine($"Vardas: {person.FirstName}  - Pavarde: {person.LastName}");
                
            }
        }

        #region KARTOJIMAS
        static void SakninioFolderioSuradimas(string path)
        {
            //string rootDirectoryPath = new DirectoryInfo(path).Parent.Parent.FullName;
            Console.WriteLine($"Sakninis katalogas yra {path}");

            // C:\Users\tadas\source\repos\Tadasls\TadasL.NetCloud\OOP\P035_DataReading\P035_DataReading\bin\Debug\net6.0
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
            string filePath = "C:\\Users\\tadas\\source\\repos\\Tadasls\\TadasL.NetCloud\\OOP\\P035_DataReading\\P035_DataReading\\InitialData\\AnimalData.txt";

           // string filePath = Environment.CurrentDirectory + "\\InitialData\\AnimalData.txt";
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

            string line = sr.ReadLine();
            Console.WriteLine(line);
            string line2 = sr.ReadLine();
            Console.WriteLine(line2);

            // Su .Close() mes pasakome GarbageCollector, kad reikia isvalyti duomenis priklausancius siam objektui
            sr.Close();

            //foreach (Animal animal in animals)
            //{
            //    Console.WriteLine(animal.Name);
            //}
        }
    }
}