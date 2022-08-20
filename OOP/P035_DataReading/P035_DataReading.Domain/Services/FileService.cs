using P035_DataReading.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P035_DataReading.Domain.Services
{
    public class FileService
    {
        readonly string _filePath;
        public FileService(string filePath)
        {
            _filePath = filePath;
        }
        public string ReadTextFromFile() => File.ReadAllText(_filePath);
        public string[] ReadFileLines() => File.ReadAllLines(_filePath);

        public List<Animal> FetchAnimalTxtRecords()
        {
            int animalColumnCount = 2;
            List<Animal> animals = new List<Animal>();

            using StreamReader sr = new StreamReader(_filePath);

            string animalLine;

            while ((animalLine = sr.ReadLine()) != null)
            {
                string[] animalData = animalLine.Split(',');

                if (animalData.Length != animalColumnCount) break;

                Animal newAnimal = new Animal(animalData);
                animals.Add(newAnimal);
            }

            return animals;
        }
        public string ExtractBasicUserCsvHeaders()
        {
            using StreamReader sr = new StreamReader(_filePath);

            Console.WriteLine(sr.ReadLine());
            return sr.ReadLine();
        }
        public List<User> FetchBasicUserCsvRecords()
        {
            int userColumnCount = 2;
            List<User> users = new List<User>();

            using StreamReader sr = new StreamReader(_filePath);

            string userLine;
            // Nebutina setinti i kintamaji. Mokymo tikslais palikta tam, kad zinotume, jog tai yra headeris
            string headers = sr.ReadLine();

            while ((userLine = sr.ReadLine()) != null)
            {
                string[] userData = userLine.Split(',');

                if (userData.Length != userColumnCount) break;

                User newUser = new User(userData);
                users.Add(newUser);
            }

            return users;
        }
        public void ReadStreamSymbolsFromFile()
        {
            //FileStream fileStream = File.OpenRead(_filePath); // Older C# version atidarinejimas
            using StreamReader sr = new StreamReader(_filePath);
            char nextCharacter = (char)sr.Read();
            char[] bufferToPutStuffIn = new char[2];
            sr.Read(bufferToPutStuffIn, 0, 2);
            string whatWasReadIn = new string(bufferToPutStuffIn);

            Console.WriteLine($"nextCharacter:{nextCharacter}");
            Console.WriteLine($"whatWasReadIn:{whatWasReadIn}");

            //sr.Close(); - Nebereikia, nes naudojame using StreamReader
        }


        


    }
}
