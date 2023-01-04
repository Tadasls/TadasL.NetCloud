namespace CarApi.Models
{
    public class CarUser
    {
        public CarUser()
        {

        }

        public CarUser(int carId, int localUserId)
        {
            CarId = carId;
            LocalUserId = localUserId;
        }

        public int CarId { get; set; }
        public int LocalUserId { get; set; }

        

    }


}
