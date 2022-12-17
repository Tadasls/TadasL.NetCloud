using WebAppMSSQL.Models;
using WebAppMSSQL.Models.ReservationsDTO;

namespace WebAppMSSQL.Services.IServices
{
    public interface IDebtsService
    {
        Task<int> CountDebtsAmount(int id, List<Reservation> allReservations);
        Task<int> CountDelayDays(int id, List<Reservation> allReservations);
        double SuskaiciuotiSkolosDydi(int veluojaDienu);

    }
}