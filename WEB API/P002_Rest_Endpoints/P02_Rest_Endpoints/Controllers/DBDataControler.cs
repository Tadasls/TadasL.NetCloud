using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P02_Rest_Endpoints.Data;
using P02_Rest_Endpoints.Models;
using P02_Rest_Endpoints.Models.Dto;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;

namespace P02_Rest_Endpoints.Controllers
{
    [Route("api2/[controller]")]
    [ApiController]
    public class DBdataController : ControllerBase
    {

        private readonly DataContex _db;

        public DBdataController(DataContex db)
        {
            _db = db;
        }

           
        /// <summary>
        /// Feches disges in DB
        /// </summary>
        /// <returns>all dishes in DB</returns>
        [HttpGet("get")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<DataDTO>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<DataDTO>> GetDatas()
        {
            return Ok(_db.Duomenys
                .Select(d => new DataDTO(d))
                .ToList());
        }


        /// <summary>
        /// Feches disges in DB with specified ID
        /// </summary>
        /// <returns>all dishes in DB with param</returns>
        [HttpGet("data/{id:int}", Name = "GetData")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DataDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<DataDTO> GetDataById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var duomenys = _db.Duomenys
                .FirstOrDefault(d => d.Id == id);
            // Tam, kad istraukti duomenis naudokite
            // First, FirstOrDefault, Single, SingleOrDefault, ToList

            if (duomenys == null)
            {
                return NotFound();
            }

            return Ok(new DataDTO(duomenys));
        }

        [HttpPost("NewData")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<CreateDataDto> CreateDish(CreateDataDto dataDto)
        {
            if (dataDto == null)
            {
                return BadRequest();
            }

            DBData model = new DBData()
            {
               
                Type = dataDto.Type,
                Content = dataDto.Content,
                EndDate = dataDto.EndDate,
                UserId = dataDto.UserId

         
        };

            _db.Duomenys.Add(model);
            _db.SaveChanges();

            return CreatedAtRoute("GetData", new { Id = model.UserId}, dataDto);
        }


        [HttpDelete("data/delete/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DeleteData(int id)
        {

            if (id == 0)
            {
                return BadRequest();
            }

            var dish = _db.Duomenys.SingleOrDefault(d => d.Id == id);

            if (dish == null)
            {
                return NotFound();
            }

            _db.Duomenys.Remove(dish);
            _db.SaveChanges();

            return NoContent();
        }

        [HttpPut("dishes/update/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult UpdateData(int id, UpdateDataDto updatedataDto)
        {
            if (id == 0 || updatedataDto == null)
            {
                return BadRequest();
            }

            var atnaujintiDuomenys = _db.Duomenys
                .FirstOrDefault(d => d.Id == id);

            if (atnaujintiDuomenys == null)
            {
                return NotFound();
            }
                 
            atnaujintiDuomenys.Type = updatedataDto.Type;
            atnaujintiDuomenys.Content = updatedataDto.Content;
            atnaujintiDuomenys.EndDate = updatedataDto.EndDate;

            _db.Duomenys.Update(atnaujintiDuomenys);
            _db.SaveChanges();

            return NoContent();
        }










    }
}
