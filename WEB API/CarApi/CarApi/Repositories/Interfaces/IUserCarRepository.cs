using CarApi.Models;

namespace CarApi.Repositories.Interfaces
{
    public interface IUserCarRepository
    {
        IEnumerable<Car> Get(int userId);
        IEnumerable<Car> Get2(int userId);
    }


}