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



        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CityLocation>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> Get(string locality)
        {
            try
            {
                var res = await _service.GetKoordinates(locality);
                return Ok(res.features[0].geometry.coordinates);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ivyko kazkas labai baisaus");
                throw;
            }

        }







    }
}
