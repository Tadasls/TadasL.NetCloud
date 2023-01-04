using CarApi.Models;
using CarApi.Models.Dto;

namespace CarApi.Repositories.Interfaces
{
    public interface IUserRepository
    {
       
        //Task<bool> IsUniqueUser(string username);
        //Task<int> Register(LocalUser user);
        //bool TryLogin(string userName, string password, out LocalUser? user);

        bool Exist(string userName);
        LocalUser Get(int id);
        int Register(LocalUser user);
        bool TryLogin(string userName, string password, out LocalUser? user);



    }
}