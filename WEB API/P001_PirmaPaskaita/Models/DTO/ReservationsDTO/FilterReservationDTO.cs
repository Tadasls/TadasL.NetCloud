using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMSSQL.Models.ReservationsDTO
{
    public class FilterReservationDTO
    {
        public FilterReservationDTO()
        {

        }

        public FilterReservationDTO( DateTime borrowDate, DateTime returnDate, int localUserId, int bookId)
        {
           
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
            LocalUserId = localUserId;
            BookId = bookId;
        }

     
        [DataType(DataType.Date)]
        [Display(Name = "Borrow Date")]
        public DateTime? BorrowDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Return Date")]
        public DateTime? ReturnDate { get; set; }

        [Display(Name = "Kliento ID")]
        public int? LocalUserId { get; set; }

        [Display(Name = "Knygos ID")]
        public int? BookId { get; set; }





    }
}
