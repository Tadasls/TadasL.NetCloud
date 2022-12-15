using P004_EF_Application.Models;

namespace P004_EF_Application.Repository.IRepository
{
    public interface IDishRepository : IRepository<Dish>
    {
       Task <Dish> UpdateAsync(Dish dish);
          

    }
}
