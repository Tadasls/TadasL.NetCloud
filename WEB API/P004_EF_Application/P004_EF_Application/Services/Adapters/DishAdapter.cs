using P004_EF_Application.Models.Dto;
using P004_EF_Application.Models;
using P004_EF_Application.Services.Adapters.IAdapters;

namespace P004_EF_Application.Services.Adapters
{
    public class DishAdapter : IDishAdapter
    {
        public UpdateDishDTO Bind(Dish dish)
        {
            return new UpdateDishDTO
            {
                Country = dish.Country,
                ImagePath = dish.ImagePath,
                Name = dish.Name,
                SpiceLevel = dish.SpiceLevel,
                Type = dish.Type
            };
        }

        public Dish Bind(UpdateDishDTO updateDishDTO, int id)
        {
            return new Dish
            {
                Country = updateDishDTO.Country,
                ImagePath = updateDishDTO.ImagePath,
                Name = updateDishDTO.Name,
                SpiceLevel = updateDishDTO.SpiceLevel,
                Type = updateDishDTO.Type,
                DishId = id
            };
        }
    }
}