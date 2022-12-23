namespace WebAppMSSQL.Services.IServices
{
    public interface IMembershipService
    {
        Task AtnaujintiPrisijungimoData(int userId);
        Task AtnaujintiPrisijungimoSavaite(int userId);
        Task PridetiTaskuUzPrisijungima(int userId);
        Task PridetiTaskuUzPrisijungimaVIPBONUS(int userId);
    }
}