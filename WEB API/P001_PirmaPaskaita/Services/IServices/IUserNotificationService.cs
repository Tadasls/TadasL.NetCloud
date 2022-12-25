using WebAppMSSQL.Models;

namespace WebAppMSSQL.Services.IServices
{
    public interface IUserNotificationService
    {
        Task SukurtiPranesimaVartotojams(int Id, int userId);
    }
}