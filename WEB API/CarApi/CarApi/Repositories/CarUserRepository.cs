using CarApi.Database;
using CarApi.Models;
using CarApi.Repositories.Interfaces;
using System.Linq.Expressions;

namespace CarApi.Repositories
{
    public class CarUserRepository : ICarUserRepository
    {

        private readonly CarContext _context;
        public CarUserRepository(CarContext context)
        {
            _context = context;
        }

        public IEnumerable<CarUser> All()
        {
            return _context.CarUser;
        }

        public CarUser Get(int id)
        {
            return _context.CarUser.First(x => x.CarId == id);
        }

     
       

        public int Create(CarUser entity)
        {
            _context.CarUser.Add(entity);
            _context.SaveChanges();
            return entity.CarId;
        }

     
        public void Remove(CarUser entity)
        {
            _context.CarUser.Remove(entity);
            _context.SaveChanges();
        }



    }
}
