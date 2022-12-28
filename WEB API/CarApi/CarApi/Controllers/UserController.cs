using CarApi.Models;
using CarApi.Models.Dto;
using CarApi.Repositories.Interfaces;
using CarApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordService _passwordService;
        private readonly IJwtService _jwtService;

        public UserController(IUserRepository userRepository,
            IPasswordService passwordService,
            IJwtService jwtService)
        {
            _userRepository = userRepository;
            _passwordService = passwordService;
            _jwtService = jwtService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginDto model)
        {
            var isOk = _userRepository.TryLogin(model.UserName, model.Password, out var user);
            if (!isOk)
                return Unauthorized("Bad username or password");

            var token = _jwtService.GetJwtToken(user.Id, user.Role);


            return Ok(new LoginResult { UserName = model.UserName, Token = token });
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] LocalUser model)
        {
            var isUserNameUnique = await _userRepository.IsUniqueUser(model.UserName);

            if (!isUserNameUnique)
            {
                return BadRequest(new { message = "Username already exists" });
            }

            var user = _userRepository.Register(model);

            if (user == null)
            {
                return BadRequest(new { message = "Error while registering" });
            }

            return Ok();
        }

    }

}


