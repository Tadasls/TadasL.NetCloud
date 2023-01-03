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

            var currentUserID =int.Parse(_httpContextAccessor.HttpContext.User.Identity.Name);


            var entities =
               from carUser in _context.CarUser.Where(x => x.LocalUserId == currentUserID)
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
    }


}