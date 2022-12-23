using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO;
using WebAppMSSQL.Models.DTO.BookDTO;
using WebAppMSSQL.Models.DTO.ReservationsDTO;
using WebAppMSSQL.Models.DTO.UserTDO;
using WebAppMSSQL.Models.ReservationsDTO;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Services;
using WebAppMSSQL.Services.IServices;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;
        private readonly IUpdateBookRepository _bookRepo;
        private readonly IDebtsService _debtsService;
        private readonly IReservationRepository _reservationRepository;
        private readonly IUserHelpService _userHelpService;
        private readonly IStockService _stockService;
        private readonly IMembershipService _membersService;

        public UserController(IUserRepository userRepo, IMembershipService membersService, IStockService stockService, IUpdateBookRepository bookUpdateRepository, IDebtsService debtsService, IReservationRepository reservationRepository, IUserHelpService userHelpService)
        {
            _userRepo = userRepo;
            _bookRepo = bookUpdateRepository;
            _debtsService = debtsService;
            _reservationRepository = reservationRepository;
            _userHelpService = userHelpService;
            _stockService = stockService;
            _membersService = membersService;
        }

        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ActionResult))]
        public async Task<IActionResult> Login([FromBody] LoginRequest model)
        {
            var loginResponse = await _userRepo.LoginAsync(model);

            if (loginResponse.User == null || string.IsNullOrEmpty(loginResponse.Token))
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }

            return Ok(loginResponse);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequest model)
        {
            var isUserNameUnique = await _userRepo.IsUniqueUserAsync(model.Username);

            if (!isUserNameUnique)
            {
                return BadRequest(new { message = "Username already exists" });
            }

            var user = await _userRepo.RegisterAsync(model);

            if (user == null)
            {
                return BadRequest(new { message = "Error while registering" });
            }

            return Ok();
        }
        [HttpGet("Get/{id:int}")]
        public async Task<ActionResult<GetUserDto>> GetUserById(int id)
        {
            if (id == 0)
            {
                return BadRequest("nera tokio ID");
            }
            var user = await _userRepo.GetAsync(u => u.Id == id);
            if (user == null)
            {
                return NotFound("nera tokio vartotojo");
            }

            return Ok(user);
        }
        [HttpGet("FavoriteAuthors")] 
        public async Task<ActionResult<List<GetBookDto>>?>GetFavoriteAutorsForUser(int id)
        {
            var allUserReservations = await _reservationRepository.GetAllAsync(r => r.LocalUserId == id);
           // var userioKnyga = await _bookRepo.GetAsync(a => a.Id == id);
            var favoriteAuthor = await _userHelpService.GetFavoriteAutorsForUser(id, allUserReservations);


            return Ok(favoriteAuthor);
        }
        [HttpGet("UserioSkolosDydis")]  
        public async Task<double> GetSkolkasUsersio(int id)
        {
            var allUserReservations = await _reservationRepository.GetAllAsync(r => r.LocalUserId == id);
            int praterminuotosDienos = await _debtsService.CountDelayDays(id, allUserReservations);
            double useriosSkola = _debtsService.SuskaiciuotiSkolosDydi(praterminuotosDienos);
            return useriosSkola;
        }

        [HttpGet("GautiVipBonusa")]
        public async Task GautiVipBonusa(int id)
        {
            var user = await _userRepo.GetAsync(u => u.Id == id);
            await _membersService.PridetiTaskuUzPrisijungimaVIPBONUS(user.Id);
        }






    }
}
