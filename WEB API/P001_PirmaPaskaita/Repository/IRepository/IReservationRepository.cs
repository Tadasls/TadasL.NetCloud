using System.Linq.Expressions;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO;
using WebAppMSSQL.Models.ReservationsDTO;

namespace WebAppMSSQL.Repository.IRepository
{
    public interface IReservationRepository : IRepository<Reservation>    
    {
        
        bool Exist(int id);
        void Update(Reservation entity);
    }
}