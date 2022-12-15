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
       public async Task TestMethod1()
            {
                // Arrange
             int expected = 3;
             int id = 1;
             var _reservationRepo = new MockReservationRepository();

           //var _fakeReservationRepo = new Mock<IReservationRepository>();

          
            // Act
            //var debstService = new DebtsService(_fakeReservationRepo);
            //var result = await debstService.SuskaiciuotiKiekTuriSkolu(id);

             var result = await _reservationRepo.SuskaiciuotiKiekTuriSkolu(id);

            // Assert
            Assert.AreEqual(expected, result);
            }


        public class MockDebtsService
        {
            public async Task<List<Reservation>> GetAllAsync()
            {
  
                return new List<Reservation>
                {
                new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(-15) },
                new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(-5) },
                new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(-10) },
                new Reservation { LocalUserId = 4, ActualReturnDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(-2) }
                };
            }
        }





        public class MockReservationRepository
        {
            public async Task<int> SuskaiciuotiKiekTuriSkolu(int id)
            {
                var visosRezervacija = await GetAllAsync();
                int skoluSkaicius = 0;

                foreach (var item in visosRezervacija)
                {
                    if (item.LocalUserId == id)
                    {
                        if (item.ActualReturnDate.HasValue && (((DateTime)item.ActualReturnDate - (DateTime)item.ReturnDate).TotalDays > 0))
                        {
                            skoluSkaicius++;
                        }
                        else if (item.ReturnDate < DateTime.Now)
                        {
                            skoluSkaicius++;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                return skoluSkaicius;
            }
            private async Task<List<Reservation>> GetAllAsync()
            {
                // Return a list of mock reservations with the specified user ID
                return new List<Reservation>
                {
                new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(-15) },
                new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(-5) },
                new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(-10) },
                new Reservation { LocalUserId = 4, ActualReturnDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(-2) }
                };
            }
        }

     
    }















}


