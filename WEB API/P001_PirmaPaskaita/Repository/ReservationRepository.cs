using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Data;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.ReservationsDTO;

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
        public async Task CreateAsync(Reservation entity)
        {
            _dbSet.Add(entity);
            await SaveAsync();

            // int return entity.Id; ??
        }
        public async Task<Reservation> GetAsync(Expression<Func<Reservation, bool>> filter, bool tracked = true)
        {
            IQueryable<Reservation> query = _dbSet.AsQueryable();
            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            query = query.Where(filter);
            return await query.FirstOrDefaultAsync();
        }
        public async Task<List<Reservation>> GetAllAsync(Expression<Func<Reservation, bool>>? filter = null)
        {
            IQueryable<Reservation> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.ToListAsync();

        }
        public async Task<int> CountAsync()
        {
            return await _dbSet.CountAsync();
        } // nenaudojamas
        public async Task RemoveAsync(Reservation entity)
        {
            _dbSet.Remove(entity);
           await SaveAsync();
        }
        public async Task SaveAsync()
        {
            _db.SaveChangesAsync();
        }
        public async Task UpdateAsync(Reservation entity)
        {
            _dbSet.Update(entity);
           await SaveAsync();
        }
        public List<Reservation> Filter(Reservation reservation)
        {
            var reservations = _db.Reservations.Where(b => b.LocalUserId.Equals(reservation.LocalUserId != null ? reservation.LocalUserId : "")
                         || b.BookId.Equals(reservation.BookId != null ? reservation.BookId : "")
                         ).ToList();

            return reservations;

        } // nenaudojamas
        public async Task<bool> ExistAsync(Expression<Func<Reservation, bool>> filter)
        {
            IQueryable<Reservation> query = _dbSet;

            if (filter == null)
            {
                throw new NotImplementedException();
            }

            return await query.AnyAsync(filter);
        }





    }
}