using Microsoft.VisualStudio.TestTools.UnitTesting;
using P035_DataReading;
using P035_DataReading.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P035_DataReading.Tests
{
    [TestClass]
    public class Hotel_Tests
    {
        [TestMethod]
        public void AverageClientSalary_Test()
        {
            var fakeGyventojai = new List<User>()
            {
                new User("1,Viv,Joberne,vjoberne0@dailymail.co.uk,Female,4508,Khaki,2/27/2010".Split(",")),
                new User("2,Trefor,Wellings,twellings1@angelfire.com,Male,5930,Green,1/2/1918".Split(",")),
                new User("3,Xymenes,O'Hern,xohern2@histats.com,Male,4278,Aquamarine,3/30/1908".Split(",")),
            };

            var fakeHotel = new Hotel();
            fakeHotel.AddUsers(fakeGyventojai);

            double expected = (4508d + 5930d + 4278d) / 3d;
            var actual = fakeHotel.AverageClientSalary;

            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        public void MenVisitors_Test()
        {
            var fakeGyventojai = new List<User>()
            {
                new User("1,Viv,Joberne,vjoberne0@dailymail.co.uk,Female,4508,Khaki,2/27/2010".Split(",")),
                new User("2,Trefor,Wellings,twellings1@angelfire.com,Male,5930,Green,1/2/1918".Split(",")),
                new User("3,Xymenes,O'Hern,xohern2@histats.com,Male,4278,Aquamarine,3/30/1908".Split(",")),
            };
            var fakeHotel = new Hotel();
            fakeHotel.AddUsers(fakeGyventojai);
            var expected = new List<User>()
            {
                new User("2,Trefor,Wellings,twellings1@angelfire.com,Male,5930,Green,1/2/1918".Split(",")),
                new User("3,Xymenes,O'Hern,xohern2@histats.com,Male,4278,Aquamarine,3/30/1908".Split(",")),
            };
            var actual = fakeHotel.VyraiSveciai;
            CollectionAssert.AreEqual(expected, actual);
        }
        //[TestMethod]
        public void WomenVisitors_Test()
        {
            var fakeGyventojai = new List<User>()
            {
                new User("1,Viv,Joberne,vjoberne0@dailymail.co.uk,Female,4508,Khaki,2/27/2010".Split(",")),
                new User("2,Trefor,Wellings,twellings1@angelfire.com,Male,5930,Green,1/2/1918".Split(",")),
                new User("3,Xymenes,O'Hern,xohern2@histats.com,Male,4278,Aquamarine,3/30/1908".Split(",")),
            };

            var fakeHotel = new Hotel();
            fakeHotel.AddUsers(fakeGyventojai);
            var expected = new List<User>()
            {
                new User("1,Viv,Joberne,vjoberne0@dailymail.co.uk,Female,4508,Khaki,2/27/2010".Split(",")),
            };
            var actual = fakeHotel.MoterysSveciai;
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddUser_Test()
        {
            var fakeUser = new User("1,Viv,Joberne,vjoberne0@dailymail.co.uk,Female,4508,Khaki,2/27/2010".Split(","));

            var fakeHotel = new Hotel();
            fakeHotel.AddUser(fakeUser);

            var expected = new List<User>() { fakeUser };

            var actual = fakeHotel.Gyventojai;

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddUsers_Test()
        {
            var fakeUsers = new List<User>()
            {
                new User("1,Viv,Joberne,vjoberne0@dailymail.co.uk,Female,4508,Khaki,2/27/2010".Split(",")),
                new User("2,Trefor,Wellings,twellings1@angelfire.com,Male,5930,Green,1/2/1918".Split(",")),
                new User("3,Xymenes,O'Hern,xohern2@histats.com,Male,4278,Aquamarine,3/30/1908".Split(",")),
            };

            var fakeHotel = new Hotel();
            fakeHotel.AddUsers(fakeUsers);

            var expected = new List<User>(fakeUsers);

            var actual = fakeHotel.Gyventojai;

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}