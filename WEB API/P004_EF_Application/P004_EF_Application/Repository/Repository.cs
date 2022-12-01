using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using P004_EF_Application.Data;
using P004_EF_Application.Repository.IRepository;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace P004_EF_Application.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly RestaurantContext _dishRepo;
        private DbSet<TEntity> _dishRepoSet;

        public Repository(RestaurantContext db)
        {
            _dishRepo = db;
            _dishRepoSet = _dishRepo.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            _dishRepoSet.Add(entity);
            Save();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, bool tracked = true)
        {
            IQueryable<TEntity> query = _dishRepoSet.AsQueryable();
            if(!tracked) 
            {
                query = query.AsNoTracking();
            }
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            IQueryable<TEntity> query = _dishRepoSet;
            if(filter != null)
            {
                query = query.Where(filter);    
            }
            return query.ToList();  

        }

        public void Remove(TEntity entity)
        {
            _dishRepoSet.Remove(entity);
            Save();
        }

        public void Save()
        {
            _dishRepo.SaveChanges();
        }
    }
}
