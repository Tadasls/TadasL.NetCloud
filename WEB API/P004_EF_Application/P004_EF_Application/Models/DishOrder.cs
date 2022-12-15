using P04_EF_Applying_To_API.Models;

namespace P004_EF_Application.Models
{
    public class DishOrder
    {

        public int DishorderId { get; set; }
        public int LocalUserId { get; set; }
        public int DishId { get; set; }
        public virtual LocalUser LocalUser { get; set; }
        public virtual Dish Dish{ get; set; }


    }
}
