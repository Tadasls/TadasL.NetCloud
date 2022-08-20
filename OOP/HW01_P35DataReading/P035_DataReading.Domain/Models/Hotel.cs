using P035_DataReading.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P035_DataReading.Domain.Models
{
    public class Hotel
    {
        public Hotel() { }   
        public Hotel(string[] hotelsData)
        {
            Id = Convert.ToInt32(hotelsData[0]);
            Name = hotelsData[1];
            Rating = Convert.ToInt32(hotelsData[2]);
            PostCode = Convert.ToInt32(hotelsData[3]);
            Creation_date = Convert.ToDateTime(hotelsData[4]);         
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public int PostCode { get; set; }
        public DateTime Creation_date { get; set; }
        public List<User> Gyventojai { get; set; } = new List<User>();   
        public double AverageClientSalary
        {
            get
            {
                double vidPajamos = 0;
               foreach (var gyventojas in Gyventojai)
                {
                    vidPajamos += gyventojas.Salary;
                }
                return vidPajamos / Gyventojai.Count;
            }
        }
        public List<User> VyraiSveciai
        {
            get
            {
                List<User> vyraiSveciai = new List<User>();
                foreach (var gyventojas in Gyventojai)
                {
                    if (gyventojas.Gender == EGender.Male)
                    {
                        vyraiSveciai.Add(gyventojas);
                    }
                }
                return vyraiSveciai;
            }
        }
        public List<User> MoterysSveciai
        {
            get
            {
                List<User> moterysSveciai = new List<User>();
                foreach (var gyventojas in Gyventojai)
                {
                    if (gyventojas.Gender == EGender.Female)
                    {
                        moterysSveciai.Add(gyventojas);
                    }
                }
                return moterysSveciai;
            }
        }    
        public void AddUser(User user)
        {
            Gyventojai.Add(user);
        }
        public void AddUsers(List<User> users)
        {
            foreach (var user in users)
            {
                Gyventojai.Add(user);
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Hotel)) return false;

            var other = obj as Hotel;

            return Id == other.Id
                && Name.Equals(other.Name)
                && PostCode == other.PostCode
                && Creation_date.Equals(other.Creation_date);
        }






    }
}
