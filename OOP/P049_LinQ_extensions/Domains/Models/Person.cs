using System.Threading.Tasks;

namespace P049_LINQ_Extension.Domain.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public string Biography { get; set; }

        public int? Age
        {
            get
            {
                if (BirthDate == null) return null;
                var timeSpan = DateTime.Now.Subtract((DateTime)BirthDate);
                return new DateTime(timeSpan.Ticks).Year - 1;
            }
        }
    }
}