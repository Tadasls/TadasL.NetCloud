using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOPSkaiciavimas._4uzd
{
    public class Movie : IHobby
    {
        public Movie()
        {

        }

        public Movie(int id, DateTime creationDate)
        {
            Id = id;
            CreationDate = creationDate;
        }

        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        public string Name => throw new NotImplementedException();

        public string Publisher => throw new NotImplementedException();

        public string Genre => throw new NotImplementedException();

        public int Rating => throw new NotImplementedException();

        public string GetHobbyInformation()
        {
            throw new NotImplementedException();
        }

        public string GetHobbyName()
        {
            throw new NotImplementedException();
        }
    }
}
