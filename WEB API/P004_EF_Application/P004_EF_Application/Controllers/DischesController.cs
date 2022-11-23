using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P004_EF_Application.Data;
using P004_EF_Application.Models.Dto;

namespace P004_EF_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DischesController : ControllerBase
    {
        private readonly RestaurantContex _db;

        public DischesController(RestaurantContex db)
        {
            this._db = db;
        }

        [HttpGet("dishes")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<GetDishDTO>))]
        [ProducesResponseType(500)]
        public ActionResult<IEnumerable<GetDishDTO>> GetDishes()
        {
            return Ok(_db.Dishes.Select(d => new GetDishDTO(d)).ToList());
        }

    }
}
