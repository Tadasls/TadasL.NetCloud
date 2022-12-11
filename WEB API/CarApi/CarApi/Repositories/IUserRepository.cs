using CarApi.Models;
using CarApi.Models.Dto;

namespace CarApi.Repositories
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        LoginResponse Login(LoginRequest loginRequest);
        LocalUser Register(RegistrationRequest registrationRequest);


    }
}