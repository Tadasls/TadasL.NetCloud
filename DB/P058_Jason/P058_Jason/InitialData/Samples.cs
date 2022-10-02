using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Json.InitialData
{
    public static class Samples
    {
        public static string SingleJson()
        {
            string json = @"{
                ""name"": ""Vardenis Pavardenis"",
                ""courses"": [""c#"",""java"", ""T-Sql""],
                ""since"":""2020-01-01T00:00:00"",
                ""happy"":true,
                ""age"": null,
                ""car"":
                {
                    ""model"":""Enterprice"",
                    ""year"":""2020"",
                },
                ""authorRelationship"":1

        }";
            return json;
        } 

    }
}
