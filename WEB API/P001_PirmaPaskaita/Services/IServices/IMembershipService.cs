using WebAppMSSQL.Models.DTO.ApiModels;
using WebAppMSSQL.Models.DTO.UserTDO;

namespace WebAppMSSQL.Services.IServices
{
    public interface IMembershipService
    {
        bool ArBuvoUserisSndOnline(int userId);
        Task AtnaujintiPrisijungimoData(int userId);
        Task<HolidayModel> GetHolidays();
        Task PanaudotiTaskusUzSkolas(int userId, int taskai);
        Task PridetiTaskuUzPrisijungima(int userId);
        Task PridetiTaskuUzPrisijungimaVIPBONUS(int userId);
        Task SetUserLevel(int userId);
    }
}