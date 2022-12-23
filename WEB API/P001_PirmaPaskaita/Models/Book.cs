using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppMSSQL.Models.Enums;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebAppMSSQL.Models
{
    public class Book
    {
        public Book() { }

        public Book(int id, string title, string author, ECoverType eCoverType, int publishYear, int stock, DateTime updated, EBookStatus ebookStatus)
        {
            Id = id;
            Title = title;
            Author = author;
            ECoverType = eCoverType;
            PublishYear = publishYear;
            Stock = stock;
            Updated = updated;
            EBookStatus = ebookStatus;
            
        }
      

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public ECoverType ECoverType { get; set; }
        public int PublishYear { get; set; }
        public int Stock { get; set; }
        public DateTime Updated { get; set; }
        public EBookStatus EBookStatus { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

    }
}