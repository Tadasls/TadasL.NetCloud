using P034_Praktika.Enums;
using P034_Praktika.InitalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P034_Praktika.Models
{
    public class Society
    {
        public List<Person> People { get; set; } = new List<Person>();  // 1 uzd

        public void FillPeople(List<Person> people) => People = people;
      


        public List<Person> OldPeople  // visus pries 2001
        {
            get
            {
                List<Person> oldPeople = new List<Person>();
                foreach (var person in People)
                {
                    
                    if (person.BirthDate < new DateTime(2001, 1, 1))

                        oldPeople.Add(person);
                }
                return oldPeople;
            }          
        }



        public List<Person> Men { get; set; } = new List<Person>();

        public void FillMen(List<Person> people)
        {
            Men = new List<Person>();
            foreach (var person in people)
            {
                if (person.Gender == EGenderType.MALE)
                    Men.Add(person);
            }
        }

        public List<Person> Woman { get; set; } = new List<Person>();
        public void FillWoman()
        {
            foreach (var person in PersonInitialData.DataSeed)
            {
                if(person.Gender == EGenderType.FEMALE)
                {
                   Woman.Add(person);
                }

            }

        }
        public static void SortByFirstName()
        {

        }
        //public Society SortByFirtName()
        //{
        //    sortBy = ESocietySortBy.LastName;
        //    return this;
        //}

        //public void Asc()
        //{
        //    switch (sortBy)
        //    {
        //        case ESocietySortBy.FirstName:
        //            People.Sort((a, b) => a.FirstName.CompareTo(b.FirstName));
        //            break;

        //        case ESocietySortBy.LastName:
        //            People.Sort((a, b) => a.LastName.CompareTo(b.LastName));
        //            break;
        //                default:
        //                break;
        //    }
        //}

      

        //6- sukurkite metodą SortByAge(), kuris Men ir Women sąrašuose esančius asmenis surikiuotu pagal amžių nuo jauniausio iki vyriausio. (unit-test)
        public void SortByAge()
        {
            Men.Sort((a, b) => a.BirthDate >= b.BirthDate ? 1 : -1);
            Woman.Sort((a, b) => a.BirthDate >= b.BirthDate ? 1 : -1);
        }


        public void SortByAge2(List<Person> list)
        {
            Person tempPerson;
            for (int j = 0; j <= list.Count; j++)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].BirthDate < list[i + 1].BirthDate)
                    {
                        tempPerson = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = tempPerson;
                    }
                }
            }
        }



  





    }

    /*
 
    Sukurkite klasę Society
1- Sukurkite propertį People (List of persons) +
2- sukurkite metodą FillPeople kuris užpildys sąrašą iš klasės PersonInitialData.+
3- Sukurkite propertį OldPeople. Grąžinkite visus asmenis kurie gimė prieš 2001m. (unit-test)
4- Sukurkite properčius Men ir Women. 
5- Sukurkite metodus FillMen ir FillWomen, kurie iš PersonInitialData surašys vyrus ir moteris (unit-test) 
6- sukurkite metodą SortByAge(), kuris Men ir Women sąrašus esančius asmenis surikiuotu pagal amžių nuo jauniausio iki vyriausio.
7- Padarykite metodą kuris People, Men ir Women properčiuose esančius asmenisrikiuos nuo A iki Z arba nuo Z iki A. 
Pagal Vardą arba Pavardę
tokiu principu: SortByFirstName().Asc()
SortByLastName().Asc()
SortByLastName().Desc()
<hint> return this


     */



}
