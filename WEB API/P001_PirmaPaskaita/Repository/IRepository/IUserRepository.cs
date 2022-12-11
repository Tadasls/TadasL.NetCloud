using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO;

namespace WebAppMSSQL.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        LoginResponse Login(LoginRequest loginRequest);
        LocalUser Register(RegistrationRequest registrationRequest);
    }
}