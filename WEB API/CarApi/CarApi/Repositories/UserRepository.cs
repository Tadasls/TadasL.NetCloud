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
        private readonly IUserService _userService;

        public UserRepository(CarContext context,
            IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public virtual bool TryLogin(string userName, string password, out LocalUser? user)
        {
            user = _context.Users.FirstOrDefault(x => x.UserName == userName);
            if (user == null)
                return false;

            if (!_userService.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return false;

            return true;
        }

        public int Register(LocalUser user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }

        public bool Exist(string userName)
        {
            return _context.Users.Any(x => x.UserName == userName);
        }

        public LocalUser Get(int id)
        {
            return _context.Users.First(x => x.Id == id);
        }



    }
}