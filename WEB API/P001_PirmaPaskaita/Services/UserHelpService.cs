using L05_Tasks_MSSQL.Controllers;
using Microsoft.AspNetCore.Mvc;
using WebAppMSSQL.Data;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.BookDTO;
using WebAppMSSQL.Models.ReservationsDTO;
using WebAppMSSQL.Repository;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Services
{
    public class UserHelpService : IUserHelpService
    {
        private readonly KnygynasContext _db;
        private readonly ILogger<KnygynasController> _logger;
        private readonly IReservationRepository _reservationRepo;

        public UserHelpService(KnygynasContext db, ILogger<KnygynasController> logger, IReservationRepository reservationRepo)
        {
            _db = db;
            _logger = logger;
            _reservationRepo = reservationRepo;

        }


        //public async Task<List<GetBookDto>> GetFavoriteAutorsForUser(int id)
        //{
        //     var VisosUserioRezervacijos = await _reservationRepo.GetAllAsync(r => r.LocalUserId == id);

        //    foreach (var item in VisosUserioRezervacijos)
        //    {

        //       var useropMegstamaKnyga = item.BookId; 
        //       var knyguSarasas.Add(useropMegstamaKnyga);
        //    }


        //    return knyguSarasas;
        //}



    









    }
}
