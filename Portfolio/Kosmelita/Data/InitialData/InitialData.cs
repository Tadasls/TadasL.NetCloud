using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Kosmelita.Program;

namespace Kosmelita.Data.InitialData
{
   static class InitialData
   {
      public static readonly List<Product> produktai = new List<Product>()
      {
         new Product
         {
                Id = "123548",
                Name = "Kava",
                Price = 1.25m,
                VatRate = 25,
                Type = "food",
                ProductionDate = new DateTime(2019, 05, 08),
                ExpirationDate = new DateTime(2021, 05, 08),
                Manufacturer = "Kavos turgus",
                Barcode = "5564846513",
                Barcode2 = "55648465135",
                Aliases = new List<string> { "skani kava", "Gurmanu Kava" },
                OriginCountry = "Mianmar",
                OriginTown = "Birma",
                ProductionCountry = "Lithuania",
                ProductionTown = "Kaunas",
                SupplierName = "bigfood",
                SupplierCode = "1236859",
                SupplierAddress = "islandijos 88A, Kaunas"
         },
         new Product
         {
                Id = "S1284",
                Name = "spausdinimas",
                Price = 0.1m,
                Type = "service",
                Barcode2 = "1356484",
                Aliases = new List<string> { "spalvotas spausdinimas", "pigus spaudinimas" },
                ProductionCountry = "Lithuania",
                ProductionTown = "Kaunas",
                Options = new List<string> { "spalvotas", "nespalvotas", "kietu lapu", "kartonu" }
          }



      };
   } 
}
