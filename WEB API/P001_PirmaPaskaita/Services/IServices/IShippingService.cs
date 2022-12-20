using WebAppMSSQL.Models.DTO.ApiModels;

namespace WebAppMSSQL.Services.IServices
{
    public interface IShippingService
    {
        Task<CityLocation> GetKoordinates(string location);
    }
}