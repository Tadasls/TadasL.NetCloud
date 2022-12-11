using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAppMSSQL.Data;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Services;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly KnygynasContext _db;
        private readonly IPasswordService _passwordService;
        private readonly IJwtService _jwtService;

        public UserRepository(KnygynasContext db, IPasswordService passwordService, IJwtService jwtService)
        {
            _db = db;
            _passwordService = passwordService;
            _jwtService = jwtService;
        }

        /// <summary>
        /// Should return a flag indicating if a user with a specified username already exists
        /// </summary>
        /// <param name="username">Registration username</param>
        /// <returns>A flag indicating if username already exists</returns>
        public bool IsUniqueUser(string username)
        {
            var user = _db.LocalUsers.FirstOrDefault(x => x.Username == username);
            if (user == null)
            {
                return true;
            }
            return false;
        }

        public LoginResponse Login(LoginRequest loginRequest)
        {
            var inputPasswordBytes = Encoding.UTF8.GetBytes(loginRequest.Password);
            var user = _db.LocalUsers.FirstOrDefault(x => x.Username.ToLower() == loginRequest.Username.ToLower());

            if (user == null && !_passwordService.VerifyPasswordHash(loginRequest.Password, user.PasswordHash, user.PasswordSalt))
            {
                return new LoginResponse
                {
                    Token = "",
                    User = null
                };
            }

            var token = _jwtService.GetJwtToken(user.Id, user.Role);

            LoginResponse loginResponse = new()
            {
                Token = token,
                User = user
            };

            loginResponse.User.PasswordHash = null;

            return loginResponse;
        }

        // Add RegistrationResponse (Should not include password)
        // Add adapter classes to map to wanted classes
        public LocalUser Register(RegistrationRequest registrationRequest)
        {
            _passwordService.CreatePasswordHash(registrationRequest.Password, out byte[] passwordHash, out byte[] passwordSalt);

            LocalUser user = new()
            {
                Username = registrationRequest.Username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Name = registrationRequest.Name,
                Role = registrationRequest.Role
            };

            _db.LocalUsers.Add(user);
            _db.SaveChanges();
            user.PasswordHash = null;
            return user;
        }
    }
}