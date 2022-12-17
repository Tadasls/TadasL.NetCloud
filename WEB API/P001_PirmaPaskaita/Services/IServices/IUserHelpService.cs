using Microsoft.AspNetCore.Mvc;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.BookDTO;
using WebAppMSSQL.Models.ReservationsDTO;

namespace WebAppMSSQL.Services.IServices
{
    public interface IUserHelpService
    {
        Task<GetBookDto> GetFavoriteAutorsForUser(int id, List<Reservation> visosUserioRezervacijos);
    }
}