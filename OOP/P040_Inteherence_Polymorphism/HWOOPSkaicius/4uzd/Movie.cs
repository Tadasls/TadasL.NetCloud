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

        public Movie(int id, DateTime creationDate, string name, string publisher, string genre, int rating) : this(id, creationDate)
        {
            Name = name;
            Publisher = publisher;
            Genre = genre;
            Rating = rating;
        }

        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }

        public string GetHobbyInformation()
        {
            string info = $"This Movie made by {Publisher} in {Genre} gendre has this rating: {Rating} ";
            return info;
        }

        public string GetHobbyName()
        {
            return nameof(Movie);
        }
    }
}
