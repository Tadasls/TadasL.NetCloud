using System.Linq.Expressions;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO;
using WebAppMSSQL.Models.DTO.UserTDO;

namespace WebAppMSSQL.Repository.IRepository
{
    public interface IUserRepository
    {
        bool Exist(int id);
        Task<GetUserDto> GetAsync(Expression<Func<LocalUser, bool>> filter);
        Task<bool> IsUniqueUserAsync(string username);
        Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
        Task<LocalUser> RegisterAsync(RegistrationRequest registrationRequest);
     

    }
}