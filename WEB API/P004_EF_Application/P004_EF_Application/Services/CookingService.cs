using P004_EF_Application.Models;
using P004_EF_Application.Services.IServices;

namespace P004_EF_Application.Services
{
    public class CookingService : ICookingService
    {
        private readonly ILogger<CookingService> _logger;

        public CookingService(ILogger<CookingService> logger)
        {
            _logger = logger;
        }

        public async Task CookAsync(DishOrder dishOrder)
        {
            CookDishAsync(2, dishOrder);
        }

        private async Task CookDishAsync(int cookingTimeSec, DishOrder dishOrder)
        {
            for (var i = 0; i <= 100; i += 20)
            {
                await Task.Delay(cookingTimeSec * 1000);
                _logger.LogInformation($"Cooking <{dishOrder.Dish.DishId}.{dishOrder.Dish.Name}> in progress.. {i}%/100%");
            }

            _logger.LogInformation($"Cooking <{dishOrder.Dish.DishId}.{dishOrder.Dish.Name}> complete");
        }
    }
}