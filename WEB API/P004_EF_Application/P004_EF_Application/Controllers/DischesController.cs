using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P004_EF_Application.Data;
using P004_EF_Application.Models;
using P004_EF_Application.Models.Dto;

namespace P004_EF_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly RestaurantContext _db;

        public DishesController(RestaurantContext db)
        {
            _db = db;
        }


        /// <summary>
        /// Feches disges in DB
        /// </summary>
        /// <returns>all dishes in DB</returns>
        [HttpGet("dishes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetDishDTO>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<GetDishDTO>> GetDishes()
        {
            return Ok(_db.Dishes
                .Include(d => d.RecipeItems)
                .Select(d => new GetDishDTO(d))
                .ToList());
        }

        /// <summary>
        /// Feches disges in DB with specified ID
        /// </summary>
        /// <returns>all dishes in DB with param</returns>
        [HttpGet("dishes/{id:int}", Name = "GetDish")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetDishDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetDishDTO> GetDishById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var dish = _db.Dishes
                .Include(d => d.RecipeItems)
                .FirstOrDefault(d => d.DishId == id);
            // Tam, kad istraukti duomenis naudokite
            // First, FirstOrDefault, Single, SingleOrDefault, ToList

            if (dish == null)
            {
                return NotFound();
            }

            return Ok(new GetDishDTO(dish));
        }

        [HttpPost("dishes")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
             
        public ActionResult<CreateDishDTO> CreateDish(CreateDishDTO dishDto)
        {
            if(dishDto == null)
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
                ImagePath = dishDto.ImagePath,

            };

            _db.Dishes.Add(model);
            _db.SaveChanges();

            return CreatedAtRoute("GetDish", new {id = model.DishId}, dishDto);
        }

        [HttpDelete("dishes/delete/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DeleteDish (int id)
        {

            if(id == 0)
            {
                return BadRequest();    
            }

            var dish = _db.Dishes.SingleOrDefault(d=>d.DishId== id);

            if(dish == null)
            { 
            return NotFound();  
            }

            _db.Dishes.Remove(dish);
            _db.SaveChanges();

            return NoContent();
        }



        [HttpPut("dishes/update/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult UpdateDish(int id, UpdateDishDTO updateDishDTO)
        {
            if (id == 0 || updateDishDTO == null)
            {
                return BadRequest();
            }

            var foundDish = _db.Dishes
                .FirstOrDefault(d => d.DishId == id);

            if (foundDish == null)
            {
                return NotFound();
            }

            foundDish.Name = updateDishDTO.Name;
            foundDish.ImagePath = updateDishDTO.ImagePath;
            foundDish.Type = updateDishDTO.Type;
            foundDish.SpiceLevel = updateDishDTO.SpiceLevel;
            foundDish.Country = updateDishDTO.Country;

            _db.Dishes.Update(foundDish);
            _db.SaveChanges();

            return NoContent();
        }
    }
}