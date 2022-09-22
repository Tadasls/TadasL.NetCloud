using P057_DB_Transaction.DataBase.Models;

namespace P057_DB_Transaction.DataBase.Models
{
    public class AuthorBlog
    {
        public int AuthorId { get; set; }
        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }
        public virtual Author Author { get; set; }

    }
}
