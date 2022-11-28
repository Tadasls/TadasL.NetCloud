using ApiMokymai.Interfaces;

namespace ApiMokymai.Services
{
    public class BadService : IBadService
    {
        private readonly ILogger<BadService> _logger;

        public BadService(ILogger<BadService> logger)
        {
            _logger = logger;
        }

        public string DoSomeWork()
        {
            var a = "a";
            var b = int.Parse(a);
            _logger.LogInformation("bad servise darbas baigtas grazinimas rezultatas");
            return "Darbas baigtas b=" + b;
        }

     
    }
}
