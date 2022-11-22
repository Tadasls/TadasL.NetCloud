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
        List<Person> persons = new List<Person>{
                new Person() { Id = 1, Name = "Jonas", Surname = "Jonaitis"},
                 new Person() { Id = 2, Name = "Jonas2", Surname = "Jonaitis"},
                  new Person() { Id = 3, Name = "Jonas3", Surname = "Jonaitis"},
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





