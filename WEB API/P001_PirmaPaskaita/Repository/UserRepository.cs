﻿using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using WebAppMSSQL.Data;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO;
using WebAppMSSQL.Models.DTO.UserTDO;
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
        private DbSet<UserRepository> _dbSet;

        public UserRepository(KnygynasContext db, IPasswordService passwordService, IJwtService jwtService)
        {
            _db = db;
           // _dbSet = _db.Set<UserRepository>();
            _passwordService = passwordService;
            _jwtService = jwtService;
        }

        /// <summary>
        /// Should return a flag indicating if a user with a specified username already exists
        /// </summary>
        /// <param name="username">Registration username</param>
        /// <returns>A flag indicating if username already exists</returns>
        public async Task<bool> IsUniqueUserAsync(string username)
        {
            var user = await  _db.LocalUsers.FirstOrDefaultAsync(x => x.Username == username);
            if (user == null)
            {
                return true;
            }
            return false;
        }
        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            var inputPasswordBytes = Encoding.UTF8.GetBytes(loginRequest.Password);
            var user = await _db.LocalUsers.FirstOrDefaultAsync(x => x.Username.ToLower() == loginRequest.Username.ToLower());

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
        public async Task<LocalUser> RegisterAsync(RegistrationRequest registrationRequest)
        {
            _passwordService.CreatePasswordHash(registrationRequest.Password, out byte[] passwordHash, out byte[] passwordSalt);

            LocalUser user = new()
            {
                Username = registrationRequest.Username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Name = registrationRequest.Name,
                Role = registrationRequest.Role,
                RegistrationDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddYears(1),
            };

            _db.LocalUsers.Add(user);
            await _db.SaveChangesAsync();
            user.PasswordHash = null;
            return user;
        }
        public List<GetUserDto> GetAll(Expression<Func<LocalUser, bool>>? filter = null)
        {
            IQueryable<LocalUser> users = _db.LocalUsers;
            if (filter != null) users = _db.LocalUsers.Where(filter);

            var userDto = new List<GetUserDto>();
            foreach (var user in users)
            {
                userDto.Add(new GetUserDto()
                {
                    Id = user.Id,
                    Username = user.Username,
                    Role = user.Role,
                    HasAmountOfBooks = user.HasAmountOfBooks
                });

            }
            return userDto;
        }
        public async Task<GetUserDto> GetAsync(Expression<Func<LocalUser, bool>> filter)
        {
            LocalUser user = await _db.LocalUsers.Where(filter).FirstOrDefaultAsync();
            var userDto = new GetUserDto()
            {
                Id = user.Id,
                Username = user.Username,
                Role = user.Role,
                HasAmountOfBooks = user.HasAmountOfBooks,
               // Debt = user.Debt,
    };
            return userDto;
        }

        public async Task<bool> IsRegisteredAsync(int userId) // same as exist
        {
            var isRegistered = await _db.LocalUsers.AnyAsync(u => u.Id == userId);
            return isRegistered;
        }

 


    }
}