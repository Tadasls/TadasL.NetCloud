using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using P004_EF_Application.Data;
using P004_EF_Application.Models;
using P004_EF_Application.Repository.IRepository;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace P004_EF_Application.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly RestaurantContext _db;
        private DbSet<TEntity> _dbSet;

        public Repository(RestaurantContext db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public async Task CreateAsync(TEntity entity)
        {
            _dbSet.Add(entity);
            await SaveAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, bool tracked = true)
        {
            IQueryable<TEntity> query = _dbSet;

            if (!tracked)
            {
                query = query.AsNoTracking();
            }

            query = query.Where(filter);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if(filter != null)
            {
                query = query.Where(filter);    
            }
            return await query.ToListAsync();  

        }

        public async Task RemoveAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
           await SaveAsync();
        }

        public async Task SaveAsync()
        {
           await _db.SaveChangesAsync();
        }

     


        //public async Task<bool>ExistAsync(int id)
        //{
        //    return await _dbSet.Any(x=>x.Id == id); 
        //}



    }
}
