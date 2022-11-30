using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P02_Rest_Endpoints.Data;
using P02_Rest_Endpoints.Models;
using P02_Rest_Endpoints.Models.Dto;
using System.Data.SqlTypes;

namespace P02_Rest_Endpoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        [HttpGet("get")]
        public IEnumerable<UserDTO> GetAllSportSakos()
        {
            var useriuDuomenys = UserDB.useriuSarasas;
            return useriuDuomenys;
        }



        [HttpPost("create")]
        public UserDTO? CreateUsser(UserDTO usser)
        {
            usser.id = UserDB.useriuSarasas
                .OrderByDescending(f => f.id)
                .First().id + 1;

            UserDB.useriuSarasas.Add(usser);
            return usser;

        }


        [HttpDelete("delete/{id:int}")]
        public void DeleteUsserById(int id)
        {
            var usser = UserDB.useriuSarasas.FirstOrDefault(f => f.id == id);
            UserDB.useriuSarasas.Remove(usser);
        }

        [HttpPut("update/{id:int}")]
        public void UpdateUsser(int id, UserDTO usser)
        {
            var newUsser = UserDB.useriuSarasas
                .FirstOrDefault(f => f.id == id);

            newUsser.userName = usser.userName;
            newUsser.id = usser.id;
            newUsser.userLastname = usser.userLastname;
            newUsser.userEmail = usser.userEmail;
        }











    }
}
