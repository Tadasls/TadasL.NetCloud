using L05_Tasks_MSSQL.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.ComponentModel.Design;
using System.Data;
using System.Net;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.BookDTO;
using WebAppMSSQL.Models.Enums;
using WebAppMSSQL.Models.ReservationsDTO;
using WebAppMSSQL.Repository;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Services;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IUpdateBookRepository _bookRepo;
        private readonly IUserRepository _userRepo;
        private readonly IReservationRepository _reservationRepo;
        private readonly ILogger<ReservationController> _logger;
        private readonly IStockService _stockService;
        private readonly IDebtsService _debtsService;
        private readonly IReservationWrapper _reservationWrapper;
        private readonly IUserHelpService _userHelpService;



        public ReservationController(IReservationRepository reservationRepo, ILogger<ReservationController> logger, 
            IUserRepository userRepo, IUpdateBookRepository bookRepo, IStockService stockService, IDebtsService debtsService, IReservationWrapper reservationWrapper, IUserHelpService userHelpService)
        {
            _logger = logger;
            _userRepo = userRepo;
            _bookRepo = bookRepo;
            _reservationRepo = reservationRepo;
            _stockService = stockService;
            _debtsService = debtsService;
            _reservationWrapper = reservationWrapper;
            _userHelpService = userHelpService;
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
        [HttpGet("GautiRezervacijaKnygaPagalId/{id:int}", Name = "GetReservation")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetReservationDTO>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetReservationDTO>> GetReservationById(int id)
        {
            _logger.LogInformation("Metodas Get pagal (id = {0}) iskvietimo laikas buvo - {1} ", id, DateTime.Now);
            try
            {
                if (id == 0)
                {
                    _logger.LogError("Metodas Get GetBookById(id = {0}) nesuveike nes nebuvo nurodytas id tokiu laiku {1} ", id, DateTime.Now);
                    return BadRequest();
                }

                var reservation = await _reservationRepo.GetAsync(a => a.Id == id);
                if (reservation == null)
                {
                    _logger.LogError("Get GetBookById(id = {0}) knyga su tokiu id nerasta {1} ", id, DateTime.Now);
                    return BadRequest();
                }

                _logger.LogInformation("paieskos metodas su surastu rezultatu pagal (id = {0})  buvo įvykdytas tokiu metu {1} ", id, DateTime.Now);
                return Ok(reservation);

            }
            catch (Exception e)
            {
                _logger.LogError(e, "Metodas Get gauti Knyga pagal id(id = {0}) nuluzo del serverio klaidos tokiu laiku - {1} ", id, DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        /// <summary>
        /// Get skirtas gauti visa rez sarasa ir filtruoti
        /// </summary>
        /// <returns>?????????????????? ar sita vieta veikia ??????? </returns>
        /// <response code="200">gavus 200 reiskia kad uzklausa pavyko ir sekmingai grazintas rezultatas</response>
        /// <response code="500">500 serverio tipo klaidos.. Amen!</response>
        [HttpGet("GautiVisasRezervacijas")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(IEnumerable<GetReservationDTO>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<IEnumerable<GetReservationDTO>>> GetAllReservations([FromQuery] FilterReservationDTO req) // cia yra filtravimo problema 
        {

            IEnumerable<Reservation> entities = await _reservationRepo.GetAllAsync();  //.ToList();

            if (entities == null)
            {
                return BadRequest("nera galiojanciu rezervaciju");
            }


            if (req.LocalUserId != null)
                entities = entities.Where(x => x.LocalUserId == req.LocalUserId);

            if (req.BookId != null)
                entities = entities.Where(x => x.BookId == req.BookId);

            if (req.ReturnDate != null)
               entities = entities.Where(x => x.ReturnDate == req.ReturnDate);

            if (req.BorrowDate != null)
               entities = entities.Where(x => x.BorrowDate == req.BorrowDate);


            var model = entities?.Select(x => x);

            return Ok(model);


        }


        /// <summary>
        /// kontroleris skirtas sukuria nauja Rezervacija!!!
        /// </summary>
        /// <param name="createReservationDTO">tai tra naujos Rezervacijos objektas</param>
        /// <returns>Grazina rezultata greiciausiais kur niekas nemato... </returns>
        /// <response code="201">201 pranesimas reiskia kad Sekmingai į DB įrašyta nauja Rezervacija</response>
        /// <response code="400">Blogas kreipimasis gautas</response>
        /// <response code="500">Baisi klaida! nes ji serverio</response>
        [HttpPost("CreateReservation")]
        //[Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(IEnumerable<CreateReservationDTO>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CreateReservationDTO>> CreateReservation(CreateReservationDTO createReservationDTO)
        {

            //validacija jei nera uzklausos duomenu
            if (createReservationDTO == null)
            {
                _logger.LogError("sukurimo iskvietimo laikas buvo - {1} negalejo sukurti iraso nes nebuvo  paduoti nauji duomenys", DateTime.Now);
                return BadRequest();
            }

            //validacijos jei arba nera tokios knygos id arba ju likutis per mazas 
            bool arYraTokiaKnyga = _bookRepo.Exist(createReservationDTO.BookId);
            if (!arYraTokiaKnyga) return NotFound("Nera tokios knygos");

            //exist
            var knygaPagalId = await _bookRepo.GetAsync(b => b.Id == createReservationDTO.BookId);
            if (knygaPagalId.Stock == 0) return NotFound("Knygu neliko");

            // validacijos ar yra useris ir ar jis turi leistina skaiciu knygu
            bool arYtaToksvartotojas = _userRepo.Exist(createReservationDTO.LocalUserId);
            if (!arYtaToksvartotojas) return NotFound("nera tokio userio");

            var useris = await _userRepo.GetAsync(u => u.Id == createReservationDTO.LocalUserId);
            if (useris.HasAmountOfBooks >= 5) return Conflict("User has too many books taken already");
                                      
            
             //skolu servisas

            int skoluSkaicius = 0;
            double visoSkola = 0;
            int kiekDienuVeluoja = 0;

             kiekDienuVeluoja =await _debtsService.SuskaiciuotiKiekDienuVeluojamaGrazinti(createReservationDTO.LocalUserId);

             visoSkola = _debtsService.SuskaiciuotiSkolosDydi(kiekDienuVeluoja);
             if (visoSkola >= 10) return Conflict("klientas jau skolingas daugiau nei 20 Eur");

             skoluSkaicius = await _debtsService.SuskaiciuotiKiekTuriSkolu(createReservationDTO.LocalUserId);
            if (skoluSkaicius >= 2) return Conflict("klientas jau turi 2 skolas");

         

            // skoluSkaicius = await _debtsService.GautiSkoluSkaiciuMetodas(createReservationDTO);
            // visoSkola = await _debtsService.GautiSkolosDydiMetodas(createReservationDTO);


            //naujos rezervacijos sukurimas
            Reservation model = new Reservation()
            {
                BorrowDate = createReservationDTO.BorrowDate,
                ReturnDate = createReservationDTO.BorrowDate.AddDays(28),
                BookId = createReservationDTO.BookId,
                LocalUserId = createReservationDTO.LocalUserId,
                Active = true,

        };
             await _reservationRepo.CreateAsync(model);
            
            
            //likuciu servisas
            _stockService.UpdateTakenLibraryBooks(createReservationDTO.LocalUserId, 1);
            _stockService.UpdateTakenLibraryBooksKN(knygaPagalId.Id, -1);

            _logger.LogInformation("sukurimo Metodas atliktas sekmingai, jo ivykdymo laikas buvo - {1} ", DateTime.Now);
            return CreatedAtRoute("GetReservation", new { id = model.Id }, createReservationDTO);  
        }


        /// <summary>
        /// Redaguojame Rezervacijos informacija pagal nurodyta id galima pakeisti pasiskolino data, ir ivede grazinimo data pazymime kad grazinta
        /// </summary>
        /// <param name="id"> cia redaguojamos Rezervacijos pagal id,  </param>
        /// <param name="updateRezervationDto"> cia redaguojamos knygos info </param>
        /// <returns>Status code, kazkur jei rasime toky pranesima cia is kontrolerio balsas</returns>
        [HttpPut("Grazinimas")]   //"{id}"
        //[Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ActionResult))]
        public async Task<ActionResult> UpdateReservation(int id, ReturnReservationDTO returnReservationDto)
        {
            if (id == 0 || returnReservationDto == null)
            {
                return BadRequest();
            }

            var foundReservation = await _reservationRepo.GetAsync(d => d.Id == id);
            if (foundReservation == null)
            {
                return NotFound();
            }

            //var reservation = _reservationWrapper.KonvertuokiDuomenis(returnReservationDto);

            foundReservation.ActualReturnDate = returnReservationDto.ActualReturnDate;
            foundReservation.LocalUserId = returnReservationDto.LocalUserId;
            foundReservation.BookId = returnReservationDto.BookId;
            foundReservation.Active = false;

            await _reservationRepo.UpdateAsync(foundReservation);

            _stockService.UpdateTakenLibraryBooks(returnReservationDto.LocalUserId, -1);
            _stockService.UpdateTakenLibraryBooksKN(returnReservationDto.BookId, 1);

            return NoContent();

        }


        /// <summary>
        /// Trinama Rezervacija is duomenu bases pagal nurodoma id
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
        public async Task<ActionResult> DeleteReservationById(int id)
        {
            _logger.LogInformation("HttpDelete Metodas trinti pagal (id = {0}) buvo iskvietas tokiu laiku - {1} ", id, DateTime.Now);
            try
            {
                var reservation =await _reservationRepo.GetAsync(b => b.Id == id);
                if (reservation == null)
                {
                    _logger.LogError("HttpDelete  Trinimo metodas pagal (id = {0}) knyga su tokiu id buvo nerasta {1} ", id, DateTime.Now);
                    return NotFound();
                }

               await _reservationRepo.RemoveAsync(reservation);

                _logger.LogInformation("HttpDelete Metodas trinti pagal (id = {0}) buvo iskvietas ir ivykdytas  tokiu laiku - {1} ", id, DateTime.Now);
                return NoContent();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "HttpDelete Trinimo metodas pagal (id = {0}) nuluzo  tokiu laiku - {1} ", id, DateTime.Now);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }



        //[HttpGet("FavoriteAuthors/{id:int}")]
        //public async Task<ActionResult<IOrderedEnumerable<IGrouping<string, GetBookDto>>?>> GetFavoriteAutors(int id)
        //{


        //    var favoriteAuthors = await _userHelpService.GetFavoriteAutorsForUser(id);

        //    return Ok(favoriteAuthors);
        //}



      






    }
}
