using CarApi.Database;
using CarApi.Models;
using CarApi.Models.Dto;
using CarApi.Repositories.Interfaces;
using CarApi.Services;
using CarApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CarApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CarContext _context;
        private readonly IPasswordService _passwordService;

        public UserRepository(CarContext context,
            IPasswordService passwordService)
        {
            _context = context;
            _passwordService = passwordService;
        }

        public async Task<bool> IsUniqueUser(string username)
        {
            var user = await _context.LocalUsers.FirstOrDefaultAsync(x => x.UserName == username);
            if (user == null)
            {
                return true;
            }
            return false;
        }


        public virtual bool TryLogin(string userName, string password, out LocalUser? user)
        {
            _passwordService.CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
             user = _context.LocalUsers.FirstOrDefault(x => x.UserName == userName);
        if (user == null)
            return false;

        if (_passwordService.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            return false;

        return true;
        }

   
        public async Task<int> Register(LocalUser user)
        {
            _context.LocalUsers.Add(user);
            await _context.SaveChangesAsync();
            return user.Id;
        }
    }
}