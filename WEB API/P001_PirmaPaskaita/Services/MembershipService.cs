using System.Globalization;
using WebAppMSSQL.Data;
using WebAppMSSQL.Models;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Services
{
    public class MembershipService : IMembershipService
    {


        private readonly KnygynasContext _db;
        public MembershipService(KnygynasContext db)
        {
            _db = db;
        }


        public async Task PridetiTaskuUzPrisijungima(int userId)
        {
            LocalUser user = _db.LocalUsers.First(u => u.Id == userId);
            
           if (user.WasOnline.Value.Day != DateTime.Today.Day || user.WasOnline.Value.Month != DateTime.Today.Month)
            {
                user.LoyaltyPoints += 50;  //todofix 
                _db.LocalUsers.Update(user);
                await _db.SaveChangesAsync();
            }

        }


        public async Task PridetiTaskuUzPrisijungimaVIPBONUS(int userId)
        {

            LocalUser user = _db.LocalUsers.First(u => u.Id == userId);
            Calendar calendar = CultureInfo.CurrentCulture.Calendar;
            int dabartineWeekOfYear = calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            while (dabartineWeekOfYear != user.WasOnlineWeekNumber);
            {
                user.LoyaltyPoints += 500;
                _db.LocalUsers.Update(user);
                 await _db.SaveChangesAsync();
                AtnaujintiPrisijungimoSavaite(userId);

            } 





        }



        public async Task AtnaujintiPrisijungimoData(int userId)
        {
            LocalUser user = _db.LocalUsers.First(u => u.Id == userId);
            user.WasOnline = DateTime.Now;
            _db.LocalUsers.Update(user);
            await _db.SaveChangesAsync();

        }


        public async Task AtnaujintiPrisijungimoSavaite(int userId)
        {
            LocalUser user = _db.LocalUsers.First(u => u.Id == userId);
            Calendar calendar = CultureInfo.CurrentCulture.Calendar;
            user.WasOnlineWeekNumber = calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            _db.LocalUsers.Update(user);
            await _db.SaveChangesAsync();

        }






    }
}
