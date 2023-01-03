using Kosmelita.Data.InitialData;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Kosmelita
{
    internal partial class Program
    {
        public static void Main()
        {
            Console.WriteLine("\n Sveiki, Pradedame XML Serializacija! \n ");
           // List<Product> products = InitialData.PvzSarasas();
            var stopwatch = Stopwatch.StartNew();
            string xml = SerializeObjectToXmlString(InitialData.produktai);//  išsivedame stringą, jei būtų poreikis ateičiai           
            Console.WriteLine($" \n XML Serializacija Baigta! per ms: [{stopwatch.Elapsed}] \n  ");
            Console.WriteLine(xml); //atvaizduojame XML duomenis konsolėje

            Console.WriteLine("\n 2. Pradedamas XML laikmenos sukurimas! \n ");
            stopwatch = Stopwatch.StartNew();
            SerializeObjectToXmlToFile(InitialData.produktai);
            Console.WriteLine($" XML laikmena sukurta! per ms: [{stopwatch.Elapsed}] \n");
            stopwatch = Stopwatch.StartNew();
            DeserializeXmlToFileToList();
            Console.WriteLine($" 3. XML Laikmena nuskaityta ir duomenys grazinti kaip objektai per ms: [{stopwatch.Elapsed}] ");

        }

        public static string SerializeObjectToXmlString(List<Product> products)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            string xml = "";
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, products);
                xml = writer.ToString();
            }

            return xml;
        }
        public static void SerializeObjectToXmlToFile(List<Product> products)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            string filename = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\sukurtasfailas.xml";
            using (var writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, products);
            }

        }
        public static void DeserializeXmlToFileToList()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Product>));
            string filename = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\sukurtasfailas.xml";
            var products = new List<Product>();
            using (var reader = new StreamReader(filename))
            {
                products = (List<Product>)xmlSerializer.Deserialize(reader);
            }
        }


    }
}