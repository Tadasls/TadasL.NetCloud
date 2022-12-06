using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Models.Enums;
using L05_Tasks_MSSQL.Services;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebAppMSSQL.Repository;
using WebAppMSSQL.Repository.IRepository;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KnygynasController : ControllerBase
    {

        //private readonly KnygynasContext _knygynasDB;
        private readonly IBookWrapper _wrapper;
        private readonly ILogger<KnygynasController> _logger;
        private readonly IUpdateBookRepository _bookRepo;

        //KnygynasContext knyguDB,

        public KnygynasController(IBookWrapper wrapper, ILogger<KnygynasController> logger, IUpdateBookRepository bookRepo)
        {
            //_knygynasDB = knyguDB;
            _wrapper = wrapper;
            _logger = logger;
            _bookRepo = bookRepo;
        }



        /// <summary>
        /// Metodas sugrazina viena knyga is duomenu bazes pagal paduota id
        /// </summary>
        /// <param name="id">ieskomos knygos paduotas id</param>
        /// <returns>Grazina rezultata??? ar veikia dar nezinom</returns>
        /// <response code="200">VISKAS OK jei 200, sekmingai rasta ir grazinta ieskoma knyga pagal id</response>
        /// <response code="400">buvo gautas blogas kreipimasis</response>
        /// <response code="404">Toks puslapis/adresas nerastas</response>
        /// <response code="500">Ciua jau serverio klaidos kodas!</response>
        [HttpGet("GautiKonkreciaKnygaPagalId/{id:int}", Name = "GetBook")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetBookDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetBookDto> GetBookById(int id)
        {
            _logger.LogInformation("Metodas Get pagal (id = {0}) iskvietimo laikas buvo - {1} ", id, DateTime.Now);
            try
            {
                if (id == 0)
                {
                    _logger.LogError("Metodas Get GetBookById(id = {0}) nesuveike nes nebuvo nurodytas id tokiu laiku {1} ", id, DateTime.Now);
                    return BadRequest();
                }

                var book = _bookRepo.Get(a => a.Id == id);
                if (book == null)
                {
                    _logger.LogError("Get GetBookById(id = {0}) knyga su tokiu id nerasta {1} ", id, DateTime.Now);
                    return BadRequest();
                }

                _logger.LogInformation("paieskos metodas su surastu rezultatu pagal (id = {0})  buvo įvykdytas tokiu metu {1} ",id, DateTime.Now);
                return Ok(_wrapper.Bind(book));

            }
            catch (Exception e)
            {
                _logger.LogError(e, "Metodas Get gauti Knyga pagal id(id = {0}) nuluzo del serverio klaidos tokiu laiku - {1} ", id, DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// kontroleris skirtas sukuria nauja knyga
        /// </summary>
        /// <param name="createBookDto">tai tra naujos Knygos objektas</param>
        /// <returns>Grazina rezultata greiciausiais kur niekas nemato... </returns>
        /// <response code="201">201 pranesimas reiskia kad Sekmingai į DB įrašyta nauja knyga</response>
        /// <response code="400">Blogas kreipimasis gautas</response>
        /// <response code="500">Baisi klaida! nes ji serverio</response>
        [HttpPost("CreateBook")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(IEnumerable<CreateBookDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CreateBookDto> CreateBook(CreateBookDto createBookDto)
        {
            if (createBookDto == null)
            {
                _logger.LogError("sukurimo iskvietimo laikas buvo - {1} negalejo sukurti iraso nes nebuvo  paduoti nauji duomenys", DateTime.Now);
                return BadRequest();
            }

            Book newBook = _wrapper.Bind(createBookDto);
            _bookRepo.Create(newBook);

            _logger.LogInformation("sukurimo Metodas atliktas sekmingai, jo ivykdymo laikas buvo - {1} ", DateTime.Now);
            return CreatedAtRoute("GetBook", new { id = newBook.Id }, createBookDto);
        }




        /// <summary>
        /// Get skirtas gauti visa knygų sarasa ir filtruoti
        /// </summary>
        /// <returns>?????????????????? ar sita vieta veikia ??????? </returns>
        /// <response code="200">gavus 200 reiskia kad uzklausa pavyko ir sekmingai grazintas rezultatas</response>
        /// <response code="500">500 serverio tipo klaidos.. Amen!</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(IEnumerable<CreateBookDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<GetBookDto>> Get([FromQuery] FilterBooksRequestDto req)
        {

            _logger.LogInformation("Getting Books list with parameters {req}", JsonConvert.SerializeObject(req));

            IEnumerable<Book> entities = _bookRepo.GetAll().ToList();

            if (req.Autorius != null)
                entities = entities.Where(x => x.Author == req.Autorius);

            if (req.Pavadinimas != null)
                entities = entities.Where(x => x.Title == req.Pavadinimas);

            if (req.KnygosTipas != null)
                entities = entities.Where(x => x.ECoverType == (ECoverType)Enum.Parse(typeof(ECoverType), req.KnygosTipas));


            var model = entities?.Select(x => _wrapper.Bind(x));

            return Ok(model);

        }




        /// <summary>
        /// Redaguojame Knygos informacija pagal nurodyta id
        /// </summary>
        /// <param name="id"> cia redaguojamos knygos id </param>
        /// <returns>Status code, kazkur jei rasime toky pranesima cia is kontrolerio balsas</returns>
        [HttpPut("{id}")]
        public ActionResult UpdateBook(int id, UpdateBookDto updateBookDto)
        {
            if (id == 0 || updateBookDto == null)
            {
                _logger.LogError("Redagavimo Metodas pagal nurodyta (id = {0}) kurio iskvietimo laikas buvo - {1} nesurado nurodyto id arba nebuvo uzpildyti duomenys", id, DateTime.Now);
                return BadRequest();
            }

            var foundBook = _bookRepo.Get(d => d.Id == id);

            if (foundBook == null)
            {
                _logger.LogError("Redagavimo Metodas pagal nurodyta (id = {0}) kurio iskvietimo laikas buvo - {1} nesurado nurodyto id", id, DateTime.Now);
                return NotFound();
            }

            foundBook.Author = updateBookDto.Autorius;
            foundBook.Title = updateBookDto.Pavadinimas;
            foundBook.ECoverType = (ECoverType)Enum.Parse(typeof(ECoverType), updateBookDto.KnygosTipas);
            foundBook.PublishYear = updateBookDto.Isleista.Year;

            _bookRepo.Update(foundBook);
           
            _logger.LogInformation("Redagavimo Metodas atliktas sekmingai pagal nurodyta (id = {0}) iskvietimo laikas buvo - {1} ", id, DateTime.Now);
            return NoContent();
          
        }

        /// <summary>
        /// Trinama knyga is duomenu bases pagal nurodoma id
        /// </summary>
        /// <param name="id"> trinamos knygos id</param>
        /// <returns>Grazina rezultata, maybe ??? </returns>
        /// <response code="204">Sekmingai ivykdytas trynimas </response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="404">Nerastas adresas</response>
        /// <response code="500">Ziauri serverio klaida!</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ActionResult))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult DeleteBookById(int id)
        {
            _logger.LogInformation("HttpDelete Metodas trinti pagal (id = {0}) buvo iskvietas tokiu laiku - {1} ", id, DateTime.Now);
            try
            {
                var book = _bookRepo.Get(b => b.Id == id);
                if (book == null)
                {
                    _logger.LogError("HttpDelete  Trinimo metodas pagal (id = {0}) knyga su tokiu id buvo nerasta {1} ", id, DateTime.Now);
                    return NotFound();
                }

                _bookRepo.Remove(book);
             
                _logger.LogInformation("HttpDelete Metodas trinti pagal (id = {0}) buvo iskvietas ir ivykdytas  tokiu laiku - {1} ", id, DateTime.Now);
                return NoContent();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpDelete Trinimo metodas pagal (id = {0}) nuluzo  tokiu laiku - {1} ", id, DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}

