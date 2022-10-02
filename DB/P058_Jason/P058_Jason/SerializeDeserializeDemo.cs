using Newtonsoft.Json;
using P058_Json.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Json
{
    public static class SerializeDeserializeDemo
    {
        public static void Show()
        {
            string json = InitialData.Samples.SingleJson();

            Console.WriteLine("Išvedame JSON tekstą:");
            Console.WriteLine(json);

            Console.WriteLine("//-----------------------------------------------");
            Console.WriteLine("Deserializuojame Klase Išvedame varda ir pakeiciame varda:");
            Author author = JsonConvert.DeserializeObject<Author>(json);
            Console.WriteLine($"vardas yra: {author.Name}" );
            author.Name = "Jonas Jonaitis";
            Console.WriteLine($"pakeistas vardas yra: {author.Name}");


            Console.WriteLine("//-----------------------------------------------");
            Console.WriteLine("Serializuojame Klase Verciame i Json:");

            string naujasJson = JsonConvert.SerializeObject(author);
            Console.WriteLine(naujasJson);


            Console.WriteLine("//-----------------------------------------------");
            string naujasIntendentJson = JsonConvert.SerializeObject(author, Formatting.Indented);
            Console.WriteLine(naujasIntendentJson);





        }

    }
}
