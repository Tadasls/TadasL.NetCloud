using P004_EF_Application.Models;
using System.Linq.Expressions;
namespace P004_EF_Application.Repository.IRepository
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        // CRUD
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, bool tracked = true);
        Task CreateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity); 
       // Task<bool> ExistAsync(int id);
        Task SaveAsync();
    
    }
}
