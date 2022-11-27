using Microsoft.EntityFrameworkCore;
using P004_EF_Application.Models;

namespace P004_EF_Application.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) 
        {

        }


        public DbSet<Dish> Dishes { get; set; } 
        public DbSet<RecipeItem> RecipyItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>()
                .HasData(
                new Dish(1, "Fried Bread Sticks", "Snacks", "Mild", "Lithuania", "", DateTime.Now),
                new Dish(2, "Potato dumplings", "Main dish", "low", "Lithuania", "", DateTime.Now),
                new Dish(3, "Kibinai", "Street Food", "low", "Lithuania", "", DateTime.Now)
                );
            modelBuilder.Entity<RecipeItem>()
            .HasData(
                new RecipeItem(1,"Duona",150,1),
                new RecipeItem(2,"Chhese",300,1),
                new RecipeItem(3,"Mayo",300,1),
                new RecipeItem(4,"Garlic",50,1),
                new RecipeItem(5,"Potatos",400,2),
                new RecipeItem(6,"Meat",500,2),
                new RecipeItem(7,"SourCream",300,2),
                new RecipeItem(8,"Dought",300,3),
                new RecipeItem(9,"Meat",300,3),
                new RecipeItem(10,"Salt",300,3)
              
            );



        }



    }
}
