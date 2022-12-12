using System.Linq.Expressions;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO;
using WebAppMSSQL.Models.ReservationsDTO;

namespace WebAppMSSQL.Repository.IRepository
{
    public interface IReservationRepository : IRepository<Reservation>    
    {
       // CRUD
       //List<Reservation> GetAll(Expression<Func<Reservation, bool>>? filter = null);
       // Reservation Get(Expression<Func<Reservation, bool>> filter, bool tracked = true);
        //void Create(Reservation entity);
        //void Remove(Reservation entity);
        //void Save();
        bool Exist(int id);
        void Update(Reservation entity);
    }
}