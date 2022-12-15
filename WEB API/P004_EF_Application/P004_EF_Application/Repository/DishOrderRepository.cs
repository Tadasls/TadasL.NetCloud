using P004_EF_Application.Data;
using P004_EF_Application.Models;
using P004_EF_Application.Repository.IRepository;

namespace P004_EF_Application.Repository
{
    public class DishOrderRepository : Repository<DishOrder>, IDishOrderRepository
    {
        private readonly RestaurantContext _db;

        public DishOrderRepository(RestaurantContext db) : base(db) 
        {
            _db = db;
           
        }









    }
}
