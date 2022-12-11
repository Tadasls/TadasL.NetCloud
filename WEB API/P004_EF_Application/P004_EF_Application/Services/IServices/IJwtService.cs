namespace P004_EF_Application.Services.IServices
{
    public interface IJwtService
    {
        string GetJwtToken(int userId, string role);
    }
}