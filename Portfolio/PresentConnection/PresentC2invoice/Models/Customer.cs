using System.Net;

namespace PresentC2invoice.Models
{
    public class Customer : ICustomer
    {
    
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public bool IsVATPayer { get; set; }

        public Customer()
        {
            // Default constructor
        }

        public Customer(string firstName, string lastName, string email, DateTime dateOfBirth, string phoneNumber, string address, string country, bool isVATPayer)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Address = address;
            Country = country;
            IsVATPayer = isVATPayer;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }



    }



}
