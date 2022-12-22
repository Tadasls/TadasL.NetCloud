using P004_EF_Application.Models.Dto;
using P004_EF_Application.Models;

namespace P004_EF_Application.Services.Adapters.IAdapters
{
    public interface IDishAdapter
    {
        UpdateDishDTO Bind(Dish dish);
        Dish Bind(UpdateDishDTO updateDishDTO, int id);
    }
}