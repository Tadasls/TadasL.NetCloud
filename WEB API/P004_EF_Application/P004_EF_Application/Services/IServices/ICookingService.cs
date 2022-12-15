using P004_EF_Application.Models;

namespace P004_EF_Application.Services.IServices
{
    public interface ICookingService
    {
        Task CookAsync(DishOrder dishOrder);


    }
}
