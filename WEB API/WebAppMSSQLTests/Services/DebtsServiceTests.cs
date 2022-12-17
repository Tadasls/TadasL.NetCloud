using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppMSSQL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMSSQL.Models.ReservationsDTO;
using WebAppMSSQL.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using WebAppMSSQL.Models.Enums;
using System.Net;
using WebAppMSSQL.Models.DTO.BookDTO;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Repository;
using Moq;
using WebAppMSSQL.Services.IServices;
using Azure.Core;

namespace WebAppMSSQL.Services.Tests
{
    [TestClass()]
    public class DebtsServiceTests
    {

        [TestMethod]
        public void SuskaiciuotiSkolosDydiTest()
        {
            int fakeDaysDelay = 100;

            var expected = 20;
            var debstService = new DebtsService();
            var result = debstService.SuskaiciuotiSkolosDydi(fakeDaysDelay);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SuskaiciuotiSkolosDydiTest2()
        {
            int fakeDaysDelay = 500;

            var expected = 50;
            var debstService = new DebtsService();
            var result = debstService.SuskaiciuotiSkolosDydi(fakeDaysDelay);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public async Task CountDelayDaysTest()
        {
            int fakeUserID = 1;

            var fakeReservationRepo = new List<Reservation>
                 {
                 new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now.AddDays(10), ReturnDate = DateTime.Now.AddDays(-30) },
                 new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now.AddDays(20), ReturnDate = DateTime.Now.AddDays(-20) },
                 new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now.AddDays(30), ReturnDate = DateTime.Now.AddDays(-10) },
                 new Reservation { LocalUserId = 4, ActualReturnDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(-2) }
                 };


            var expected = 117;
            var debstService = new DebtsService();
            var result = await debstService.CountDelayDays(fakeUserID, fakeReservationRepo);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task CountDebtsAmountTest()
        {
            int fakeUserID = 1;

            var fakeReservationRepo = new List<Reservation>
                 {
                 new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now.AddDays(10), ReturnDate = DateTime.Now.AddDays(-30) },
                 new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now.AddDays(20), ReturnDate = DateTime.Now.AddDays(-20) },
                 new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now.AddDays(30), ReturnDate = DateTime.Now.AddDays(-10) },
                 new Reservation { LocalUserId = 4, ActualReturnDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(-2) }
                 };


            var expected = 3;
            var debstService = new DebtsService();
            var result = await debstService.CountDebtsAmount(fakeUserID, fakeReservationRepo);

            Assert.AreEqual(expected, result);
        }
    }


}


