using P057_DB_TransactionChangeTracking.Services;

namespace P057_DB_TransactionChangeTracking
{
    internal class Program
    {
        // Transaction - Operacija, kuri privalo isigyvendinti (Prevencinis irankis)
        // Jis moka grazinti buvusia busena jei suluzta procesas viduryje veiksmo pvz SQL serveris issjungia
        // Dar musu uzklausai nespejus pilnai isigyvendinti
        // Transaction Rollback
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, DB_Mutation!");

            var manageDb = new ManageDb();
            manageDb.AddBlog("Programavimas");
            manageDb.AddBlog("Knygos");
            manageDb.AddPost("CSharp", 1);
            manageDb.AddPost("CSharp Threading", 1);
            manageDb.AddPost("CSharp Boxing", 1);
            manageDb.AddPost("CSharp Transactions", 1);
            manageDb.AddPost("CSharp EF", 1);
            manageDb.AddPost("SQL", 1);
            manageDb.UpdateBlog(1, "Programavimas2");
            manageDb.UpdatePost(2, "T-SQL");
            //manageDb.DeletePost(3);
            manageDb.GetBlogs_EagerLoading();

           // manageDb.UpdateBlogToVipBlog();
        }
    }
}