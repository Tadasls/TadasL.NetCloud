using CarApi.Models;

namespace CarApi.Repositories.Interfaces
{
    public interface IUserCarRepository
    {
        IEnumerable<Car> Get(int userId);
    }


}