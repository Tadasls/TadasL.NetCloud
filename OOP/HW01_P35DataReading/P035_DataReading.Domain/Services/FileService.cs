using P035_DataReading.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P035_DataReading.Domain.Services
{
    public class FileService
    {
        readonly string _filePath;
        public FileService(string filePath)
        {
            _filePath = filePath;
        }
                    
        public string IstrauktiIsCsvLaikmenosDuomenuPavadinimus()
        {
            using StreamReader sr = new StreamReader(_filePath);

            Console.WriteLine(sr.ReadLine());
            return sr.ReadLine();
        }

        
        public List<User> VartotojoDuomenuIsCsvSkaitymoMetodas()
        {
            int userColumCount = 8;
            List<User> users = new List<User>();

            using StreamReader sr = new StreamReader(_filePath);

            string usersLine;
            string headers = sr.ReadLine();

            while ((usersLine = sr.ReadLine()) != null)
            {
                string[] userData = usersLine.Split(',');

                if (userData.Length != userColumCount) break;

                User newUser = new User(userData); // sukuriame pagal Klase user naujas objektas kuria per konstruktoriu tiesiog paduodame is uzpildome stringu masyva 
                users.Add(newUser);
            }

            return users;
        }


        public List<Hotel> HotelioDuomenuIsCSVNuskaitymas()
        {
            int userColumCount = 5;
            List<Hotel> hotels = new List<Hotel>();

            using StreamReader sr = new StreamReader(_filePath);

            string hotelsLine;
            string headers = sr.ReadLine();

            while ((hotelsLine = sr.ReadLine()) != null)
            {
                string[] hotelsData = hotelsLine.Split(',');

                if (hotelsData.Length != userColumCount) break;

                Hotel newHotel = new Hotel(hotelsData);
                hotels.Add(newHotel);
            }
            return hotels;  
           
        }




    }
}
