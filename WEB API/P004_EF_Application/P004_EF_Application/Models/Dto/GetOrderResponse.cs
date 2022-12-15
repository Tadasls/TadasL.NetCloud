using P04_EF_Applying_To_API.Models;

namespace P004_EF_Application.Models.Dto
{
    public class GetOrderResponse
    {
        public LocalUser User { get; set; }
        public Dish Dish { get; set; }


    }
}
