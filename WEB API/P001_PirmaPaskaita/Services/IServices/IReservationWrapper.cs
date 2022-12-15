using WebAppMSSQL.Models;
using WebAppMSSQL.Models.ReservationsDTO;

namespace WebAppMSSQL.Services.IServices
{
    public interface IReservationWrapper
    {
        Reservation KonvertuokiDuomenis(ReturnReservationDTO returnReservationDto);
    }
}