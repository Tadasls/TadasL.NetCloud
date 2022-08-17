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
        public List<Person> People { get; set; }

        public void FillPeople()
        { 
         List<Person> people = PersonInitialData.DataSeed.ToList();

        }

        public List<Person> senukai  // visus pries 2001
        {
            get
            {
                var senukai = new List<Person>();
                foreach (var person in People)
                {
                    if (person.BirthDate < new DateTime(2001, 1, 1))

                        senukai.Add(person);
                }
                return senukai;
            }
           
           
        }





        public List<Person> Vyrai { get; set; }

        public static void FillMen()
        {
            var vyrai = new List<Person>();
            foreach (var person in PersonInitialData.DataSeed)
            {
                if (person.Gender == (int)EGenderType.MALE)

                    vyrai.Add(person);
            }
            
        }

        public List<Person> Woman { get; set; }

        public static void FillWoman()
        {
            var moterys = new List<Person>();
            foreach (var person in PersonInitialData.DataSeed)
            {
                if(person.Gender == EGenderType.FEMALE)
                {
                    moterys.Add(person);
                }

            }

        }
        public static void SortByFirstName()
        {

        }

        public static void SortByLasttName()
        {

        }
        public static void SortAsc()
        {

        }
        public static void SortDsc()
        {

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
