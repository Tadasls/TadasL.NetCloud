using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P004_EF_Application.Data;
using P004_EF_Application.Models;
using P004_EF_Application.Models.Dto;
using P004_EF_Application.Repository.IRepository;

namespace P004_EF_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IDishRepository _dishRepo;

        public DishesController(IDishRepository dishRepo)
        {
            _dishRepo = dishRepo;
        }

        /// <summary>
        /// Fetches all registered dishes in the DB
        /// </summary>
        /// <returns>All dishes in DB</returns>
        [HttpGet("dishes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetDishDTO>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetDishDTO>>> GetDishes()
        {
            var dishes = await _dishRepo.GetAllAsync();
            return Ok(dishes
                .Select(d => new GetDishDTO(d))
                .ToList());
        }

        /// <summary>
        /// Fetch registered dish with a specified ID from DB
        /// </summary>
        /// <param name="id">Requested dish ID</param>
        /// <returns>Dish with specified ID</returns>
        /// <response code="400">Customer bad request description</response>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET dishes/1
        ///     {
        ///        "name": "Krabu salotos",
        ///        "country": "Lithuania",
        ///        "type": "Salad"
        ///     }
        ///
        /// </remarks>
        [HttpGet("dishes/{id:int}", Name = "GetDish")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetDishDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetDishDTO>> GetDishById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            // Tam, kad istraukti duomenis naudokite
            // First, FirstOrDefault, Single, SingleOrDefault, ToList

            var dish = await _dishRepo.GetAsync(d => d.DishId == id);

            if (dish == null)
            {
                return NotFound();
            }

            return Ok(new GetDishDTO(dish));
        }

        [HttpPost("dishes")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateDishDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CreateDishDTO>> CreateDish(CreateDishDTO dishDto)
        {
            if (dishDto == null)
            {
                return BadRequest();
            }

            Dish model = new Dish()
            {
                Country = dishDto.Country,
                SpiceLevel = dishDto.SpiceLevel,
                Type = dishDto.Type,
                Name = dishDto.Name,
                CreatedDateTime = dishDto.CreatedDateTime,
                ImagePath = dishDto.ImagePath
            };

           await _dishRepo.CreateAsync(model);
            

            return CreatedAtRoute("GetDish", new { id = model.DishId }, dishDto);
        }

        [HttpDelete("dishes/delete/{id:int}")]
        [Authorize(Roles = "super-admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteDish(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var dish = await _dishRepo.GetAsync(d => d.DishId == id);

            if (dish == null)
            {
                return NotFound();
            }

           await _dishRepo.RemoveAsync(dish);
           

            return NoContent();
        }

        [HttpPut("dishes/update/{id:int}")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateDish(int id, UpdateDishDTO updateDishDTO)
        {
            if (id == 0 || updateDishDTO == null)
            {
                return BadRequest();
            }

            var foundDish = await _dishRepo.GetAsync(d => d.DishId == id);

            if (foundDish == null)
            {
                return NotFound();
            }

            foundDish.Name = updateDishDTO.Name;
            foundDish.ImagePath = updateDishDTO.ImagePath;
            foundDish.Type = updateDishDTO.Type;
            foundDish.SpiceLevel = updateDishDTO.SpiceLevel;
            foundDish.Country = updateDishDTO.Country;

            await _dishRepo.UpdateAsync(foundDish);
         

            return NoContent();
        }
    }
}