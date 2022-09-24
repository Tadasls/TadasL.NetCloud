using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using P057_DB_Transaction.DataBase.Models;

namespace P057_DB_Transaction.DataBase.Models
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
