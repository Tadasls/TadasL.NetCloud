using L05_Tasks_MSSQL.Controllers;
using Microsoft.AspNetCore.Mvc;
using WebAppMSSQL.Data;
using WebAppMSSQL.Models.ReservationsDTO;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Services
{
    public class ValidationService : IValidationService
    {

        private readonly KnygynasContext _db;
        private readonly ILogger<KnygynasController> _logger;


        public ValidationService(KnygynasContext db, ILogger<KnygynasController> logger)
        {
            _db = db;
            _logger = logger;

        }

        //bool CanInsertValidation(int id, out string ErrorMessaage)
        //{

        //    return true;

        //}



    



    }
}
