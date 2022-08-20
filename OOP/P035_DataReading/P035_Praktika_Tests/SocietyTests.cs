using Microsoft.VisualStudio.TestTools.UnitTesting;
using P035_DataReading.Domain.Enums;
using P035_DataReading.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P035_Praktika_Tests
{
    [TestClass]
    public class SocietyTests
    {
        [TestMethod]
        public void OldPeple_Test()
        {
            List<Person> fakePersonList = new List<Person>();

            fakePersonList.Add(new Person { Id = 1, FirstName = "Laurynas ", LastName = "Laurynaitis", Gender = EGender.MALE, Height = 180, Weight = 80.2M, BirthDate = DateTime.Parse("1976-01-05") });
            fakePersonList.Add(new Person { Id = 3, FirstName = "Adomas", LastName = "Adomaitis", Gender = EGender.MALE, Height = 169, Weight = 105.2M, BirthDate = DateTime.Parse("2000-03-01") });
            fakePersonList.Add(new Person { Id = 4, FirstName = "Linas", LastName = "Linasis", Gender = EGender.MALE, Height = 191, Weight = 95.5M, BirthDate = DateTime.Parse("2002-12-05") });

            Society society = new Society();

            society.People = fakePersonList;

            List<Person> expectedOldPersonList = new List<Person>();
            expectedOldPersonList.Add(new Person { Id = 1, FirstName = "Laurynas ", LastName = "Laurynaitis", Gender = EGender.MALE, Height = 180, Weight = 80.2M, BirthDate = DateTime.Parse("1976-01-05") });
            expectedOldPersonList.Add(new Person { Id = 3, FirstName = "Adomas", LastName = "Adomaitis", Gender = EGender.MALE, Height = 169, Weight = 105.2M, BirthDate = DateTime.Parse("2000-03-01") });

            var actualOldPersonList = society.OldPeople;

            CollectionAssert.AreEqual(expectedOldPersonList, actualOldPersonList);
        }

        [TestMethod]
        public void FillWomen_Test()
        {
            List<Person> fakePersonList = new List<Person>();

            fakePersonList.Add(new Person { Id = 1, FirstName = "Laurynas ", LastName = "Laurynaitis", Gender = EGender.MALE, Height = 180, Weight = 80.2M, BirthDate = DateTime.Parse("1976-01-05") });
            fakePersonList.Add(new Person { Id = 2, FirstName = "Adomas", LastName = "Adomaitis", Gender = EGender.MALE, Height = 169, Weight = 105.2M, BirthDate = DateTime.Parse("2000-03-01") });
            fakePersonList.Add(new Person { Id = 3, FirstName = "Aiste", LastName = "Ievautyte", Gender = EGender.FEMALE, Height = 185, Weight = 95.5M, BirthDate = DateTime.Parse("2000-12-08") });
            fakePersonList.Add(new Person { Id = 4, FirstName = "Linas", LastName = "Linasis", Gender = EGender.MALE, Height = 191, Weight = 95.5M, BirthDate = DateTime.Parse("2002-12-05") });
            fakePersonList.Add(new Person { Id = 5, FirstName = "Ieva", LastName = "Ievaute", Gender = EGender.FEMALE, Height = 180, Weight = 95.5M, BirthDate = DateTime.Parse("2000-12-08") });

            Society society = new Society();

            society.FillWomen(fakePersonList);

            List<Person> expectedWomenList = new List<Person>();
            expectedWomenList.Add(new Person { Id = 3, FirstName = "Aiste", LastName = "Ievautyte", Gender = EGender.FEMALE, Height = 185, Weight = 95.5M, BirthDate = DateTime.Parse("2000-12-08") });
            expectedWomenList.Add(new Person { Id = 5, FirstName = "Ieva", LastName = "Ievaute", Gender = EGender.FEMALE, Height = 180, Weight = 95.5M, BirthDate = DateTime.Parse("2000-12-08") });

            List<Person> actualWomenList = society.Women;

            CollectionAssert.AreEqual(expectedWomenList, actualWomenList);
        }

        [TestMethod]
        public void FillMen_Test()
        {
            List<Person> fakePersonList = new List<Person>();

            fakePersonList.Add(new Person { Id = 1, FirstName = "Laurynas ", LastName = "Laurynaitis", Gender = EGender.MALE, Height = 180, Weight = 80.2M, BirthDate = DateTime.Parse("1976-01-05") });
            fakePersonList.Add(new Person { Id = 2, FirstName = "Adomas", LastName = "Adomaitis", Gender = EGender.MALE, Height = 169, Weight = 105.2M, BirthDate = DateTime.Parse("2000-03-01") });
            fakePersonList.Add(new Person { Id = 3, FirstName = "Aiste", LastName = "Ievautyte", Gender = EGender.FEMALE, Height = 185, Weight = 95.5M, BirthDate = DateTime.Parse("2000-12-08") });
            fakePersonList.Add(new Person { Id = 4, FirstName = "Linas", LastName = "Linasis", Gender = EGender.MALE, Height = 191, Weight = 95.5M, BirthDate = DateTime.Parse("2002-12-05") });
            fakePersonList.Add(new Person { Id = 5, FirstName = "Ieva", LastName = "Ievaute", Gender = EGender.FEMALE, Height = 180, Weight = 95.5M, BirthDate = DateTime.Parse("2000-12-08") });

            Society society = new Society();

            society.FillMen(fakePersonList);

            List<Person> expectedMenList = new List<Person>();
            expectedMenList.Add(new Person { Id = 1, FirstName = "Laurynas ", LastName = "Laurynaitis", Gender = EGender.MALE, Height = 180, Weight = 80.2M, BirthDate = DateTime.Parse("1976-01-05") });
            expectedMenList.Add(new Person { Id = 2, FirstName = "Adomas", LastName = "Adomaitis", Gender = EGender.MALE, Height = 169, Weight = 105.2M, BirthDate = DateTime.Parse("2000-03-01") });
            expectedMenList.Add(new Person { Id = 4, FirstName = "Linas", LastName = "Linasis", Gender = EGender.MALE, Height = 191, Weight = 95.5M, BirthDate = DateTime.Parse("2002-12-05") });

            List<Person> actualMenList = society.Men;

            CollectionAssert.AreEqual(expectedMenList, actualMenList);
        }

        [TestMethod]
        public void SortByAge_Test()
        {
            List<Person> fakePersonList = new List<Person>();

            fakePersonList.Add(new Person { Id = 3, FirstName = "Adomas", LastName = "Adomaitis", Gender = EGender.MALE, Height = 169, Weight = 105.2M, BirthDate = DateTime.Parse("2000-03-01") });
            fakePersonList.Add(new Person { Id = 1, FirstName = "Laurynas ", LastName = "Laurynaitis", Gender = EGender.MALE, Height = 180, Weight = 80.2M, BirthDate = DateTime.Parse("1976-01-05") });
            fakePersonList.Add(new Person { Id = 4, FirstName = "Linas", LastName = "Linasis", Gender = EGender.MALE, Height = 191, Weight = 95.5M, BirthDate = DateTime.Parse("2002-12-05") });

            Society society = new Society();

            society.FillMen(fakePersonList);
            society.FillWomen(fakePersonList);
            society.SortByAge();

            List<Person> expectedMenList = new List<Person>();
            expectedMenList.Add(new Person { Id = 1, FirstName = "Laurynas ", LastName = "Laurynaitis", Gender = EGender.MALE, Height = 180, Weight = 80.2M, BirthDate = DateTime.Parse("1976-01-05") });
            expectedMenList.Add(new Person { Id = 2, FirstName = "Adomas", LastName = "Adomaitis", Gender = EGender.MALE, Height = 169, Weight = 105.2M, BirthDate = DateTime.Parse("2000-03-01") });
            expectedMenList.Add(new Person { Id = 4, FirstName = "Linas", LastName = "Linasis", Gender = EGender.MALE, Height = 191, Weight = 95.5M, BirthDate = DateTime.Parse("2002-12-05") });

            List<Person> actualMenList = society.Men;

            CollectionAssert.AreEqual(expectedMenList, actualMenList);
        }

        [TestMethod]
        public void CustomAscSorting_Test()
        {
            List<Person> fakePersonList = new List<Person>();

            fakePersonList.Add(new Person { Id = 1, FirstName = "Laurynas ", LastName = "Laurynaitis", Gender = EGender.MALE, Height = 180, Weight = 80.2M, BirthDate = DateTime.Parse("1976-01-05") });
            fakePersonList.Add(new Person { Id = 3, FirstName = "Adomas", LastName = "Adomaitis", Gender = EGender.MALE, Height = 169, Weight = 105.2M, BirthDate = DateTime.Parse("2000-03-01") });
            fakePersonList.Add(new Person { Id = 4, FirstName = "Linas", LastName = "Linasis", Gender = EGender.MALE, Height = 191, Weight = 95.5M, BirthDate = DateTime.Parse("2002-12-05") });

            Society society = new Society();

            society.FillPeople(fakePersonList);
            society.SortByFirstName().Asc();

            List<Person> expectedPeopleList = new List<Person>();
            expectedPeopleList.Add(new Person { Id = 2, FirstName = "Adomas", LastName = "Adomaitis", Gender = EGender.MALE, Height = 169, Weight = 105.2M, BirthDate = DateTime.Parse("2000-03-01") });
            expectedPeopleList.Add(new Person { Id = 1, FirstName = "Laurynas ", LastName = "Laurynaitis", Gender = EGender.MALE, Height = 180, Weight = 80.2M, BirthDate = DateTime.Parse("1976-01-05") });
            expectedPeopleList.Add(new Person { Id = 4, FirstName = "Linas", LastName = "Linasis", Gender = EGender.MALE, Height = 191, Weight = 95.5M, BirthDate = DateTime.Parse("2002-12-05") });

            List<Person> actualPeopleList = society.People;

            CollectionAssert.AreEqual(expectedPeopleList, actualPeopleList);
        }
    }
}


