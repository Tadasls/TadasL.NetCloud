using L05_Tasks_MSSQL.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Net;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.BookDTO;
using WebAppMSSQL.Models.DTO.ReservationsDTO;
using WebAppMSSQL.Models.DTO.UserTDO;
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
     
        private readonly IMembershipService _membersService;

        public ReservationController(IReservationRepository reservationRepo, IMembershipService membersService,  ILogger<ReservationController> logger, 
            IUserRepository userRepo, IUpdateBookRepository bookRepo, IStockService stockService, IDebtsService debtsService, IReservationWrapper reservationWrapper)
        {
            _logger = logger;
            _userRepo = userRepo;
            _bookRepo = bookRepo;
            _reservationRepo = reservationRepo;
            _stockService = stockService;
            _debtsService = debtsService;
            _reservationWrapper = reservationWrapper;
          
            _membersService = membersService;
        }

        /// <summary>
        /// Metodas sugrazina viena knyga is duomenu bazes pagal paduota id
        /// </summary>
        /// <returns>Grazina rezultata??? ar veikia dar nezinom</returns>
        /// <response code="200">VISKAS OK jei 200, sekmingai rasta ir grazinta ieskoma knyga pagal id</response>
        /// <response code="400">buvo gautas blogas kreipimasis</response>
        /// <response code="404">Toks puslapis/adresas nerastas</response>
        /// <response code="500">Ciua jau serverio klaidos kodas!</response>
        [HttpGet("GautiRezervacijaPagal", Name = "GetReservation")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetReservationResponse>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetReservationResponse>> GetReservationById([FromQuery] CreateReservationRequest model)
        {
            _logger.LogInformation("Metodas Get pagal (model = {0}) iskvietimo laikas buvo - {1} ", model, DateTime.Now);
            try
            {
                if (model.LocalUserId == 0 || model.BookId==0)
                {
                    _logger.LogError("Metodas Get GetBookById(model = {0}) nesuveike nes nebuvo nurodytas id tokiu laiku {1} ", model, DateTime.Now);
                    return BadRequest();
                }
                var isReservated = await _reservationRepo.ExistAsync(r=>r.LocalUserId== model.LocalUserId && r.BookId == model.BookId);
                if (!isReservated)
                {
                    _logger.LogError("Get GetBookById(model = {0}) knyga su tokiu id nerasta {1} ", model, DateTime.Now);
                    return NotFound();
                }

                _logger.LogInformation("paieskos metodas su surastu rezultatu pagal (id = {0})  buvo įvykdytas tokiu metu {1} ", model, DateTime.Now);
               
                var reservation =await _reservationRepo.GetAsync(r=>r.LocalUserId== model.LocalUserId && r.BookId == model.BookId);
                var response = _reservationWrapper.Bind(reservation);
                return Ok(response);

            }
            catch (Exception e)
            {
                _logger.LogError(e, "Metodas Get gauti Knyga pagal id(model = {0}) nuluzo del serverio klaidos tokiu laiku - {1} ", model, DateTime.Now);
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
        /// <param name="CreateReservation">tai tra naujos Rezervacijos objektas</param>
        /// <returns>Grazina rezultata greiciausiais kur niekas nemato... </returns>
        /// <response code="201">201 pranesimas reiskia kad Sekmingai į DB įrašyta nauja Rezervacija</response>
        /// <response code="400">Blogas kreipimasis gautas</response>
        /// <response code="500">Baisi klaida! nes ji serverio</response>
        [HttpPost("CreateReservation", Name = "CreateReservation")]
        //[Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(IEnumerable<CreateReservationDTO>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CreateReservationDTO>> CreateReservation([FromBody]CreateReservationDTO request)
        {
            //validacija jei nera uzklausos duomenu
            if (request == null || request.LocalUserId == 0 || request.BookId ==0)
            {
                _logger.LogError("sukurimo iskvietimo laikas buvo - {1} negalejo sukurti iraso nes nebuvo  paduoti nauji duomenys", DateTime.Now);
                return BadRequest(request);
            }

            // validacijos ar yra useris
            bool userExists = await _userRepo.IsRegisteredAsync(request.LocalUserId);
            if (!userExists) return NotFound("nera tokio userio");

            //validacija ar yra tokia knyga 
            bool arYraTokiaKnyga = await _bookRepo.ExistAsync(b => b.Id == request.BookId);
            if (!arYraTokiaKnyga) return NotFound("Nera tokios knygos");

            //validacija ar yra knygos likuciai 
            var knygaPagalId = await _bookRepo.GetAsync(b => b.Id == request.BookId);
            if (knygaPagalId.Stock == 0) return NotFound("Knygu neliko");

            // validacijos ar yra useris turi leistina skaiciu knygu
            var useris = await _userRepo.GetAsync(u => u.Id == request.LocalUserId);
            if (useris.HasAmountOfBooks >= 5) return Conflict("Useris jau turi knygu limita pasiekta ");


            //skolu servisas
            var allReservations = await _reservationRepo.GetAllAsync(r => r.LocalUserId == request.LocalUserId);
            var kiekDienuVeluoja = await _debtsService.CountDelayDays(request.LocalUserId, allReservations);
            var visoSkola = _debtsService.SuskaiciuotiSkolosDydi(kiekDienuVeluoja);
            if (visoSkola >= 10) return Conflict("klientas jau skolingas daugiau nei 20 Eur");

            var debtsNumber = await _debtsService.CountDebtsAmount(request.LocalUserId, allReservations);
            if (debtsNumber >= 2) return Conflict("klientas jau turi 2 skolas");

            var reservatedBook = await _bookRepo.GetAsync(b => b.Id == request.BookId);
            var response = _reservationWrapper.Bind(reservatedBook); // atiduodam kaip rezervacijos pasekme
            var newReservation = _reservationWrapper.Bind(request); //transformuojame rezervacija
            await _reservationRepo.CreateAsync(newReservation); // irasome nauja rezervacija

            //likuciu servisas
            await _stockService.UpdateTakenLibraryBooks(request.LocalUserId, 1);
            await _stockService.UpdateTakenLibraryBooksKN(knygaPagalId.Id, -1);

            _logger.LogInformation("sukurimo Metodas atliktas sekmingai, jo ivykdymo laikas buvo - {1} ", DateTime.Now);
            return CreatedAtRoute("GetReservation", new { LocalUserId = request.LocalUserId, BookId = request.BookId }, response);
           
        }

        /// <summary>
        /// Redaguojame Rezervacijos informacija pagal nurodyta id galima pakeisti pasiskolino data, ir ivede grazinimo data pazymime kad grazinta
        /// </summary>
        /// <param name="id"> cia redaguojamos Rezervacijos pagal id,  </param>
        /// <param name="updateRezervationDto"> cia redaguojamos knygos info </param>
        /// <returns>Status code, kazkur jei rasime toky pranesima cia is kontrolerio balsas</returns>
        [HttpPost("Grazinimas")]   //"{id}"
        //[Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ActionResult))]
        public async Task<ActionResult> UpdateReservation(int id, ReturnReservationDTO request)
        {
            if (id == 0 || request == null)
            {
                return BadRequest();
            }

            var foundReservation = await _reservationRepo.GetAsync(d => d.Id == id);
            if (foundReservation == null)
            {
                return NotFound();
            }
            var useris = await _userRepo.GetAsync(u => u.Id == request.LocalUserId);
            var allUserReservations = await _reservationRepo.GetAllAsync(r => r.LocalUserId == request.LocalUserId);
            var vienosKnygosSkola = await _debtsService.VienosKnygosSkola(request.BookId, allUserReservations);

            if (request.PaidWithPoints > Convert.ToInt32(vienosKnygosSkola))
            {
                return BadRequest("Negalima sumoketi daugiau nei 99 proc sumos taskais");
            }
            if (Convert.ToInt32(vienosKnygosSkola) < request.PaidWithPoints) return NotFound("Mokama suma viršija skolą!");
            if (useris.Points < request.PaidWithPoints) return NotFound("Vartotojas neturi tiek \"Taškų\"!");

            //var reservation = _reservationWrapper.Bind(returnReservationDto);

            foundReservation.ActualReturnDate = request.ActualReturnDate;
            foundReservation.LocalUserId = request.LocalUserId;
            foundReservation.BookId = request.BookId;
            foundReservation.Active = false;
            foundReservation.PaidWithPoints = request.PaidWithPoints;

           await _reservationRepo.UpdateAsync(foundReservation);
           await _membersService.PanaudotiTaskusUzSkolas(request.LocalUserId, request.PaidWithPoints);
           await _stockService.UpdateTakenLibraryBooks(request.LocalUserId, -1);
           await _stockService.UpdateTakenLibraryBooksKN(request.BookId, 1);

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







      






    }
}
