using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.UserDTO;

namespace WebAppMSSQL.Services.Wraperiai
{
    public class UserWrapper
    {
        public UserWrapper()
        {

        }


        public UserDto Bind(LocalUser localUser)
        {
            return new UserDto(localUser.Username, localUser.Name);
        }

    }
}
