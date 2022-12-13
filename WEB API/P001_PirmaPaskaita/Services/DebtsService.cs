using WebAppMSSQL.Controllers;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.ReservationsDTO;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Services
{
    public class DebtsService : IDebtsService
    {
        private readonly IReservationRepository _reservationRepo;

        double visoSkola = 0;
        double knygosSkola = 0;
        int skoluSkaicius = 0;

      
        public DebtsService(IReservationRepository reservationRepo)
        {
            _reservationRepo = reservationRepo;
        }

        public double GautiSkolosDydiMetodas(CreateReservationDTO createReservationDTO)
        {

            IEnumerable<Reservation> rezervacijos = _reservationRepo.GetAll().ToList();

            foreach (var item in rezervacijos)
            {
                if (item.LocalUserId == createReservationDTO.LocalUserId)
                {
                    knygosSkola = item.DelayFine;
                    skoluSkaicius++;
                }
                visoSkola += knygosSkola;

            }
            return visoSkola;

        }

       

        public int GautiSkoluSkaiciuMetodas(CreateReservationDTO createReservationDTO)
        {
            IEnumerable<Reservation> rezervacijos = _reservationRepo.GetAll().ToList();

            foreach (var item in rezervacijos)
            {
                if (item.LocalUserId == createReservationDTO.LocalUserId)
                {
                    knygosSkola = item.DelayFine;
                    skoluSkaicius++;
                }

               
            }
            return skoluSkaicius;

        }





    }
}
