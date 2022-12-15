using System.Net;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.BookDTO;
using WebAppMSSQL.Models.Enums;
using WebAppMSSQL.Models.ReservationsDTO;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Services
{
    public class ReservationWrapper : IReservationWrapper
    {
        public ReservationWrapper() {}

        public Reservation KonvertuokiDuomenis(ReturnReservationDTO returnReservationDto)
        {
            return new Reservation
            {
                ActualReturnDate = returnReservationDto.ActualReturnDate,
                LocalUserId = returnReservationDto.LocalUserId,
                BookId = returnReservationDto.BookId,
                Active = false,
            };
        }
          

    }
}