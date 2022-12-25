using ApiMokymai.Models.ApiModels;
using ApiMokymai.Services;
using L05_Tasks_MSSQL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMokymai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakeApiController : ControllerBase
    {
        private readonly IFakeApiProxyService _service;
        private readonly ILogger<FakeApiController> _logger;

        public FakeApiController(IFakeApiProxyService service,
            ILogger<FakeApiController> logger)
        {
            _service = service;
            _logger = logger;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BookApiModel>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var res = await _service.GetBooks();
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ivyko kazkas labai baisaus");
                throw;
            }

        }


        [HttpPost]
        public async Task<IActionResult> Post (BookApiModel data)
        {
            try
            {
                await _service.CreateBook(data);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "kazkas blogo");
                throw;
            }
        }












    }
}