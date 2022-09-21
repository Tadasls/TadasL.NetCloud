
using P056_DB_Dapper.Database;
using P056_DB_Dapper.Database.Dapper;
using P056_DB_Dapper.Services;

namespace P056_DB_Dapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dapper yra EntityFramework alternatyva
            // EFCore -> Fullscale ORM (Object–relational mapping)
            // Dapper -> Micro ORM
            // %LOCALAPPDATA%

            // Kodel naudoti Dapperi?
            // Del labai didelio greicio
            // Labai patinka rasyti raw SQL
            // Esate arciau "gelezies"

            // Reikalingi paketai
            // install-package Dapper
            Console.WriteLine("Hello, Dapper!");
            Console.WriteLine("Fetching connection string..");
            var dbConfig = new DatabaseConfig();
            Console.WriteLine("Starting up Database check..");
            IDatabaseBootstrap databaseBootstrap = new DatabaseBootstrap(dbConfig);
            databaseBootstrap.Setup();
            Console.WriteLine("Database check complete");

            IProductService productService = new ProductService();
            productService.Run();
        }

        /*
         Uzduotis 1: Parašykite programą NoteBook, kuri naudotų Dapper. Jūsų programa turėtų turėti klasę ir lentele Note, kuri savyje turėtų šiuos properties:
            Id [INT IDENTITY(1,1) PRIMARY KEY AUTOINCREMENT]   -> EF versijoje tai butu [Key] arba PK
            Title [varchar]
            Description [varchar]
            CreationDatetime [datetime default current_timestamp]
            Priority [varchar]

        Užtikrinkite, kad jūsų programa teisingai veikia sukurdami 
        NoteBookWritter service klasę, kuri galėtų pridėti įrašus,
        ištrinti įrašus ir juos atspausdinti. Grafinėje sąsajoje 
        vartotojas turėtų turėti galimybę tęsti veiksmus programoje 
        tol kol pasirinks Quit funkciją.

         */
    }
}