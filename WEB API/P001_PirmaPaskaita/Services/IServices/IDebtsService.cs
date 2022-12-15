using WebAppMSSQL.Models.ReservationsDTO;

namespace WebAppMSSQL.Services.IServices
{
    public interface IDebtsService
    {
        //Task<double> GautiSkolosDydiMetodas(CreateReservationDTO createReservationDTO);
        //Task<int> GautiSkoluSkaiciuMetodas(CreateReservationDTO createReservationDTO);
        Task<int> SuskaiciuotiKiekDienuVeluojamaGrazinti(int id);
        Task<int> SuskaiciuotiKiekTuriSkolu(int id);
        double SuskaiciuotiSkolosDydi(int veluojaDienu);

    }
}