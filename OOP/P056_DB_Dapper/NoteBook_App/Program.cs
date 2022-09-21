using NoteBook_App.DataBase;
using NoteBook_App.DataBase.Dapper;
using NoteBook_App.Services;

namespace NoteBook_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Dapper!");
            Console.WriteLine("Fetching connection string..");
            var dbConfig = new DatabaseConfig();
            Console.WriteLine("Starting up Database check..");
            IDatabaseBootstrap databaseBootstrap = new DatabaseBootstrap(dbConfig);
            databaseBootstrap.Setup();
            Console.WriteLine("Database check complete");


            INoteBookService noteBookService = new NoteBookServices();
            noteBookService.Run();



        }
    }
}