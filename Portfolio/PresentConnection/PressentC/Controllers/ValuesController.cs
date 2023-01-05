using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PressentC.Service;
using PressentC.Service.IService;

namespace PressentC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IOptimizationService _optimizationService;

        public ValuesController(IOptimizationService optimizationService)
        {
            _optimizationService = optimizationService;
        }


        [HttpGet]
        public string FillDataBase()
        {

            _optimizationService.Start();

            return "done";
        }
    }
}
