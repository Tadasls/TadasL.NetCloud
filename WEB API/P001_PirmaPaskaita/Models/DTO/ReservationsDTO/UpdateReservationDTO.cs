using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppMSSQL.Models.ReservationsDTO
{
    public class UpdateReservationDTO
    {

        public UpdateReservationDTO()
        {

        }

        public UpdateReservationDTO(DateTime borrowDate, DateTime returnDate, DateTime? actualReturnDate, double delayFine)  // ,int id
        {
            // Id = id;
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
            ActualReturnDate = actualReturnDate;
            DelayFine = delayFine;
        }

        //public int Id { get; set; }

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

        [Display(Name = "Knygos ID")]
        public int BookId { get; set; }




    }
}
