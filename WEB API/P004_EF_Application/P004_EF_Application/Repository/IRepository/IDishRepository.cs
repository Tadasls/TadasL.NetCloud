using P004_EF_Application.Models;

namespace P004_EF_Application.Repository.IRepository
{
    public interface IDishRepository : IRepository<Dish>
    {
        Dish Update(Dish dish);


    }
}
