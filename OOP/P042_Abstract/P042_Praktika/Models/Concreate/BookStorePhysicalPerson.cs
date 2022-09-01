using P043_Uzduotys.Models.Abstract;

namespace P043_Uzduotys.Models.Concrete
{
    public class BookStorePhysicalPerson : BookStorePerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}