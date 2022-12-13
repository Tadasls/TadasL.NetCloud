using System.Linq.Expressions;
using WebAppMSSQL.Models;

namespace WebAppMSSQL.Repository.IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // CRUD
        List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter, bool tracked = true);

        void Create(TEntity entity);
        void Remove(TEntity entity);
        void Save();
        bool Exist(int id);

        //void Update(Book book);
        //List<Book> Filter(Book book);

    }
}