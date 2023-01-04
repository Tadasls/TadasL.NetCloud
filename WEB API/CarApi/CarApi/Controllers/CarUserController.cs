using CarApi.Models.Dto;
using CarApi.Models;
using CarApi.Repositories;
using CarApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace CarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarUserController : ControllerBase
    {
       private readonly ICarUserRepository _carUserRepository;

        public CarUserController(ICarUserRepository carUserRepository)
        {
            _carUserRepository = carUserRepository;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Post(int carId, int userId)
        {
            var entity = new CarUser(carId, userId);
            var id = _carUserRepository.Create(entity);
            return Created("Posted", new { carId = id });
        }










    }
}
