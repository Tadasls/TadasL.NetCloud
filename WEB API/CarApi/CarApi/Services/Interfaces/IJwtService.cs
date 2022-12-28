namespace CarApi.Services.Interfaces
{
    public interface IJwtService
    {
        string GetJwtToken(int userId, string role);
    }
}