using L05_Tasks_MSSQL.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Data;
using System.Net;
using WebAppMSSQL.Interfaces;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.BookDTO;
using WebAppMSSQL.Models.Enums;
using WebAppMSSQL.Models.ReservationsDTO;
using WebAppMSSQL.Repository;
using WebAppMSSQL.Repository.IRepository;

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
       

        public ReservationController(IReservationRepository reservationRepo, ILogger<ReservationController> logger, IUserRepository userRepo, IUpdateBookRepository bookRepo)
        {
            _logger = logger;
            _userRepo = userRepo;
            _bookRepo = bookRepo;
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
        [HttpGet("GautiRezervacijaKnygaPagalId/{id:int}", Name = "GetReservation")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetReservationDTO>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetReservationDTO> GetReservationById(int id)
        {
            _logger.LogInformation("Metodas Get pagal (id = {0}) iskvietimo laikas buvo - {1} ", id, DateTime.Now);
            try
            {
                if (id == 0)
                {
                    _logger.LogError("Metodas Get GetBookById(id = {0}) nesuveike nes nebuvo nurodytas id tokiu laiku {1} ", id, DateTime.Now);
                    return BadRequest();
                }

                var reservation = _reservationRepo.Get(a => a.Id == id);
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

        public ActionResult<IEnumerable<GetReservationDTO>> GetAllReservations([FromQuery] FilterReservationDTO req) // cia yra filtravimo problema 
        {
           
            IEnumerable<Reservation> entities = _reservationRepo.GetAll().ToList();

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
        /// kontroleris skirtas sukuria nauja Rezervacija, ranka irasome grazinimo termina + 28d.!!!
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
        public ActionResult<CreateReservationDTO> CreateReservation(CreateReservationDTO createReservationDTO)
        {

            if (createReservationDTO == null)
            {
                _logger.LogError("sukurimo iskvietimo laikas buvo - {1} negalejo sukurti iraso nes nebuvo  paduoti nauji duomenys", DateTime.Now);
                return BadRequest();
            }

            var knygaPagalId = _bookRepo.Get(b => b.Id == createReservationDTO.BookId);
            if (knygaPagalId == null) return NotFound("Nera tokios knygos");

            var knyguKiekis = knygaPagalId.Stock;
            if (knyguKiekis == 0) return NotFound("Knygu neliko");

            double visoSkola = 0;
            double knygosSkola = 0;
             int skoluSkaicius = 0;

           IEnumerable<Reservation> entities = _reservationRepo.GetAll().ToList();
            foreach (var item in entities)
            {

                if (item.LocalUserId == createReservationDTO.LocalUserId)
                {
                    knygosSkola = item.DelayFine;
                    skoluSkaicius++;
                }
                visoSkola += knygosSkola;
            }

                var getUserDto = _userRepo.Get(b => b.Id == createReservationDTO.LocalUserId);
            if (getUserDto == null) return NotFound("nera tokio userio");

            if (getUserDto.HasAmountOfBooks >= 5) return Conflict("User has too many books taken already");
            if (skoluSkaicius >= 2) return Conflict("klientas jau turi 2 skolas"); 
            if (visoSkola >= 10) return Conflict("klientas jau skolingas daugiau nei 20 Eur"); 



            Reservation model = new Reservation()
            {
                BorrowDate = createReservationDTO.BorrowDate,
                ReturnDate = createReservationDTO.BorrowDate.AddDays(28),
                BookId = createReservationDTO.BookId,
                LocalUserId = createReservationDTO.LocalUserId,

              
            };
                       

             _reservationRepo.Create(model);

            _userRepo.UpdateTakenLibraryBooks(getUserDto.Id, 1);

            _bookRepo.UpdateTakenLibraryBooksKN(knygaPagalId.Id, -1);


            _logger.LogInformation("sukurimo Metodas atliktas sekmingai, jo ivykdymo laikas buvo - {1} ", DateTime.Now);
            return CreatedAtRoute("GetReservation", new { id = model.Id }, createReservationDTO);  
        }


        /// <summary>
        /// Redaguojame Rezervacijos informacija pagal nurodyta id galima pakeisti pasiskolino data, ir ivede grazinimo data pazymime kad grazinta
        /// </summary>
        /// <param name="id"> cia redaguojamos Rezervacijos pagal id,  </param>
        /// <param name="updateRezervationDto"> cia redaguojamos knygos info </param>
        /// <returns>Status code, kazkur jei rasime toky pranesima cia is kontrolerio balsas</returns>
        [HttpPut("{id}")]
        //[Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ActionResult))]
        public ActionResult UpdateReservation(int id, UpdateReservationDTO updateRezervationDto)
        {
            if (id == 0 || updateRezervationDto == null)
            {
                return BadRequest();
            }

            var foundReservation = _reservationRepo.Get(d => d.Id == id);

            if (foundReservation == null)
            {
                return NotFound();
            }

            //foundReservation.Id = updateRezervationDto.Id;
           // foundReservation.BorrowDate = updateRezervationDto.BorrowDate;
            foundReservation.ActualReturnDate = updateRezervationDto.ActualReturnDate;
           // foundReservation.LocalUserId = updateRezervationDto.LocalUserId;
          //foundReservation.BookId = updateRezervationDto.BookId;

            _reservationRepo.Update(foundReservation);
                      
            
            _userRepo.UpdateTakenLibraryBooks(updateRezervationDto.LocalUserId, -1);
            _bookRepo.UpdateTakenLibraryBooksKN(updateRezervationDto.BookId, 1);


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
        public ActionResult DeleteReservationById(int id)
        {
            _logger.LogInformation("HttpDelete Metodas trinti pagal (id = {0}) buvo iskvietas tokiu laiku - {1} ", id, DateTime.Now);
            try
            {
                var reservation = _reservationRepo.Get(b => b.Id == id);
                if (reservation == null)
                {
                    _logger.LogError("HttpDelete  Trinimo metodas pagal (id = {0}) knyga su tokiu id buvo nerasta {1} ", id, DateTime.Now);
                    return NotFound();
                }

                _reservationRepo.Remove(reservation);

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
