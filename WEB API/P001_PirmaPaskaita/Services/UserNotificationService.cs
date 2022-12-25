using L05_Tasks_MSSQL.Controllers;
using Microsoft.AspNetCore.Mvc;
using WebAppMSSQL.Data;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.NotificationDTO;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Services
{
    public class UserNotificationService : IUserNotificationService
    {
        private readonly INotificationRepository _notiRepo;
        private readonly ILogger<KnygynasController> _logger;
        private readonly KnygynasContext _db;
        private readonly IReservationRepository _reservationRepo;

        public UserNotificationService(KnygynasContext db, IReservationRepository reservationRepo, INotificationRepository notiRepo, ILogger<KnygynasController> logger)
        {
            _notiRepo = notiRepo;
            _logger = logger;
            _db = db;
            _reservationRepo = reservationRepo;
        }


        //startuoti notificationServisa patikrinti registracijas ir sukurti useriams notifikacijas servise

        public async Task SukurtiPranesimaVartotojams(int Id, int userId) 
        {
          
            var naujasPranesimas = new UNotification
            {
                 Topic  = "GauTa knyga",
                 Message = $" galite atsiimti gauta knyga kurios id yra {Id} ", 
                 LocalUserId = userId, 
                 IsSeen  = false,
            };
             await _notiRepo.CreateAsync(naujasPranesimas);

           


        }




    }
}
