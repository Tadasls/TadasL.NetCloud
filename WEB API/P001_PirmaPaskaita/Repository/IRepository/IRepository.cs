using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using System.Linq.Expressions;

namespace WebAppMSSQL.Repository.IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // CRUD
        List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter, bool tracked = true);
        //List<TEntity> Filter(Expression<Func<TEntity, bool>>? filter = null);
        void Create(TEntity entity);
        void Remove(TEntity entity);
        void Save();
    }
}