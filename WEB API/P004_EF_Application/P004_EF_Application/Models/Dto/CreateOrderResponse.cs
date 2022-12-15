namespace P004_EF_Application.Models.Dto
{
    public class CreateOrderResponse
    {
        public string DishName { get; set; }
        public string State { get; set; }
        public DateTime CookingFinnishDateTime { get; set; }
    }
}