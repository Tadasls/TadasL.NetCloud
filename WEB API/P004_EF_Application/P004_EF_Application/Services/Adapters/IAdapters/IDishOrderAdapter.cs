using P004_EF_Application.Models;
using P004_EF_Application.Models.Dto;

namespace P004_EF_Application.Services.Adapters.IAdapters
{
    public interface IDishOrderAdapter
    {
        DishOrder Bind(CreateOrderRequest request);
        GetOrderResponse Bind(DishOrder dishOrder);
        CreateOrderResponse Bind(Dish dish);

    }
}
