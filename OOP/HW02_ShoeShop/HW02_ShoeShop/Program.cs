using HW02_ShoeShop.Infrastructure.DataBase;

namespace HW02_ShoeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, ND!");


            var salesShopDB = new ShoeShop();

            //salesShopDB.AddBlog("Programavimas");
            //salesShopDB.AddBlog("Knygos");
            //salesShopDB.AddPost("Charp", 1);
            //salesShopDB.AddPost("Charp", 2);

            // salesShopDB.AddAuthor("Petras", "Petrauskas", 1);


            salesShopDB.GetBlogs_EagerLoading();

            salesShopDB.LazyLoading();

        }
    }
}