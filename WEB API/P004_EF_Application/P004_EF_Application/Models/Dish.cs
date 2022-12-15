using P004_EF_Application.Models.Dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P004_EF_Application.Models
{
    public class Dish
    {
        public Dish() { }

        public Dish(CreateDishDTO createDishDTO)
        {
            Name = createDishDTO.Name;
            Type = createDishDTO.Type;
            SpiceLevel = createDishDTO.SpiceLevel;
            Country = createDishDTO.Country;
            ImagePath = createDishDTO.ImagePath;
            DateTime = createDishDTO.CreatedDateTime;
        }

        public Dish(int dishId, string name, string type, string spiceLevel, string country, string imagePath, DateTime createDateTime)
        {
            DishId = dishId;
            Name = name;
            Type = type;
            SpiceLevel = spiceLevel;
            Country = country;
            ImagePath = imagePath;
            DateTime = createDateTime;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DishId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string SpiceLevel { get; set; }
        public string Country { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public virtual List<RecipeItem> RecipeItems { get; set; }

        public virtual List<DishOrder> DishOrders { get; set; }
    }
}