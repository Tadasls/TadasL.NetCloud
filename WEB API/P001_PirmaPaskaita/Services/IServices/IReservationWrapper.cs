using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.ReservationsDTO;
using WebAppMSSQL.Models.ReservationsDTO;

namespace WebAppMSSQL.Services.IServices
{
    public interface IReservationWrapper
    {
        //  Reservation Bind(ReturnReservationDTO returnReservationDto);
        GetReservationResponse Bind(Reservation reservation);
        Reservation Bind(CreateReservationDTO request);
        CreateReservationResponse Bind(Book book);
    }
}