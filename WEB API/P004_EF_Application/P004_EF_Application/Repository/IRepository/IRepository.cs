using System.Linq.Expressions;
namespace P004_EF_Application.Repository.IRepository
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        //crud 
        List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null);
        TEntity Get(Expression<Func<TEntity, bool>>filter, bool tracked = true );

        void Create(TEntity entity);
        void Remove(TEntity entity);
        void Save();


    }
}
