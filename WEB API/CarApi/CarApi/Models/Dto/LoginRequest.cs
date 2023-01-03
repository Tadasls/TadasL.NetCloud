using System.ComponentModel.DataAnnotations;

namespace CarApi.Models.Dto
{
    public class LoginRequest
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}



