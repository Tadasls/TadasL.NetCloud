using ApiMokymai.Interfaces;

namespace ApiMokymai.Services
{
    public class Skaiciuokle : InterfaisasDalybos
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
