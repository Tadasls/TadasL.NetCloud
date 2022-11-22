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
    public class sdataController : ControllerBase
    {
        [HttpGet("data")]
        public IEnumerable<Sport> GetAllSportSakos()
        {
            var sportoSakuDuomenys = DataBase.sportoSakos;
            return sportoSakuDuomenys;
        }

        [HttpGet("data/{id:int}")] 
        public Sport? GetSportSakosById(int id)
        {
            return DataBase.sportoSakos
                .FirstOrDefault(f => f.Id == id);
        }

        //[ApiExplorerSettings(IgnoreApi = true)]
        //[HttpGet("data/testing/{id:int}")]
        //public FoodDTO? GetFoodByIdTesting(int id)
        //{
        //    return FoodStore.foodList.FirstOrDefault(f => f.Id == id);
        //}
       
        [HttpGet("data/SportoSalys")]
        public Sport? GetSportByNameAndCountry(string foodName, string country) 
        {     
            return DataBase.sportoSakos.FirstOrDefault(f => f.Name == foodName && f.Country == country);
        }


        [HttpPost]
        public Sport? CreateSportoSaka(Sport sportas)
        {
            sportas.Id = DataBase.sportoSakos
                .OrderByDescending(f => f.Id)
                .First().Id +1;

            DataBase.sportoSakos.Add(sportas);
            return sportas;

        }


        [HttpDelete("data/delete/{id:int}")]
        public void DeleteSportById(int id) 
        {
            var sportas = DataBase.sportoSakos.FirstOrDefault(f => f.Id == id);
            DataBase.sportoSakos.Remove(sportas);
        }

        [HttpPut("data/update/{id:int}")]
        public void UpdateSportas(int id, Sport sportas)
        {
            var naujasSportas = DataBase.sportoSakos
                .FirstOrDefault(f => f.Id == id);

            naujasSportas.Name = sportas.Name;
            naujasSportas.Id = sportas.Id;
            naujasSportas.Country = sportas.Country;
            naujasSportas.PleoplePlaing = sportas.PleoplePlaing;
        }




    }
}
