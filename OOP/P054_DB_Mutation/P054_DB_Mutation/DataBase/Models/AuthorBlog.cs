using P054_DB_Mutation.Database.Models;

namespace P054_DB_Mutation.Database.Models
{
    public class AuthorBlog
    {
        public int AuthorId { get; set; }
        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }
        public virtual Author Author { get; set; }

    }
}