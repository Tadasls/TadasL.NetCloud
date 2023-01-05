using System.Globalization;
using System.Net.Http;
using WebAppMSSQL.Data;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.DTO.ApiModels;
using WebAppMSSQL.Models.DTO.UserDTO;
using WebAppMSSQL.Models.DTO.UserTDO;
using WebAppMSSQL.Services.IServices;

namespace WebAppMSSQL.Services
{
    public class MembershipService : IMembershipService
    {
        private readonly KnygynasContext _db;
        private readonly IHttpClientFactory _httpClientFactory;
        public MembershipService(KnygynasContext db, IHttpClientFactory httpClientFactory)
        {
            _db = db;
            _httpClientFactory = httpClientFactory;
        }
        public bool ArBuvoUserisSndOnline(int userId)
        {
            LocalUser user = _db.LocalUsers.First(u => u.Id == userId);
            if (user.WasOnline.ToShortDateString() == DateTime.Now.ToShortDateString())
            {
                return true;
            }
            return false;

        }
        public async Task PridetiTaskuUzPrisijungima(int userId)
        {
           // LocalUser user = _db.LocalUsers.First(u => u.Id == userId);
           //if (user.WasOnline.ToShortDateString() == DateTime.Now.ToShortDateString())
           //{
           //     bool arSndSvente = await IsTodayHoliday();
           //     if (arSndSvente)
           //     {
           //         user.LoyaltyPoints += 150;
           //     }
           //     user.LoyaltyPoints += 50;  //todofix             
           //     _db.LocalUsers.Update(user);
           //     await _db.SaveChangesAsync();
           //}
        }
        public async Task AtnaujintiPrisijungimoData(int userId)
        {
            LocalUser user = _db.LocalUsers.First(u => u.Id == userId);
            user.WasOnline = DateTime.Now;
            _db.LocalUsers.Update(user);
            await _db.SaveChangesAsync();
        }
        public async Task SetUserLevel(int userId)
        {
            LocalUser user = _db.LocalUsers.First(u => u.Id == userId);
            
            if(user.LoyaltyPoints >= 2000)
            {
                user.UserLevel = "Megejas";
            }
            if (user.LoyaltyPoints >= 10000)
            {
                user.UserLevel = "Ekspertas";
            }
            if (user.LoyaltyPoints >= 25000)
            {
                user.UserLevel = "Guru";
            }
            _db.LocalUsers.Update(user);
            await _db.SaveChangesAsync();
        }
        public async Task PridetiTaskuUzPrisijungimaVIPBONUS(int userId)
        {
            LocalUser user = _db.LocalUsers.First(u => u.Id == userId);
            Calendar calendar = CultureInfo.CurrentCulture.Calendar;
            int dabartineWeekOfYear = calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            if (dabartineWeekOfYear != user.WasOnlineWeekNumber)
            {
                user.LoyaltyPoints += 500;
                user.WasOnlineWeekNumber = calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                _db.LocalUsers.Update(user);
                await _db.SaveChangesAsync();
               // AtnaujintiPrisijungimoSavaite(userId);

            };

        }
        public async Task PridetiTaskuUzPrisijungima2(string userName)
        {
            //LocalUser user = _db.LocalUsers.First(u => u.Username == userName);
            //if (user.WasOnline.Value.Day != DateTime.Today.Day || user.WasOnline.Value.Month != DateTime.Today.Month)
            //{
            //    user.LoyaltyPoints += 50;  //todofix 
            //    _db.LocalUsers.Update(user);
            //    await _db.SaveChangesAsync();
            //}

        }

        //todo

        // https://holidayapi.com/countries/lt/2022
        //public async Task<bool> IsTodayHoliday()
        //{
        //    var today = DateTime.Now.AddYears(-1).ToShortDateString().ToString();
        //    HolidayModel listOfHolidays = await GetHolidays();
        //    foreach (var holiday in listOfHolidays.holidays)
        //    {
        //        if (holiday.date == today) return true;
        //    }
        //    return false;
        //}

        //public async Task<HolidayModel> GetHolidays()
        //{
        //    string _api_key = "32194e4e-af3d-479c-8aee-f3de68dad7b6";
        //    string year = "2021";
        //    HttpClient httpClient = _httpClientFactory.CreateClient("HolidaysService");
        //    string endpoint = "v1/holidays?pretty&key=" + _api_key + "&country=LT" + "&year=" + year;
        //    HolidayModel HolidayModel = await httpClient.GetFromJsonAsync<HolidayModel>(endpoint);
        //    return HolidayModel;
        //}

        public async Task PanaudotiTaskusUzSkolas(int userId, int taskai)
        {
            LocalUser user = _db.LocalUsers.First(u => u.Id == userId);
            user.LoyaltyPoints -= taskai;  //todofix             
            _db.LocalUsers.Update(user);
            await _db.SaveChangesAsync();
        }



    }
}
