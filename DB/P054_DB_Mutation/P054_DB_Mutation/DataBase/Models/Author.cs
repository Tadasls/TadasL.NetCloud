using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using P054_DB_Mutation.Database.Models;

namespace P054_DB_Mutation.Database.Models
{
    [Table("Author")]
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [MaxLength(150)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(150)]
        public string LastName { get; set; }

        public virtual IList<AuthorBlog> AuthorBlog { get; set; }
    }
}
