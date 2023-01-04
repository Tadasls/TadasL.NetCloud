using CarApi.Database;
using CarApi.Models;
using CarApi.Repositories.Interfaces;
using CarApi.Services.Interfaces;
using System.Linq.Expressions;

namespace CarApi.Repositories
{
    public class UserIdentityRepository : IUserIdentityRepository
    {

        private readonly CarContext _context;
         public UserIdentityRepository(CarContext context)
            {
                _context = context;
            }

        public IEnumerable<UserIdentity> All()
        {
            return _context.UserIdentity;
        }

        public UserIdentity Get(int id)
        {
            return _context.UserIdentity.First(x => x.Id == id);
        }

        public IEnumerable<UserIdentity> Find(Expression<Func<UserIdentity, bool>> predicate)
        {
            return _context.UserIdentity.Where(predicate);
        }

        public int Count()
        {
            return _context.UserIdentity.Count();
        }

        public bool Exist(int id)
        {
            return _context.UserIdentity.Any(x => x.Id == id);
        }

        public int Create(UserIdentity entity)
        {
            _context.UserIdentity.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public void Update(UserIdentity entity)
        {
            _context.UserIdentity.Update(entity);
            _context.SaveChanges();
        }

        public void Remove(UserIdentity entity)
        {
            _context.UserIdentity.Remove(entity);
            _context.SaveChanges();
        }


    }
}
