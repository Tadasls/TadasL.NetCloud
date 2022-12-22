using WebAppMSSQL.Controllers;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.ReservationsDTO;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Services
{
    public class DebtsService : IDebtsService
    {
        public DebtsService() {}

        private readonly IReservationRepository _reservationRepo;

        public DebtsService(IReservationRepository reservationRepo)
        {
            _reservationRepo = reservationRepo;
        }

        public async Task<int> CountDelayDays(int id, List<Reservation> allReservations)
        {
           // var visosRezervacijos = await _reservationRepo.GetAllAsync(); //.ToList();
            int knygaVeluojamaGrazinti = 0;
            int klientasVisoPradelseDienu = 0;

            foreach (var item in allReservations)
            {
                if (item.LocalUserId == id)
                {
                    if (item.ActualReturnDate.HasValue && (((DateTime)item.ActualReturnDate - (DateTime)item.ReturnDate).TotalDays > 0))
                    { 
                       knygaVeluojamaGrazinti = (int)((DateTime)item.ActualReturnDate - (DateTime)item.ReturnDate).TotalDays; 
                    }
                    else if (item.ReturnDate < DateTime.Now)
                    {
                        knygaVeluojamaGrazinti = (int)(DateTime.Now - item.ReturnDate).TotalDays;
                    }
                    else
                    {
                        return 0;
                    }

                    klientasVisoPradelseDienu += knygaVeluojamaGrazinti;
                }

                
            }
            return klientasVisoPradelseDienu;
        }
        public async Task<int> CountDebtsAmount(int id, List<Reservation> allReservations)
        {
          //  var visosRezervacija = await _reservationRepo.GetAllAsync(); //.ToList();
            int skoluSkaicius = 0;

            foreach (var item in allReservations)
            {
                if (item.LocalUserId == id)
                {
                    if (item.ActualReturnDate.HasValue && (((DateTime)item.ActualReturnDate - (DateTime)item.ReturnDate).TotalDays > 0))
                    {
                        skoluSkaicius++;
                    }
                    else if (item.ReturnDate < DateTime.Now)
                    {
                        skoluSkaicius++;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return skoluSkaicius;
        }
        public double SuskaiciuotiSkolosDydi(int pradelstaDienu)
        {
            double klientoSkola = (double)pradelstaDienu * 0.2;

            if (klientoSkola >= 50)
            {
                return klientoSkola = 50;
            }
            return klientoSkola;

        }

     
       public async Task <double> VienosKnygosSkola(int BookId, List<Reservation> allReservations)
        {
            int knygaVeluojamaGrazinti = 0;
            int knygosPradelsimas = 0;

            foreach (var item in allReservations)
            {
                if (item.BookId == BookId)
                {
                    if (item.ActualReturnDate.HasValue && (((DateTime)item.ActualReturnDate - (DateTime)item.ReturnDate).TotalDays > 0))
                    {
                        knygaVeluojamaGrazinti = (int)((DateTime)item.ActualReturnDate - (DateTime)item.ReturnDate).TotalDays;
                    }
                    else if (item.ReturnDate < DateTime.Now)
                    {
                        knygaVeluojamaGrazinti = (int)(DateTime.Now - item.ReturnDate).TotalDays;
                    }
                    else
                    {
                        return 0;
                    }

                    knygosPradelsimas += knygaVeluojamaGrazinti;
                }

            }
            double knygosSkola = SuskaiciuotiSkolosDydi(knygosPradelsimas);

            return knygosSkola;






            return 0.1;
        }
    }
}
