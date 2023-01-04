using CarApi.Models;
using CarApi.Models.Dto;

namespace CarApi.Repositories.Interfaces
{
    public interface IUserRepository
    {

        bool Exist(string userName);
        LocalUser Get(int id);
        int Register(LocalUser user);
        bool TryLogin(string userName, string password, out LocalUser? user);

    }
}
