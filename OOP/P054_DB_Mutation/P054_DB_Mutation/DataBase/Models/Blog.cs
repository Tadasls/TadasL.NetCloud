using System.Collections.Generic;
using P054_DB_Mutation.Database.Models;

namespace P054_DB_Mutation.Database.Models
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