using System.Collections.Generic;
using P057_DB_Transaction.DataBase.Models;

namespace P057_DB_Transaction.DataBase.Models
{
    public class Blog
    {
        public virtual int BlogId { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Rating { get; set; }

        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>(); //Lazy loading

        public virtual IList<AuthorBlog> AuthorBlog { get; set; }
    }
}
