using CarApi.Models;
using System.Linq.Expressions;

namespace CarApi.Repositories.Interfaces
{
    public interface ICarUserRepository
    {
        IEnumerable<CarUser> All();
    
        int Create(CarUser entity);
     
        CarUser Get(int id);
        void Remove(CarUser entity);
     
    }
}