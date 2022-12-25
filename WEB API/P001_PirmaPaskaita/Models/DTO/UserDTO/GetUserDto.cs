using System.ComponentModel.DataAnnotations;

namespace WebAppMSSQL.Models.DTO.UserTDO
{
    public class GetUserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public int HasAmountOfBooks { get; set; }
        public double Debt { get; set; }
        public DateTime WasOnline { get; set; }
        public int Points { get; set; }

    }
}

