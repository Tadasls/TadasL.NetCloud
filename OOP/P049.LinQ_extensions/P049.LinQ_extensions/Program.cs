using P51_LINQ_Query.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;
using System.Net.Sockets;
using System;
using System.Security.Cryptography.X509Certificates;

namespace P51_LINQ_Query
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Linq Query!");
            List<Person> students = new List<Person>
            {
                new Person { Id = 1, Name = "John", Age = 18, ProfessionId = 1 },
                new Person { Id = 2, Name = "Steve", Age = 21, ProfessionId = 1 },
                new Person { Id = 3, Name = "Bill", Age = 17, ProfessionId = 2 },
                new Person { Id = 4, Name = "Ram", Age = 20, ProfessionId = 2 },
                new Person { Id = 5, Name = "Rom", Age = 21 },
                new Person { Id = 6, Name = "Bill", Age = 25, ProfessionId = 3 },
            };
            List<Profession> professions = new List<Profession>
            {
                new Profession { ProfessionId = 1,  TextLt = "Mokytojas"},
                new Profession { ProfessionId = 2,  TextLt = "Daktaras"},
                new Profession { ProfessionId = 3,  TextLt = "Programuotojas"},
            };
            List<Hobby> hobbies = new List<Hobby>
            {
                new Hobby { HobbyId = 1, TextLt = "Daile" },
                new Hobby { HobbyId = 2, TextLt = "Muzika" },
                new Hobby { HobbyId = 3, TextLt = "Sokis" },
                new Hobby { HobbyId = 4, TextLt = "Programavimas" },
            };

            //filtruojame studentus kuriem yra maziau kaip 20 metu
            var jauniStudentai = from s in students
                                 where s.Age < 20 && s.Age > 17
                                 select s;

            foreach (var jaunasStudentas in jauniStudentai)
            {
                Console.WriteLine("   " + jaunasStudentas.Name);
            }

            Console.WriteLine("-------------------------------------------------");
            var surikiuotiStudentai = from s in students
                                      orderby s.Name
                                      select s;
            var surikiuotiStudentaiDesc = from s in students
                                          orderby s.Name descending
                                          select s;

            var surikiuotiStudentaiPagal2Parametrus = from s in students
                                                      orderby s.Name, s.Age
                                                      select s;

            //foreach (var s in surikiuotiStudentaiDesc)
            //{
            //    Console.WriteLine("   " + s.Name);
            //}

            Console.WriteLine("-Projection Operators: Select -------------------------------------------");
            //query sintakse
            var studentai = from s in students
                            select new StudentDto
                            {
                                Name = "Mr. " + s.Name,
                                Age = s.Age,
                            };

            //extention sintakse
            var studentai2 = students.Select(s => new StudentDto
            {
                Name = s.Name,
                Age = s.Age
            });


            var studentai1 = from s in students
                             select new
                             {
                                 Name = "Mr. " + s.Name,
                                 Age = s.Age,
                             };



            //foreach (var s in studentai1)
            //{
            //    Console.WriteLine("   " + s.Name + "  " + s.Age);
            //}

            /*All, Any Quantifier operators are Not Supported with C# query syntax.  */
            bool arYraSutentu16metu = students.Any(s => s.Age == 16);

            /*Aggregation Operator: Average Average operator in query syntax is Not Supported */
            var avgAmzius = students.Average(s => s.Age);

            /*Aggregation Operator: Count C# Query Syntax doesn't support aggregation operators.*/
            var totalStudents = students.Count();
            var adultStudents = students.Count(s => s.Age >= 18);

            var totalStudents1 = (from s in students
                                  where s.Age >= 18
                                  select s).Count();

            /*Set Operator: Distinct Distinct operator is Not Supported in C#*/
            var distinctStudents = (from s in students
                                    select s).Distinct();

            var distinctStudents1 = students.Distinct();

            /*Joining Operator: Join*/
            var innerJoin = from s in students // outer sequence
                            join p in professions on s.ProfessionId equals p.ProfessionId // key selector 
                            select new
                            {
                                StudentName = s.Name,
                                StudentProfession = p.TextLt
                            };

            var join = from s in students
                       from p in professions.Where(pr => pr.ProfessionId == s.ProfessionId).DefaultIfEmpty()
                       select new
                       {
                           StudentName = s.Name,
                           StudentProfession = p?.TextLt
                       };

            //foreach (var s in join)
            //{
            //    Console.WriteLine("   " + s.StudentName + "  " + s.StudentProfession);
            //}
            Console.WriteLine("-----------------------------------------------");

            /* Grouping Operators: GroupBy */
            var sugrupuotiStudentai = from s in students
                                      group s by s.Age;

            //foreach (var amziausGrupe in sugrupuotiStudentai)
            //{
            //    Console.WriteLine($" Amziaus grupes {amziausGrupe.Key}");
            //    foreach (var studentas in amziausGrupe)
            //    {
            //        Console.WriteLine($"             studentas yra {studentas.Name}");
            //    }
            //}


            /* Nesting composition 1:1 */

            var studentasIrProfesija = from s in students
                                       select new
                                       {
                                           Student = s,
                                           Profession = (from pr in professions
                                                         where pr.ProfessionId == s.ProfessionId
                                                         select pr).FirstOrDefault()
                                       };
            //foreach (var s in studentasIrProfesija)
            //{
            //    Console.WriteLine("   " + s.Student.Name + "  " + s.Profession?.TextLt);
            //}

            /* Nesting composition 1:M atsitiktinai parinkti studentam 2 hobius*/
            var studentasIrHobis = from s in students
                                   select new
                                   {
                                       Student = s,
                                       Hobbies = hobbies.OrderBy(h => Guid.NewGuid()).Take(2)
                                   };
            foreach (var studentas in studentasIrHobis)
            {
                Console.WriteLine("   " + studentas.Student.Name + " turi hobius:");
                foreach (var h in studentas.Hobbies)
                {
                    Console.WriteLine("      " + h.TextLt);
                }
            }







            /*
            1 UZDUOTIS turime masyvą 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 Parašykite užklausą, kuri grąžins lyginius skaičius
            */
/*
          2 uzd.   turime masyvą 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
       Parašykite užklausą, kuri grąžins teigiamus skaičius
*/


        }

        public static int[] LyginiaiSkaiciai()
        {
            int[] skaiciusarasa = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var lyginiaiSkaiciai = from n in skaiciusarasa
                                   where n % 2 == 0
                                   select n;


            return lyginiaiSkaiciai.ToArray();
        }


        public static int[] ivairusSkaiciai()
        {
            int[] skaicskaiciukai = new int[] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var teigiamiSk = from n in skaicskaiciukai
                                   where n > 0
                                   select n;


            return teigiamiSk.ToArray();
        }



        public static int[] ivairusSkaiciai2()
        {
            int[] skaicskaiciukai = new int[] { 3, 9, 2, 8, 6, 5 };
            var teigiamiSk = from n in skaicskaiciukai
                             select n*n;


            return teigiamiSk.ToArray();
        }

        public static IEnumerable<int> ivairusSkaiciai3()
        {
            int[] skaicskaiciukai = new int[] { 3, 9, 2, 8, 6, 5, 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var dublikatai = skaicskaiciukai
                .GroupBy(i => i)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);

             foreach (var d in dublikatai)
                       Console.WriteLine(d);
            return dublikatai;


           

        }







    }
}