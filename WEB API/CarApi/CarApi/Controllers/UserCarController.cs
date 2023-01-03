using CarApi.Models.Dto;
using CarApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserCarController : ControllerBase
    {
        private readonly IUserCarRepository _repository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserCarController(IUserCarRepository repository, IHttpContextAccessor httpContextAccessor)
        {
            _repository = repository;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet("/api/user/{key}/cars")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetCarResponse>))]
        public IActionResult Get(int key)
        {
            var currentUserID = int.Parse(_httpContextAccessor.HttpContext.User.Identity.Name);
            if (currentUserID != key)
                return Forbid();

            var cars = _repository.Get(key);
            return Ok(cars.Select(c => new GetCarResponse(c)));
        }
    }
}