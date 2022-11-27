using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P02_Rest_Endpoints.Data;
using P02_Rest_Endpoints.Models;
using P02_Rest_Endpoints.Models.Dto;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;

namespace P02_Rest_Endpoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class dataController : ControllerBase
    {
        [HttpGet("get")]
        public IEnumerable<DataDTO2> GetAllduomenys()
        {
            var duomenys = DataDb.dataDuomenys;
            return duomenys;
        }

        [HttpGet("data/{id:int}")]
        public DataDTO2? GetDataById(int id)
        {
            return DataDb.dataDuomenys
                .FirstOrDefault(f => f.id == id);
        }



        [HttpPost("create")]
        public DataDTO2? CreateData(DataDTO2 duomenys)
        {
           
            duomenys.id = DataDb.dataDuomenys
                .OrderByDescending(f => f.id)
                .First().id +1;

            DataDb.dataDuomenys.Add(duomenys);
            return duomenys;

        }


        [HttpDelete("delete/{id:int}")]
        public void DeleteDataById(int id) 
        {
            var duomenys = DataDb.dataDuomenys.FirstOrDefault(f => f.id == id);
            DataDb.dataDuomenys.Remove(duomenys);
        }

        [HttpPut("update/{id:int}")]
        public void UpdateData(int id, DataDTO2 duomenys)
        {
            var newData = DataDb.dataDuomenys
                .FirstOrDefault(f => f.id == id);

            newData.type = duomenys.type;
            newData.id = duomenys.id;
            newData.content = duomenys.content;
            newData.endDate = duomenys.endDate;
            newData.UserId2 = duomenys.UserId2;
        }




    }
}
