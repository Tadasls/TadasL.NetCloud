using Microsoft.EntityFrameworkCore;
using P004_EF_Application.Data;
using P004_EF_Application.Models;
using P004_EF_Application.Repository.IRepository;

namespace P004_EF_Application.Repository
{
    public class DishRepository : Repository<Dish>, IDishRepository
    {
        private readonly RestaurantContext _dishRepo;

        public DishRepository(RestaurantContext db) : base (db)
        {
            _dishRepo = db;
        }

        public Dish Update(Dish dish)
        {
            dish.UpdatedDateTime = DateTime.Now;
            _dishRepo.Update(dish);
            _dishRepo.SaveChanges();  

            return dish;
        }

    }
}
