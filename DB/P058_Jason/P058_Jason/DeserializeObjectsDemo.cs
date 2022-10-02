using Newtonsoft.Json;
using P058_Json.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Json
{
    public static class DeserializeObjectsDemo
    {
        public static void Show()
        {
            string jsonString = @"
            {
            'name':'Vardenis Pavardenis',
            'courses':['c#','T-SQL'],
            'happy':true,
            }";

            Console.WriteLine("isvedame JSon");
            Console.WriteLine(jsonString);


            Author authorObj = JsonConvert.DeserializeObject<Author>(jsonString);
            Console.WriteLine($"Vardas yra {authorObj.Name}");
            authorObj.Name = "Jonas Jonaitis";
            Console.WriteLine($" Pakeistas vardas yra: {authorObj.Name}");

            Console.WriteLine($"----------------"); // isvedamas netinkmas jsom objektas
            var author = JsonConvert.DeserializeObject(jsonString);
            Console.WriteLine($" Pakeistas vardas yra: {author}");

            Console.WriteLine($"----------------");

            var jsonFromFile = File.ReadAllText("autorius.json");
            Author authorFromFile = JsonConvert.DeserializeObject<Author>(jsonFromFile);
            Console.WriteLine($"Vardas yra: {authorFromFile.Name}");
             




        }

    }
}
