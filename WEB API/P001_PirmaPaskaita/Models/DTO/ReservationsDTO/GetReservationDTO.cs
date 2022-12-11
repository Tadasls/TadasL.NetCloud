using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppMSSQL.Models.ReservationsDTO
{
    public class GetReservationDTO
    {

        public GetReservationDTO()
        {
        }

        public GetReservationDTO(int id, DateTime borrowDate, DateTime returnDate, DateTime? actualReturnDate, double delayFine, int localUserId, LocalUser localUser, int bookId, Book book)
        {
            Id = id;
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
            ActualReturnDate = actualReturnDate;
            DelayFine = delayFine;
            LocalUserId = localUserId;
            LocalUser = localUser;
            BookId = bookId;
            Book = book;
        }

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
        public double DelayFine { get; set; }
        [Display(Name = "Kliento ID")]
        public int LocalUserId { get; set; }
        virtual public LocalUser LocalUser { get; set; }
        [Display(Name = "Knygos ID")]
        public int BookId { get; set; }
        virtual public Book Book { get; set; }





    }
}
