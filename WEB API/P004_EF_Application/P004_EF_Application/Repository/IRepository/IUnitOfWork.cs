using P04_EF_Applying_To_API.Repository;
using P04_EF_Applying_To_API.Repository.IRepository;

namespace P004_EF_Application.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IDishOrderRepository DishOrder { get; }
        IDishRepository Dish { get; }
        IUserRepository User { get; }
        Task SaveAsync();


    }
}
