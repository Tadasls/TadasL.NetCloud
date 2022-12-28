using CarApi.Models;
using CarApi.Models.Dto;

namespace CarApi.Repositories.Interfaces
{
    public interface IUserRepository
    {
       
        Task<bool> IsUniqueUser(string username);
        Task<int> Register(LocalUser user);
        bool TryLogin(string userName, string password, out LocalUser? user);


    }
}