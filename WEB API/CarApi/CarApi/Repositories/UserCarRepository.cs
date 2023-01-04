using CarApi.Database;
using CarApi.Models;
using CarApi.Repositories.Interfaces;
using Microsoft.IdentityModel.Tokens;
using SQLitePCL;
using System.Security.Cryptography.X509Certificates;

namespace CarApi.Repositories
{
    public class UserCarRepository : IUserCarRepository
    {
        private readonly CarContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserCarRepository(CarContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public IEnumerable<Car> Get(int userId)
        {
            var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.Identity.Name);

            //var id = _httpContextAccessor.HttpContext.Request.Query["personId"];

            var entities =
                from carUser in _context.CarUser.Where(x => x.LocalUserId == currentUserId)
                    //from car in _context.Cars.Where(c => c.Id == carUser.CarId).DefaultIfEmpty() //left join
                join car in _context.Cars on carUser.CarId equals car.Id //inner join
                where carUser.LocalUserId == userId
                select car;

            //var entities1 = _context.CarUser
            //                        .Where(x => x.LocalUserId == userId)
            //                        .Join(_context.Cars,
            //                        u => u.CarId,
            //                        c => c.Id,
            //                        (u, c) => c);


            return entities;
        }
        public IEnumerable<Car> Get2(int userId)
        {

            var currentUserID = int.Parse(_httpContextAccessor.HttpContext.User.Identity.Name);

            var entities =
               from carUser in _context.CarUser.Where(x => x.LocalUserId == currentUserID)
               join car in _context.Cars on carUser.CarId equals car.Id
               join localUser in _context.Users on carUser.LocalUserId equals localUser.Id
               join userIdentity in _context.UserIdentity on localUser.Id equals userIdentity.Id
               where carUser.LocalUserId == userId
               select car;

            return entities;
        }




    }


}