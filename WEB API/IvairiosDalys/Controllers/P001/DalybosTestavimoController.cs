using ApiMokymai.Interfaces.Kiti;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ApiMokymai.Controllers.P001
{
    [Route("api/[controller]")]
    [ApiController]
    public class DalybosTestavimoController : ControllerBase
    {
        private readonly ILogger<DalybosTestavimoController> _logger;
        private readonly INegalimaDalyba _skaiciavimoDuomenys;


        public DalybosTestavimoController(ILogger<DalybosTestavimoController> logger, INegalimaDalyba skaiciavimai)
        {
            _logger = logger;
            _skaiciavimoDuomenys = skaiciavimai;
        }

        /// <summary>
        /// ieskome dalybos is nulio klaidos pranesimo
        /// </summary>
        /// <param name="a"> cia a skaicius </param>
        /// <param name="b"> cia b skaicius </param>
        /// <returns></returns>
        [HttpGet("DalybaIsNulio")]
        [ProducesResponseType(typeof(double), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult SkaiciavimuMetodasPaleidimas(int a, int b)
        {
            double res = 0;
            _logger.LogInformation("Skaiciavimai Pradeti siuo laiku - {time} ; a=  {a} ; b= {b}", DateTime.Now, a, b);

            try
            {
                res = _skaiciavimoDuomenys.SuskaiciuotiDalyba(a, b);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "gauntas Blogas parametras - {time} ; a=  {a} ; b= {b} ", DateTime.Now, a, b);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(res);
        }





    }
}
