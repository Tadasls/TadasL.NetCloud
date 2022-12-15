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

        double visoSkola = 0;
        double knygosSkola = 0;
        int aktyviuRezervacijuSkaicius = 0;

        public DebtsService(IReservationRepository reservationRepo)
        {
            _reservationRepo = reservationRepo;
        }

        //public async Task<double> GautiSkolosDydiMetodas(CreateReservationDTO createReservationDTO)
        //{
        //    var info = await _reservationRepo.GetAllAsync();

        //    IEnumerable<Reservation> rezervacijos = info.ToList();

        //    foreach (var item in rezervacijos)
        //    {
        //        if (item.LocalUserId == createReservationDTO.LocalUserId)
        //        {
        //            knygosSkola = item.DelayFine;
        //        }
        //        visoSkola += knygosSkola;

        //    }
        //    return visoSkola;

        //}


        //public async Task<int> GautiSkoluSkaiciuMetodas(CreateReservationDTO createReservationDTO)
        //{
        //    IEnumerable<Reservation> rezervacijos = await _reservationRepo.GetAllAsync(); //.ToList();

        //    foreach (var item in rezervacijos)
        //    {
        //        if (item.LocalUserId == createReservationDTO.LocalUserId && item.ActualReturnDate==null && item.Active==true)
        //        {
        //            aktyviuRezervacijuSkaicius++;
        //        }


        //    }
        //    return aktyviuRezervacijuSkaicius;

        //}


        public async Task<int> SuskaiciuotiKiekDienuVeluojamaGrazinti(int id)
        {
            var visosRezervacija = await _reservationRepo.GetAllAsync(); //.ToList();
            int knygaVeluojamaGrazinti = 0;
            int klientasVisoPradelseDienu = 0;

            foreach (var item in visosRezervacija)
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
                }

                klientasVisoPradelseDienu += knygaVeluojamaGrazinti;
            }
            return klientasVisoPradelseDienu;
        }

        public async Task<int> SuskaiciuotiKiekTuriSkolu(int id)
        {
            var visosRezervacija = await _reservationRepo.GetAllAsync(); //.ToList();
            int skoluSkaicius = 0;

            foreach (var item in visosRezervacija)
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

     
       
    }
}
