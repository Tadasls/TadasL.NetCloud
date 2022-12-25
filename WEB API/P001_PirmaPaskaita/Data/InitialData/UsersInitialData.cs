using System.ComponentModel.DataAnnotations;
using WebAppMSSQL.Models;

namespace WebAppMSSQL.Data.InitialData
{
    public class UsersInitialData
    {
        public static readonly LocalUser[] userInitialDataSeed = new LocalUser[]
       {
            new LocalUser
            {
                Id= 1,
                Username = "Tadas",
                Name = "Tadas",
                PasswordHash = new byte[] {},
                PasswordSalt = new byte[] {},
                Role= "Admin",
                HasAmountOfBooks = 0,
                RegistrationDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddYears(1),
                LoyaltyPoints = 500,
                UserLevel = "Ekspertas",
                WasOnline = DateTime.Now.AddDays(-8),
                WasOnlineWeekNumber = 25,
            },
            new LocalUser
            {
                Id= 2,
                Username = "Titas",
                Name = "Titas",
                PasswordHash = null,
                PasswordSalt = null,
                Role= "User",
                HasAmountOfBooks = 0,
                RegistrationDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddYears(2),
                LoyaltyPoints = 500,
                UserLevel = "Ekspertas",
                WasOnline = DateTime.Now.AddDays(-5),
                WasOnlineWeekNumber = 30,
            }

       };



    




    }
}
