using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Data;
using WebAppMSSQL.Models;

namespace WebAppMSSQL.Repository
{

    public class ReservationRepository : IReservationRepository     //<TEntity> where TEntity : class
    {
        private readonly KnygynasContext _db;
        private DbSet<Reservation> _dbSet;
            
        public ReservationRepository(KnygynasContext db)
        {
            _db = db;
            _dbSet = _db.Set<Reservation>();
        }

        public void Create(Reservation entity)
        {
            _dbSet.Add(entity);
            Save();

            // int return entity.Id; ??
        }



        public Reservation Get(Expression<Func<Reservation, bool>> filter, bool tracked = true)
        {
            IQueryable<Reservation> query = _dbSet.AsQueryable();
            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public List<Reservation> GetAll(Expression<Func<Reservation, bool>>? filter = null)
        {
            IQueryable<Reservation> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query.ToList();

        }
        public int Count()
        {
            return _dbSet.Count();
        }

        public bool Exist(int id)
        {
            return _dbSet.Any(x => x.Id == id);
        }



        public void Remove(Reservation entity)
        {
            _dbSet.Remove(entity);
            Save();
        }

         public void Save()
        {
            _db.SaveChanges();
        }



        public void Update(Reservation entity)
        {
            _dbSet.Update(entity);
            Save();
        }



    }
}