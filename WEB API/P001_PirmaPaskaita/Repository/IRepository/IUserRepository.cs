using System.Linq.Expressions;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO;
using WebAppMSSQL.Models.DTO.UserTDO;

namespace WebAppMSSQL.Repository.IRepository
{
    public interface IUserRepository
    {
        bool Exist(int id);
        GetUserDto Get(Expression<Func<LocalUser, bool>> filter);
        bool IsUniqueUser(string username);
        LoginResponse Login(LoginRequest loginRequest);
        LocalUser Register(RegistrationRequest registrationRequest);
     

    }
}