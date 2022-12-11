using System.ComponentModel.DataAnnotations;

namespace WebAppMSSQL.Models.ReservationsDTO
{
    public class CreateReservationDTO
    {

        [DataType(DataType.Date)]
        [Display(Name = "Borrow Date")]
        public DateTime BorrowDate { get; set; }

        [Required]
        [Display(Name = "Kliento ID")]
        public int LocalUserId { get; set; }

        [Required]
        [Display(Name = "Knygos ID")]
        public int BookId { get; set; }


    }
}
