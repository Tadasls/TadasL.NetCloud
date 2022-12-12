using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMSSQL.Models
{
    public class Reservation
    {
        public Reservation()
        {

        }

        public Reservation(int id, DateTime borrowDate, DateTime returnDate, DateTime? actualReturnDate, int localUserId, LocalUser localUser, int bookId, Book book) 
        {
            Id = id;
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
            ActualReturnDate = actualReturnDate;
            LocalUserId = localUserId;
            LocalUser = localUser;
            BookId = bookId;
            Book = book;
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Borrow Date")]
        public DateTime BorrowDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Return Date")]
        public DateTime ReturnDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Actual Return Date")]
        public DateTime? ActualReturnDate { get; set; }

        [Required]
        [Display(Name = "Kliento ID")]
        public int LocalUserId { get; set; }

        virtual  public LocalUser LocalUser { get; set; } // virtualus

        [Required]
        [Display(Name = "Knygos ID")]
        public int BookId { get; set; }

        virtual public Book Book { get; set; } // virtualus

        [Display(Name = "Knygos Skola")]
        public double DelayFine 
        {
            get
            {
                double skola = (double)DelayDays * 0.2;
                if (skola >= 50)
                {
                    return skola = 50;
                }

                return skola;
            }
        
        }
  
        [NotMapped]
        public int? DelayDays
        {
            get
            {
                if (ActualReturnDate.HasValue)
                {
                    if (((DateTime)ActualReturnDate - (DateTime)ReturnDate).TotalDays > 0)
                    {
                        return (int)((DateTime)ActualReturnDate - (DateTime)ReturnDate).TotalDays;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if (ReturnDate < DateTime.Now)
                {
                    return (int)(DateTime.Now - ReturnDate).TotalDays;
                }
                else
                {
                    return 0;
                }

            }
            



        }
    }
}
