using Newtonsoft.Json;
using P058_Json.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Json
{
    public class SerializeDemoObject
    {
        public static void Show()
        {
            var author = new Author
            {
                Name = "Vardenis Pavardenis",
                Courses = new string[] { "C#", "Java", },
                Happy = true,

            };
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("objekto serializavimas");
            string json = JsonConvert.SerializeObject(author, Formatting.Indented);
            Console.WriteLine(json);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Kolekcijos Serializavimas");
            List<string> kursai = new List<string> { "C#", "Java", "T-SQL"};
            string jsonArray = JsonConvert.SerializeObject(kursai, Formatting.Indented);
            Console.WriteLine(jsonArray);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Zodyno Serializavimas");
            Dictionary<string, int> kursuZodynas = new Dictionary<string, int> {
                { "C#", 10 },{"Java",20 },{ "T-SQL" ,50 }
            };
            string jsonDictionary = JsonConvert.SerializeObject(kursuZodynas, Formatting.Indented);
            Console.WriteLine(jsonDictionary);


            Console.WriteLine($"-----------------------------------");
            var anonymous = new
            {
                Name = "Jonas Petras",
                Happy = false,
                Courses = new List<string>()

            };
            Console.WriteLine(JsonConvert.SerializeObject(anonymous));



            // uzdaviniai

            //1
            Console.WriteLine("1");
            Console.WriteLine();
            List<string> games = new List<string> { "Starcraft", "Halo", "Legend of Zelda" };
            string gamesJSon = JsonConvert.SerializeObject(games, Formatting.Indented);
            Console.WriteLine(gamesJSon);

            //2
            Console.WriteLine("2");
            Console.WriteLine();
            Dictionary<string, int> points = new Dictionary<string, int>
    {
        { "James", 9001 },
        { "Jo", 3474 },
        { "Jess", 11926 }
    };
            string jsonPoints = JsonConvert.SerializeObject(points, Formatting.Indented);
            Console.WriteLine(jsonPoints);


            //3
            Console.WriteLine("3");
            Console.WriteLine();
            Account account = new Account
            {
                Email = "james@example.com",
                Active = true,
                CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string>
              {
                  "User",
                  "Admin"
              }
            };
            string jsonNew = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(jsonNew);

            //4
            Console.WriteLine("4");
            Console.WriteLine();
            Movie movie = new Movie 
            { 
                Name = "Bad Boys",
                Year = 1995,
            };
            string moviesJson = JsonConvert.SerializeObject(movie, Formatting.Indented);
            Console.WriteLine(moviesJson);
        }

    }
}
