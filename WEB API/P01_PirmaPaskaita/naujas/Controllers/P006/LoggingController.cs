﻿using ApiMokymai.Interfaces;
using ApiMokymai.Models;
using ApiMokymai.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ApiMokymai.Controllers.P006
{
    /// <summary>
    /// 6 paskaita. Demonstracija dotNet logging funkcionalumui
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LoggingController : ControllerBase
    {
        private readonly ILogger<LoggingController> _logger;
        private readonly IBadService _badService;
        private readonly InterfaisasDalybos _skaiciavimoDuomenys;


        public LoggingController(ILogger<LoggingController> logger, IBadService badService, InterfaisasDalybos skaiciavimai)
        {
            _logger = logger;
            _badService = badService;
            _skaiciavimoDuomenys= skaiciavimai;
        }



        /// <summary>
        /// Demonstruojamas bazinis visu loginimo lygiu funkcionalumas
        /// </summary>
        /// <returns>rezultatu masyvas</returns>
        /// <response code="200">Teisingai ivykdoma loginimo logika ir gaunama informacija</response>
        /// <response code="500">Vaje labai baisi klaida</response>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetLoggingResult>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult Get()
        {
            _logger.LogCritical("Betkokia critical informacija is logerio");
            _logger.LogError("Betkokia error informacija is logerio");
            _logger.LogWarning("Betkokia warning");

            _logger.LogInformation("Betkokia informacija is logerio");
            _logger.LogDebug("Betkokia debug informacija is logerio");
            _logger.LogTrace("Betkokia trace");


            return Ok();
        }

        /// <summary>
        /// Demonstruojamas serviso 'luzimo' situacijos loginimas
        /// </summary>
        /// <returns></returns>
        [HttpGet("BadService")]
        [ProducesResponseType(typeof(GetServiceResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult GetBadService()
        {
            _logger.LogInformation("BadService buvo iskvietas {time} ", DateTime.Now);
            try
            {
                _badService.DoSomeWork();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Blogas servisas nuluzo {time}", DateTime.Now);
            }
            return Ok(new GetServiceResult(555555));
        }


   /// <summary>
   /// ieskome dalybos is nulio klaidos pranesimo
   /// </summary>
   /// <param name="a"> cia a skaicius </param>
   /// <param name="b"> cia b skaicius </param>
   /// <returns></returns>
        [HttpGet("DalybaIsNulio")]
        [ProducesResponseType(typeof(GetServiceResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult SkaiciavimuMetodasPaleidimas(int a, int b)
        {
            
            double res = 0;
            _logger.LogInformation("Skaiciavimai Pradeti siuo laiku{time} ", a, b);

            try
            {
               res = _skaiciavimoDuomenys.SuskaiciuotiDalyba(a,b);
               
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "gauntas Blogas parametras {time}", DateTime.Now, a, b);
            }
            return Ok(res);
        }









    }
}