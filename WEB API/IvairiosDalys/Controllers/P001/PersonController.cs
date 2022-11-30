using ApiMokymai.Models.Kiti;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ApiMokymai.Controllers.P001
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //dataSeed paduodamas Kontroleryje 
        List<Person> persons = new List<Person>{
                new Person() { Id = 1, Name = "Jurgis", Surname = "Brolis1"},
                 new Person() { Id = 2, Name = "Antanas", Surname = "Brolis2"},
                  new Person() { Id = 3, Name = "Aloyzas", Surname = "Brolis3"},
                  new Person() { Id = 4, Name = "Martynas", Surname = "Brolis4"},
        };


        [HttpGet("asmenys")]
        public List<Person> GetMyPersons()
        {
            return persons;
        }

        [HttpGet("{id}")]
        public Person? GetMyPersonById(int id)
        {
            return persons.FirstOrDefault(p => p.Id == id);
        }

        [HttpGet("pagalvarda/{name}")]
        public Person? GetMyPersonByName(string name)
        {
            return persons.FirstOrDefault(p => p.Name == name);
        }


        [HttpGet("pagalpavarde/{surname}")]
        public Person? GetMyPersonBySurname(string surname)
        {
            return persons.FirstOrDefault(p => p.Surname == surname);
        }

        [HttpGet("pagal")]
        public Person? GetMyPersonByNameAndSurname(string name, string surname)
        {
            return persons.FirstOrDefault(p => p.Name == name && p.Surname == surname);
        }





    }
}





