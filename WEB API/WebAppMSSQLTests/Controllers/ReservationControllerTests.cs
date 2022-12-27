using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppMSSQL.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WebAppMSSQL.Models.ReservationsDTO;
using WebAppMSSQL.Models;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Services.IServices;
using WebAppMSSQL.Models.DTO.UserTDO;
using WebAppMSSQL.Repository;
using System.Linq.Expressions;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebAppMSSQL.Services.Wraperiai;
using WebAppMSSQL.Services;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace WebAppMSSQL.Controllers.Tests
{
    [TestClass()]
    public class ReservationControllerTests
    {


        [TestMethod]
        public async Task TestGetAllReservations()
        {
            // Arrange
            var mockRepo = new Mock<IReservationRepository>();

            var logger = new Mock<ILogger<ReservationController>>();
            var membersService = new Mock<IMembershipService>();
            var reservationWrapper = new Mock<IReservationWrapper>();
            var debtsService = new Mock<IDebtsService>();
            var stockService = new Mock<IStockService>();
            var userRepo = new Mock<IUserRepository>();
            var bookRepo = new Mock<IUpdateBookRepository>();


            var fakeOb = new List<Reservation>
            {
            new Reservation { LocalUserId = 1, BookId = 1, BorrowDate = new DateTime(2022, 1, 1), ReturnDate = new DateTime(2022, 1, 15) },
            new Reservation { LocalUserId = 2, BookId = 2, BorrowDate = new DateTime(2022, 2, 1), ReturnDate = new DateTime(2022, 2, 15) },
            new Reservation { LocalUserId = 3, BookId = 3, BorrowDate = new DateTime(2022, 3, 1), ReturnDate = new DateTime(2022, 3, 15) }
            };

            mockRepo.Setup(repo => repo.GetAllAsync(It.IsAny<Expression<Func<Reservation, bool>>>())).ReturnsAsync(fakeOb);

            var controller = new ReservationController(mockRepo.Object, membersService.Object, logger.Object,
                userRepo.Object, bookRepo.Object, stockService.Object, debtsService.Object, reservationWrapper.Object);


            // Act
            var result = await controller.GetAllReservations(new FilterReservationDTO());

            // Assert
            Assert.IsInstanceOfType(result.Result, typeof(OkObjectResult));
            //  Assert.AreEqual(3, (result.Result as OkObjectResult).Value);




        }









        //var req = new FilterReservationDTO
        //{
        //    LocalUserId = 1,
        //    BookId = 2,
        //    ReturnDate = DateTime.Today,
        //    BorrowDate = DateTime.Today.AddDays(-10)
        //};

        //var reservationController = new ReservationController(reservation_repository_mock.Object, reservation_wraper_mock.Object, req);







        //[TestMethod]
        //public async Task TestCreateReservation_Success()
        //{
        //    //   Arrange
        //    var request = new CreateReservationDTO
        //    {
        //        LocalUserId = 1,
        //        BookId = 2,
        //        BorrowDate = DateTime.Now,
               
        //    };

        //    var mockUserRepo = new Mock<IUserRepository>();
        //    mockUserRepo.Setup(repo => repo.IsRegisteredAsync(request.LocalUserId)).ReturnsAsync(true);
        //    mockUserRepo.Setup(repo => repo.GetAsync(u => u.Id == request.LocalUserId)).ReturnsAsync(new GetUserDto { Id = request.LocalUserId, HasAmountOfBooks = 4 });

        //    var mockBookRepo = new Mock<IUpdateBookRepository>();
        //    mockBookRepo.Setup(repo => repo.ExistAsync(b => b.Id == request.BookId)).ReturnsAsync(true);
        //   // mockBookRepo.Setup(repo => repo.GetAsync(b => b.Id == request.BookId)).ReturnsAsync(new Book { Id = request.BookId, Stock = 1 });
           



        //    var mockDebtsService = new Mock<IDebtsService>();
        //   // mockDebtsService.Setup(service => service.CountDelayDays(request.LocalUserId)).ReturnsAsync(0);
        //    mockDebtsService.Setup(service => service.SuskaiciuotiSkolosDydi(0)).Returns(0);
        //   // mockDebtsService.Setup(service => service.CountDebtsAmount(request.LocalUserId)).ReturnsAsync(1);

        //    var mockReservationRepo = new Mock<IReservationRepository>();
        //    mockReservationRepo.Setup(repo => repo.CreateAsync(It.IsAny<Reservation>())).Returns(Task.CompletedTask);

        //    var mockStockService = new Mock<IStockService>();
        //    mockStockService.Setup(service => service.UpdateTakenLibraryBooks(request.LocalUserId, 1)).Returns(Task.CompletedTask);
        //    mockStockService.Setup(service => service.UpdateTakenLibraryBooksKN(request.BookId, -1)).Returns(Task.CompletedTask);


        //    var mockMembersService = new Mock<IMembershipService>();
        //    var mockLogger = new Mock<ILogger<ReservationController>>();
        //    var mockReservationWrapper = new Mock<IReservationWrapper>();


        //    var reservationController = new ReservationController(mockReservationRepo.Object, mockMembersService.Object, mockLogger.Object,
        //     mockUserRepo.Object, mockBookRepo.Object, mockStockService.Object, mockDebtsService.Object, mockReservationWrapper.Object);


        //    //   Act
        //    var result = await reservationController.CreateReservation(request);

        //    // Assert
        //    Assert.IsInstanceOfType(result, typeof(CreatedAtActionResult));
        //    //Assert.AreEqual((result as CreatedAtActionResult).StatusCode, 201);
        //    //Assert.IsInstanceOfType((result as CreatedAtActionResult).Value, typeof(CreateReservationDTO));
          




    }
}

