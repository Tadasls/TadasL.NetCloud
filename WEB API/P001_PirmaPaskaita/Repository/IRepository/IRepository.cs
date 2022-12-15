using System.Linq.Expressions;
using WebAppMSSQL.Models;

namespace WebAppMSSQL.Repository.IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // CRUD
                
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, bool tracked = true);
        Task CreateAsync(TEntity entity);
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null);
        Task RemoveAsync(TEntity entity);
        Task SaveAsync();
        bool Exist(int id);
        Task UpdateAsync(TEntity entity);
    }
}