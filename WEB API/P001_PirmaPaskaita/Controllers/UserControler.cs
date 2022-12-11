using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppMSSQL.Models.DTO;
using WebAppMSSQL.Repository.IRepository;

namespace L05_Tasks_MSSQL.Controllers
{

    // knyga grazinta per 4 sav. // prie knygos propercio dateTime -  paskolinimo laikas ? ir Baudos kastai double DelayFine pavelavimo kastai 
    // klientas skolinasi iki 5 knygu /  knygu kiekis bibliotekoje  user list of books
    // kliento pasiskolintos knygu krepselis ?  user list of books
    // sekretore administruoja knygu skaiciu.. updatina book Qnt



    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;

        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest model)
        {
            var loginResponse = _userRepo.Login(model);

            if (loginResponse.User == null || string.IsNullOrEmpty(loginResponse.Token))
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }

            return Ok(loginResponse);
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegistrationRequest model)
        {
            var isUserNameUnique = _userRepo.IsUniqueUser(model.Username);

            if (!isUserNameUnique)
            {
                return BadRequest(new { message = "Username already exists" });
            }

            var user = _userRepo.Register(model);

            if (user == null)
            {
                return BadRequest(new { message = "Error while registering" });
            }

            return Ok();
        }
    }
}
