using WebAppMSSQL.Models;

namespace WebAppMSSQL.Repository.IRepository
{
    public interface INotificationRepository
    {
        Task CreateAsync(UNotification entity);
        Task SaveAsync();
    }
}