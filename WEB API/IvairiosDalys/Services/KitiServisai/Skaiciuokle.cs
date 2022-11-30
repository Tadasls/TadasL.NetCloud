using ApiMokymai.Interfaces.Kiti;

namespace ApiMokymai.Services.KitiServisai
{
    public class Skaiciuokle : INegalimaDalyba
    {
        private readonly ILogger<Skaiciuokle> _logger;

        public Skaiciuokle(ILogger<Skaiciuokle> logger)
        {
            _logger = logger;
        }

        public double SuskaiciuotiDalyba(int a, int b)
        {
            _logger.LogInformation("vykdomas skaiciavimas ir paduodamas rezultatas", DateTime.Now);
            return a / b;
        }


    }
}
