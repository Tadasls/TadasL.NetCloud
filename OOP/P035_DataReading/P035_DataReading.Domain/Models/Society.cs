using P035_DataReading.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P035_DataReading.Domain.Models
{
    public class Society
    {
        private ESocietySortBy sortBy;
        // 1 uzdavinio sprendimas
        public List<Person> People { get; set; } = new List<Person>();
        // 2 uzdavinio sprendimas
        public void FillPeople(List<Person> people)
        {
            People = people;
            this.FillMen(people);
            this.FillWomen(people);
        }

        //3- Sukurkite propertį OldPeople (List of persons). Grąžinkite visus asmenis iš People kurie gimė prieš 2001m. (unit-test)
        public List<Person> OldPeople
        {
            get
            {
                List<Person> oldPeople = new List<Person>();
                foreach (Person person in People)
                {
                    if (person.BirthDate < new DateTime(2001, 1, 1))
                    {
                        oldPeople.Add(person);
                    }
                }
                return oldPeople;
            }
        }

        //4- Sukurkite properčius Men (List of persons) ir Women (List of persons) .
        public List<Person> Men { get; set; }
        public List<Person> Women { get; set; }

        //5- Sukurkite metodus FillMen ir FillWomen, kurie iš PersonInitialData surašys vyrus ir moteris (unit-test)
        public void FillMen(List<Person> people)
        {
            Men = new List<Person>();
            foreach (var person in people)
            {
                if (person.Gender == Enums.EGender.MALE)
                {
                    Men.Add(person);
                }
            }
        }

        public void FillWomen(List<Person> people)
        {
            Women = new List<Person>();
            foreach (var person in people)
            {
                if (person.Gender == Enums.EGender.FEMALE)
                {
                    Women.Add(person);
                }
            }
        }

        //6- sukurkite metodą SortByAge(), kuris Men ir Women sąrašuose esančius asmenis surikiuotu pagal amžių nuo jauniausio iki vyriausio. (unit-test)
        public void SortByAge()
        {
            Men.Sort((a, b) => a.BirthDate >= b.BirthDate ? 1 : -1);
            Women.Sort((a, b) => a.BirthDate >= b.BirthDate ? 1 : -1);
        }

        /*  7- Padarykite metodą kuris People, Men ir Women properčiuose esančius asmenis  rikiuos nuo A iki Z arba nuo Z iki A.  (unit-test)
             Pagal Vardą arba Pavardę
             tokiu principu: SortByFirstName().Asc()
                             SortByLastName().Desc()
            <hint> return this
         */
        public Society SortByFirstName()
        {
            sortBy = ESocietySortBy.FirstName;
            return this;
        }

        public Society SortByLastName()
        {
            sortBy = ESocietySortBy.LastName;
            return this;
        }

        public void Asc()
        {
            switch (sortBy)
            {
                case ESocietySortBy.FirstName:
                    People.Sort((a, b) => a.FirstName.CompareTo(b.FirstName));
                    break;
                case ESocietySortBy.LastName:
                    People.Sort((a, b) => a.FirstName.CompareTo(b.LastName));
                    break;
                default:
                    break;
            }
        }

        public void Desc()
        {
            switch (sortBy)
            {
                case ESocietySortBy.FirstName:
                    People.Sort((a, b) => b.FirstName.CompareTo(a.FirstName));
                    break;
                case ESocietySortBy.LastName:
                    People.Sort((a, b) => b.FirstName.CompareTo(a.LastName));
                    break;
                default:
                    break;
            }
        }
    }
}