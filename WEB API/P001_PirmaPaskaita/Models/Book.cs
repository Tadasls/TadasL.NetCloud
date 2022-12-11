using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppMSSQL.Models.Enums;

namespace WebAppMSSQL.Models
{
    public class Book
    {
        public Book() { }

        public Book(int id, string title, string author, ECoverType eCoverType, int publishYear)
        {
            Id = id;
            Title = title;
            Author = author;
            ECoverType = eCoverType;
            PublishYear = publishYear;
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
        public DateTime UpdateDateTime { get; set; }
        public int Stock { get; set; }
        virtual public ICollection<Reservation> Reservations { get; set; }
        



    }
}