using Microsoft.EntityFrameworkCore;
using P004_EF_Application.Data;
using P004_EF_Application.Models;
using P004_EF_Application.Repository.IRepository;

namespace P004_EF_Application.Repository
{
    public class DishRepository : Repository<Dish>, IDishRepository
    {
        private readonly RestaurantContext _db;

        public DishRepository(RestaurantContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Dish> UpdateAsync(Dish dish)
        {
            dish.UpdateDateTime = DateTime.Now;
            _db.Dishes.Update(dish);
            await _db.SaveChangesAsync();

            return dish;
        }
    }
}