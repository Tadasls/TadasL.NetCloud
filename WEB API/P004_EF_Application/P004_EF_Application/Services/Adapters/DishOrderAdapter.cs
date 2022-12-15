using P004_EF_Application.Models;
using P004_EF_Application.Models.Dto;
using P004_EF_Application.Services.Adapters.IAdapters;

namespace P004_EF_Application.Services.Adapters
{
    public class DishOrderAdapter : IDishOrderAdapter
    {
        public GetOrderResponse Bind(DishOrder dishOrder)
        {
            return new GetOrderResponse
            {
                User = dishOrder.LocalUser,
                Dish = dishOrder.Dish
            };
        }

        public DishOrder Bind(CreateOrderRequest request)
        {
            return new DishOrder
            {
                DishId = request.DishId,
                LocalUserId = request.UserId
            };
        }

        public CreateOrderResponse Bind(Dish dish)
        {
            return new CreateOrderResponse
            {
                DishName = dish.Name,
                CookingFinnishDateTime = DateTime.Now.AddMinutes(30),
                State = "Preparing.."
            };
        }
    }
}