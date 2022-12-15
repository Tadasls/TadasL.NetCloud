using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppMSSQL.Models.ReservationsDTO
{
    public class ReturnReservationDTO
    {
        

        [DataType(DataType.Date)]
        [Display(Name = "Actual Return Date")]
        public DateTime? ActualReturnDate { get; set; }

        [Display(Name = "Kliento ID")]
        public int LocalUserId { get; set; }

        [Display(Name = "Knygos ID")]
        public int BookId { get; set; }

        //[Display(Name = "Ar Aktyvi Rezervacija (apmoketa(?")]
        //public bool Active { get; set; }

    }
}
