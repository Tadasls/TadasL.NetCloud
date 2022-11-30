using L05_Tasks_MSSQL.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace L05_Tasks_MSSQL.Models
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
        public string Title { get; set; }
        public string Author { get; set; }
        public ECoverType ECoverType { get; set; }
        public int PublishYear { get; set; }
    }
}