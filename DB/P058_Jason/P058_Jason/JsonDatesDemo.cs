using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Json
{
    public static class JsonDatesDemo
    {
        public static void Show()
        {
            Console.WriteLine("Datos demo");
            List<DateTime> dates = new List<DateTime>
            {
                new DateTime(2022,09,21,21,22,0000),
                new DateTime(2022,09,21),
                new DateTime(665645160000000),


            };
            string jsonDateDefault = JsonConvert.SerializeObject(dates, Formatting.Indented);
            Console.WriteLine(jsonDateDefault);
            Console.WriteLine("--------------------------");

            Console.WriteLine(JsonConvert.SerializeObject(dates, Formatting.Indented),
                new JsonSerializerSettings
                {
                    DateFormatString = "dd/MM/yyy"
                });
            Console.WriteLine("--------------------------");
            Console.WriteLine(JsonConvert.SerializeObject(dates,
                 Formatting.Indented,
                 new JavaScriptDateTimeConverter()));
        }
    }
}
