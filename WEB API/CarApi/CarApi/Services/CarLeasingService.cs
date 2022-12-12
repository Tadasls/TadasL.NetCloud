namespace CarApi.Services
{
    public class CarLeasingService: ICarLeasingService
    {

        public decimal AddPrice(double price, double percent)
        {

            return (decimal)(price * (1 + percent / 100));

        }

        public bool CanLease(int carId) 
        {

            throw new NotImplementedException();
        }




    }
}
