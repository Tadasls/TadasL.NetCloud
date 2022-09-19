using Domains.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P054_DB_Mutation
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
        public virtual IList<AuthorBlog> AuthorBlogs { get; set; }   


    }
}
