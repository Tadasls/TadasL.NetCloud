namespace WebAppMSSQL.Models.DTO.UserDTO
{
    public class UserDto
    {

        public UserDto()
        {

        }

        public UserDto(string username, string name)
        {
            Username = username;
            Name = name;
        }

        public string Username { get; set; }
        public string Name { get; set; }

    }
}
