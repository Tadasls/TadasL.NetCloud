
using P052_CodeFirstSqliteDb.Infrastructure.Database;
using P052_CodeFirstSqliteDb.Infrastructure.Intercases;

namespace P052_CodeFirstSqliteDb
{
    internal class Program
    {
        private static IBloggingRepository _bloggingRepository = new BloggingRepository();

        static void Main(string[] args)
        {
            // Technologija, kuria naudosime SQL duombaziu naudojimui: SQLite
            // Technologija komunikacijai su DB: EntityFrameworkCore
            // 3 priejimai kaip galima aktyvuoti duombaziu naudojima kode:
            // 1. Database First
            // 2. Model First
            // 3. Code First

            // Management Studio: https://sqlitebrowser.org/dl/

            // Pradedi naudoti SQLite turime isirasyti siuos NuGet (Tools->NuGet Package Manager->Manage NuGet...)
            // 1. install-package Microsoft.EntityFrameworkCore.Sqlite
            // 2. install-package Microsoft.EntityFrameworkCore.Proxies
            // 3. install-package Microsoft.EntityFrameworkCore.Tools
            Console.WriteLine("Hello, SQLite!");


            //Console.WriteLine($"Gyvuno Vardas");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Gyvuno Tipas");
            //string type = Console.ReadLine();
            //Console.WriteLine($"Gyvuno gim Data 2000/02/02");
            //DateTime birthDate = DateTime.Parse(Console.ReadLine());

            //_bloggingRepository.AddAnimal(name, type, birthDate);






            while (true)
            {
                Console.WriteLine($" Add new usser. -  1  q - Quit  2 - display all 3 display all sorted");
                char selection = Console.ReadKey().KeyChar;


                switch (selection)
                {
                    case '1':
                        Console.WriteLine($"Suvedame nauja vartotoja");
                        Console.WriteLine($"Vardas");
                        string firstName = Console.ReadLine();
                        Console.WriteLine($"Pavarde");
                        string lastName = Console.ReadLine();
                        Console.WriteLine($"Age pvz 2000/02/02");
                        DateTime birthDate = DateTime.Parse(Console.ReadLine());

                        _bloggingRepository.AddPerson(firstName, lastName, birthDate);

                        break;

                    case 'q':
                        return;

                    case '2':
                        _bloggingRepository.PrintAllPersons();
                        break;

                    case '3':
                        _bloggingRepository.PrintAllPersonsSorted();
                        break;

                    default:
                        Console.WriteLine("Input incorect, try again");
                        break;
                }

            }



        }
    }
}