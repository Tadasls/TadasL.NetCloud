
using P054_DB_Mutation.Services;

namespace P054_DB_Mutation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, DB Mutations!");


            var manageDb = new ManageDb();

            manageDb.AddBlog("Programavimas");
            manageDb.AddBlog("Knygos");
            manageDb.AddPost("Charp", 1);
            manageDb.AddPost("Charp", 2);



        }
    }
}