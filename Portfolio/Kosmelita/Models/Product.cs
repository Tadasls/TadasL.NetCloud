using System.Xml.Serialization;

namespace Kosmelita
{
   
        [Serializable]
        [XmlRoot("Product")] // root pervadinimas pagal poreiki
        public class Product
        {
            public string Id { get; set; }
            [XmlElement("ProductName")]   // jei prireiktu pervadinti pavadinimus
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int VatRate { get; set; }
            public string Type { get; set; }
            public DateTime ProductionDate { get; set; }
            public DateTime ExpirationDate { get; set; }
            public string Manufacturer { get; set; }
            public string Barcode { get; set; }
            public string Barcode2 { get; set; }
            public List<string> Aliases { get; set; }
            public string OriginCountry { get; set; }
            public string OriginTown { get; set; }
            public string ProductionCountry { get; set; }
            public string ProductionTown { get; set; }
            public string SupplierName { get; set; }
            public string SupplierCode { get; set; }
            public string SupplierAddress { get; set; }
            public List<string> Options { get; set; }
        }


    
}