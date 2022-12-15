using P04_EF_Applying_To_API.Models;

namespace P004_EF_Application.Models.Dto
{
    public class GetOrderRequest
    {
        public int UserId { get; set; }
        public int DishId { get; set; }


    }
}
