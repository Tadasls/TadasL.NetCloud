using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppMSSQL.Models.DTO.ApiModels;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {

        private readonly IShippingService _service;
        private readonly ILogger<ShippingController> _logger;

        public ShippingController(IShippingService service,
            ILogger<ShippingController> logger)
        {
            _service = service;
            _logger = logger;
        }



        [HttpGet("MiestoKoordinates")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CityLocation>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> Get(string cityName)
        {
            try
            {
                var res = await _service.GetKoordinates(cityName);
               // var koordinates = res.features[0].geometry.coordinates;

                return Ok(res);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ivyko kazkas labai baisaus");
                throw;
            }

        }

        /// <summary>
        /// pristatymo kastai
        /// </summary>
        /// <param name="cityName">pristatymo miesto pavadinimas</param>
        /// <returns></returns>
        [HttpGet("GetDeliveryPrice")]
        public async Task<ActionResult<double>> GetDeliveryPriceToEnteredCity([FromQuery] string cityName)
        {
            try
            {
                if (cityName == "")
                {
                    _logger.LogInformation("City ({cityName}) entered by user not found!", cityName);
                    return NotFound();
                }

                var pristatymoKoordinates = await _service.GetKoordinates(cityName);
             //  var xy = pristatymoKoordinates.features[0].geometry.coordinates[0].ToString() + "," + pristatymoKoordinates.features[0].geometry.coordinates[1].ToString();
                var atstumasInKm = await _service.GetAtstumas(pristatymoKoordinates);
                var pristatymoKaina = await _service.GetKaina(atstumasInKm);


                return Ok(pristatymoKaina);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ivyko kazkas blogo");
                throw;
            }


        }
















    }
}
