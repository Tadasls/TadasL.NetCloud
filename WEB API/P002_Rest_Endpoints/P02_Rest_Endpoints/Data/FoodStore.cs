using P02_Rest_Endpoints.Models;
using P02_Rest_Endpoints.Models.Dto;

namespace P02_Rest_Endpoints.Data
{
    public static class FoodStore
    {
        public static List<FoodDTO> foodList = new List<FoodDTO>()
            {
            new FoodDTO(1, "Orange", "Spain", 7),
            new FoodDTO(2, "Apple", "Spain", 23),
            new FoodDTO(3, "Banana", "Africa", 7),
            new FoodDTO(4, "Pizza", "Italy", 7),
            new FoodDTO(5, "Sausages", "Germany", 7),
            new FoodDTO(6, "Potatoes", "Lithuania", 7),
            };

    }
}
