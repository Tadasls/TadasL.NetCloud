using P035_DataReading.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P035_DataReading.Domain.Models
{
    public class User
    {
        public User() { }
        public User(string[] userData)
        {
            Id = Convert.ToInt32(userData[0]);
            Name = userData[1];
            FamilyName = userData[2];
            Email = userData[3];
            
            if (userData[4] == "Male")
            {
                Gender = EGender.Male;
            }
            else if (userData[4] == "Female")
            {
                Gender = EGender.Female;
            }

            Salary = Convert.ToInt32(userData[5]);
            Favorite_color = userData[6];
            Birth_date = Convert.ToDateTime(userData[7]);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }
        public Enums.EGender Gender { get; set; }
        public int Salary { get; set; }
        public string Favorite_color { get; set; }
        public DateTime Birth_date { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is User)) return false;
            var other = obj as User;
            return Id == other.Id
                && Name.Equals(other.Name)
                && FamilyName.Equals(other.FamilyName)
                && Email.Equals(other.Email)
                && Salary == other.Salary
                && Birth_date.Equals(other.Birth_date);
        }

    }
}
