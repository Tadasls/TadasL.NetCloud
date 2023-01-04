using CarApi.Models.Dto;
using CarApi.Repositories.Interfaces;
using CarApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace CarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserCarController : ControllerBase
    {
        private readonly IUserCarRepository _repository;
        private readonly IUserRepository _userRepository;
        private readonly IUserCarService _userCarService;

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<UserCarController> _logger;

        public UserCarController(IUserCarRepository repository,
            IHttpContextAccessor httpContextAccessor,
            ILogger<UserCarController> logger,
            IUserRepository userRepository, IUserCarService userCarService)
        {
            _repository = repository;
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;
            _userRepository = userRepository;
            _userCarService = userCarService;
        }

        [HttpGet("/api/user/{key}/cars")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetCarResponse>))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult Get(int key)
        {
            var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.Identity.Name);
            if (currentUserId != key)
            {
                _logger.LogWarning("User {currentUserId} tried to access user {key} cars", currentUserId, key);
                return Forbid();
            }
            var cars = _repository.Get(key);
            return Ok(cars.Select(c => new GetCarResponse(c)));

        }


        

        [HttpGet("/api/user/{key}/AllUserCars")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetUserCarResponse>))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult Get2(int key)
        {
            var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.Identity.Name);
            if (currentUserId != key)
            {
                _logger.LogWarning("User {currentUserId} tried to access user {key} cars", currentUserId, key);
                return Forbid();
            }

            //var user = _userRepository.Get(currentUserId);
            // var getCarResponse = _userCarService.BuildCarResponse(user, cars);

            var cars = _repository.Get2(key);
            return Ok(cars.Select(c => new GetUserCarResponse(c)));

        }














    }

}