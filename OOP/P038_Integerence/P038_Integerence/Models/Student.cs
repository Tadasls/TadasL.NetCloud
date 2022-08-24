using P038_Integerence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038_Inheritance_Praktika.Models
{
    public class Student : UniversityPerson
    {
        public Student(Random rnd) : base(rnd)
        {
        }
        private readonly List<string> invalidProfessions = new List<string> { "Lecturer", "Teacher", "Scientist" };
        public List<Profession> Courses { get; set; }
        public override Profession Profession
        {
            get => Profession;
            set
            {
                if (invalidProfessions.Contains(value.Text))
                {
                    throw new Exception();
                }
                else
                {
                    Profession = value;
                }
            }
        }
        public void SetCourses(Profession[] data)
        {
            Courses = new List<Profession>();
            List<int> indexesTaken = new List<int>();

            int count = _rnd.Next(1, 4);
            for (int i = 0; i < count; i++)
            {
                int index;
                do
                {
                    index = _rnd.Next(0, data.Length);
                }
                while (indexesTaken.Contains(index) || invalidProfessions.Contains(data[index].Text));
                indexesTaken.Add(index);
            }

            foreach (var index in indexesTaken)
            {
                Courses.Add(data[index]);
            }

        }
        public override string GetCsv()
        {


            return $"{Id},{FirstName},{LastName},{Gender},{BirthDate},{Weight},{Height},{Profession.Id}" +
                $",{(Hobbies.Count > 0 ? Hobbies[0].Id : "")}" +
                $",{(Hobbies.Count > 1 ? Hobbies[1].Id : "")}" +
                $",{(Hobbies.Count > 2 ? Hobbies[2].Id : "")}" +
                $",{(Hobbies.Count > 3 ? Hobbies[3].Id : "")}" +
                $",{Profession.Text}" +
                $",{(Courses.Count > 0 ? Courses[0].Text : "")}" +
                $",{(Courses.Count > 1 ? Courses[1].Text : "")}" +
                $",{(Courses.Count > 2 ? Courses[2].Text : "")}" ;
        }
        public List<int> GetCoursesDataSeedIndexes(string[] data)
        {
            List<int> sarasasIndexu = new List<int>();
                do
                {
                    int proffIndex = _rnd.Next(0, data.Length);
                    Profession p = new Profession();
                    p.EncodeCsv(data[proffIndex]);
                    sarasasIndexu.Add(p.Id);
                } while (sarasasIndexu.Count == data.Length);

                return sarasasIndexu;
        }


       public void GetBiography()
        {
            Console.WriteLine($"studentas/studentė (parinkti pagal lytį) Vardenis Pavardenis kurio profesija yra ... turi hobius ..., .... ir .... bei lanko .... ir .... kursus");
        }



    }






}

/*
Sukurkite klasę Student
- paveldėtą iš UniversityPerson, apribokite, kad ši klasė galėtu turėti profesijas išskyrus Lecturer, Teacher ir Scientist
- pridėkite property Courses (list of Profession)
-padarykite metodą, kuris atsitiktinai užpildys nuo 1 iki 3 kursų iš ProfessionInitialData (išfiltravus Lecturer, Teacher ir Scientist).
  Užtikrinkite,kad tas pat kursas nepasikartotu 2 kartus (unit-test)
-perrašykite metodą kuris GetCsv(), kad būtu grąžinami visi klasės duomenys
- sukurkite metodą kuris GetCoursesDataSeedIndexes() grąžintu atsitiktinai parinktų kursų indeksus (List of int) iš ProfessionInitialData(unit-test)
-parašykite metodą GetBiography() kuris parašys asmens biografiją naturalia kalba
  "studentas/studentė (parinkti pagal lytį) Vardenis Pavardenis kurio profesija yra ... turi hobius ..., .... ir .... bei lanko .... ir .... kursus"
  jei studentas neturi hobių, šios sakinio dalies rašyti nereikia. */