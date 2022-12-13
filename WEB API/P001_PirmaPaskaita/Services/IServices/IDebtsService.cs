using WebAppMSSQL.Models.ReservationsDTO;

namespace WebAppMSSQL.Services.IServices
{
    public interface IDebtsService
    {
    
        double GautiSkolosDydiMetodas(CreateReservationDTO createReservationDTO);
        int GautiSkoluSkaiciuMetodas(CreateReservationDTO createReservationDTO);
    }
}