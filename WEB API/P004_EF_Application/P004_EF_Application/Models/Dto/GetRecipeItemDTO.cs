using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace P004_EF_Application.Models.Dto
{
    public class GetRecipeItemDTO
    {
        public GetRecipeItemDTO(RecipeItem recipeItem)
        {
            Name = recipeItem.Name;
            Calories = recipeItem.Calories;
        }

        [Required]
        public string Name { get; set; }
        public double Calories { get; set; }
   
    }
}
