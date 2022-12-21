using WebAppMSSQL.Models.DTO.ApiModels;

namespace WebAppMSSQL.Services.IServices
{
    public interface IShippingService
    {
        double GetDistanceInMetersFromResponseString(string content);
        Task<string> GetKoordinates(string cityName);
        Task<double> GetAtstumas(string cityLocation);
        Task<double> GetKaina(double atstumas);
       
    }
}