namespace CarApi.Models.Dto
{
    public class LoginResponse
    {
        public LocalUser? User { get; set; }
        public string Token { get; set; }
    }
}