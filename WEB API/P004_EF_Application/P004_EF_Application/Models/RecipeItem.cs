﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace P004_EF_Application.Models
{
    public class RecipeItem
    {
        public RecipeItem()
        {

        }

        public RecipeItem(int recipeItemId, string name, double calories, int dishId)
        {
            RecipeItemId = recipeItemId;
            Name = name;
            Calories = calories;
            DishId = dishId;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeItemId { get; set; }
        [Required]
        public string Name { get; set; }
        public double Calories { get; set; }
        public int DishId { get; set; }
        public virtual Dish Dish { get; set; }



    }
}
