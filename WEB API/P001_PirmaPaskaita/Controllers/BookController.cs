using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using Newtonsoft.Json;
using System.Data;
using System.Net.Mime;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.BookDTO;
using WebAppMSSQL.Models.Enums;
using WebAppMSSQL.Repository;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Services.IServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KnygynasController : ControllerBase
    {
        private readonly IBookWrapper _wrapper;
        private readonly ILogger<KnygynasController> _logger;
        private readonly IUpdateBookRepository _bookRepo;
        private readonly IUserNotificationService _userNotificationService;
        private readonly IReservationRepository _reservationRepo;
              
        public KnygynasController(IBookWrapper wrapper, IReservationRepository reservationRepo, IUserNotificationService userNotificationService, ILogger<KnygynasController> logger, IUpdateBookRepository bookRepo)
        {
            _wrapper = wrapper;
            _logger = logger;
            _bookRepo = bookRepo;
            _userNotificationService = userNotificationService;
            _reservationRepo = reservationRepo;
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
        public async Task<ActionResult<GetBookDto>> GetBookById(int id)
        {
            _logger.LogInformation("Metodas Get pagal (id = {0}) iskvietimo laikas buvo - {1} ", id, DateTime.Now);
            try
            {
                if (id == 0)
                {
                    _logger.LogError("Metodas Get GetBookById(id = {0}) nesuveike nes nebuvo nurodytas id tokiu laiku {1} ", id, DateTime.Now);
                    return BadRequest();
                }

                var book = await _bookRepo.GetAsync(a => a.Id == id);
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
        /// Get skirtas gauti visa knygų sarasa ir filtruoti
        /// </summary>
        /// <returns>?????????????????? ar sita vieta veikia ??????? </returns>
        /// <response code="200">gavus 200 reiskia kad uzklausa pavyko ir sekmingai grazintas rezultatas</response>
        /// <response code="500">500 serverio tipo klaidos.. Amen!</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(IEnumerable<CreateBookDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetBookDto>>> GetAll([FromQuery] FilterBooksRequestDto req)
        {
            _logger.LogInformation("Getting Books list with parameters {req}", JsonConvert.SerializeObject(req));
            
            IEnumerable<Book> entities = await _bookRepo.GetAllAsync(); //.ToList();

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
        /// Get skirtas gauti visa knygų sarasa ir filtruoti
        /// </summary>
        /// <returns>?????????????????? ar sita vieta veikia ??????? </returns>
        /// <response code="200">gavus 200 reiskia kad uzklausa pavyko ir sekmingai grazintas rezultatas</response>
        /// <response code="500">500 serverio tipo klaidos.. Amen!</response>
        [HttpGet("MegejamsIrAuksciau")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(IEnumerable<CreateBookDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<GetBookDto>>> GetAllBooksForUsers([FromQuery] FilterBooksRequestDto req)
        {
            _logger.LogInformation("Getting Books list with parameters {req}", JsonConvert.SerializeObject(req));

            IEnumerable<Book> entities = await _bookRepo.GetAllAsync(); //.ToList();

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
        /// kontroleris skirtas sukuria nauja knyga
        /// </summary>
        /// <param name="createBookDto">tai tra naujos Knygos objektas</param>
        /// <returns>Grazina rezultata greiciausiais kur niekas nemato... </returns>
        /// <response code="201">201 pranesimas reiskia kad Sekmingai į DB įrašyta nauja knyga</response>
        /// <response code="400">Blogas kreipimasis gautas</response>
        /// <response code="500">Baisi klaida! nes ji serverio</response>
        [HttpPost("CreateBook", Name = "CreateBook")]
        // [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(IEnumerable<CreateBookDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CreateBookDto>> CreateBook(CreateBookDto createBookDto)
        {

            if (createBookDto == null)
            {
                _logger.LogError("sukurimo iskvietimo laikas buvo - {1} negalejo sukurti iraso nes nebuvo  paduoti nauji duomenys", DateTime.Now);
                return BadRequest();
            }

            Book newBook = _wrapper.Bind(createBookDto);
           await _bookRepo.CreateAsync(newBook);

            _logger.LogInformation("sukurimo Metodas atliktas sekmingai, jo ivykdymo laikas buvo - {1} ", DateTime.Now);
            return CreatedAtRoute("CreateBook", new { id = newBook.Id }, createBookDto);
        }

        /// <summary>
        /// Atnaujiname knyga, siusdami knygos objekta
        /// </summary>
        /// <param name="bookUpdated">Knykos objektas su visais atnaujintais laukais</param>
        /// <returns></returns>
        /// <response code="204">Sekmingai atnaujinta knyga</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpPut("update")] //  /{id:int}
        //[Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(IEnumerable<CreateBookDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateBook(/*int id, */UpdateBookDto bookUpdated)
        {
            _logger.LogInformation("HttpPut UpdateBook(bookUpdated = {0}) buvo iskvietas {1} ", JsonConvert.SerializeObject(bookUpdated), DateTime.Now);
            try
            {
                if (/* id == 0 || */ bookUpdated == null)
                {
                    _logger.LogError("HttpPut UpdateBook(bookUpdated) bookUpdated objektas == null {1} ", DateTime.Now);
                    return BadRequest();
                }

                Book book = _wrapper.Bind(bookUpdated);
                _bookRepo.UpdateAsync(book);
                return NoContent();

            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpPut UpdateBook(bookUpdated = {0}) nuluzo {1} ", JsonConvert.SerializeObject(bookUpdated), DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        /// <summary>
        /// Atnaujiname knyga, siusdami knygos objekta
        /// </summary>
        /// <param name="bookActivated">Knykos objektas su visais atnaujintais laukais</param>
        /// <returns></returns>
        /// <response code="204">Sekmingai atnaujinta knyga</response>
        /// <response code="400">Blogas kreipimasis</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpPut("updateIvedimasISistema")] 
        //[Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(IEnumerable<CreateBookDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateBookActivate(ActivateBookDto bookActivated)
        {
            _logger.LogInformation("HttpPut ActivateBookDto(bookActivated = {0}) buvo iskvietas {1} ", JsonConvert.SerializeObject(bookActivated), DateTime.Now);
            try
            {
                if (bookActivated == null)
                {
                    _logger.LogError("HttpPut ActivateBookDto(bookActivated) bookUpdated objektas == null {1} ", DateTime.Now);
                    return BadRequest();
                }

                var UpdatedBook = await _bookRepo.GetAsync(d => d.Id == bookActivated.Id);
                if (UpdatedBook == null)
                {
                    return NotFound();
                }

                UpdatedBook.Id = bookActivated.Id;
                UpdatedBook.Updated = DateTime.Now;
                UpdatedBook.EBookStatus = (EBookStatus)Enum.Parse(typeof(EBookStatus), bookActivated.KnygosStatusas);
               
                Reservation? userBooksReservations = await _reservationRepo.GetAsync(r => r.BookId == bookActivated.Id);
                if (UpdatedBook.EBookStatus == EBookStatus.Registed && userBooksReservations != null)
                {
                    _userNotificationService.SukurtiPranesimaVartotojams(bookActivated.Id, userBooksReservations.LocalUserId);
                }
              

                await _bookRepo.UpdateAsync(UpdatedBook);

                return NoContent();

            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpPut ActivateBookDto(bookActivated = {0}) nuluzo {1} ", JsonConvert.SerializeObject(bookActivated), DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

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
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ActionResult))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteBookById(int id)
        {
            _logger.LogInformation("HttpDelete Metodas trinti pagal (id = {0}) buvo iskvietas tokiu laiku - {1} ", id, DateTime.Now);
            try
            {
                var book = await _bookRepo.GetAsync(b => b.Id == id);
                if (book == null)
                {
                    _logger.LogError("HttpDelete  Trinimo metodas pagal (id = {0}) knyga su tokiu id buvo nerasta {1} ", id, DateTime.Now);
                    return NotFound();
                }

               await _bookRepo.RemoveAsync(book);
             
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

