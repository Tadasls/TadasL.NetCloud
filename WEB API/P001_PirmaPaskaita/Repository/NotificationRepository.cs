using Microsoft.EntityFrameworkCore;
using WebAppMSSQL.Data;
using WebAppMSSQL.Models;
using WebAppMSSQL.Repository.IRepository;

namespace WebAppMSSQL.Repository
{
    public class NotificationRepository : INotificationRepository     //<TEntity> where TEntity : class
    {
        private readonly KnygynasContext _db;
        private DbSet<UNotification> _dbSet;
        public NotificationRepository(KnygynasContext db)
        {
            _db = db;
            _dbSet = _db.Set<UNotification>();
        }
        public async Task CreateAsync(UNotification entity)
        {
            _dbSet.Add(entity);
            await SaveAsync();

        }

        public async Task SaveAsync()
        {
            _db.SaveChangesAsync();
        }
    }
}