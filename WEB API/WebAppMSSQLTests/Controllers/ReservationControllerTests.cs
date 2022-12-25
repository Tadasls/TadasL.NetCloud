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

namespace WebAppMSSQL.Controllers.Tests
{
    [TestClass()]
    public class ReservationControllerTests
    {

     //   [TestMethod]
     //   public async Task GetDishes_Should_returnAllDischesTest()
     //   {
     //       // Arrange
     //       var reservation_repository_mock = new Mock<IReservationRepository>();
     //       var reservation_wraper_mock = new Mock<IReservationWrapper>();

     //       FilterReservationDTO req = null;

     //       var fakeOb = new List<Reservation>
     //       {
     //       new Reservation { Id = 1, BorrowDate =  DateTime.Now, ReturnDate = DateTime.Now.AddDays(28), ActualReturnDate = DateTime.Now.AddDays(35), LocalUserId = 1, /*LocalUser = new List<LocalUser>(),*/ BookId = 1,/* Book = new List<Book>(),*/ Active = true },
     //      //  new Reservation { Id = 1, BorrowDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(28), ActualReturnDate = DateTime.Now.AddDays(35), LocalUserId = 1, /*LocalUser = new List<LocalUser>(),*/ BookId = 1,/* Book = new List<Book>(),*/ Active = true },
     //       };

     //       var expected = new List<GetReservationDTO>
     //       {
     //           new GetReservationDTO(fakeOb[0]),
     ////           new GetReservationDTO(fakeOb[1])
     //       };

     //       reservation_repository_mock.Setup(d => d.GetAllAsync(It.IsAny<Expression<Func<Reservation, bool>>>()))
     //           .ReturnsAsync(fakeOb);

     //       var reservationController = new ReservationController(reservation_repository_mock.Object, reservation_wraper_mock.Object, req);

     //       // Act
     //       var sut = await reservationController.GetAllReservations() as OkObjectResult; //subject under test

     //       // Assert
     //       Assert.AreEqual(expected[0].LocalUserId, (sut.Value as List<Reservation>)[0].LocalUserId);
     //       Assert.AreEqual(expected[1].BookId, (sut.Value as List<Reservation>)[1].BookId);





            //[TestMethod]
            //public async Task TestCreateReservation_Success()
            //{
            //    //   Arrange
            //    var request = new CreateReservationDTO
            //    {
            //        LocalUserId = 1,
            //        BookId = 2,
            //        BorrowDate = DateTime.Now
            //    };

            //    var mockUserRepo = new Mock<IUserRepository>();
            //    mockUserRepo.Setup(repo => repo.IsRegisteredAsync(request.LocalUserId)).ReturnsAsync(true);
            //    mockUserRepo.Setup(repo => repo.GetAsync(u => u.Id == request.LocalUserId)).ReturnsAsync(new GetUserDto { Id = request.LocalUserId, HasAmountOfBooks = 4 });

            //    var mockBookRepo = new Mock<IUpdateBookRepository>();
            //    mockBookRepo.Setup(repo => repo.ExistAsync(b => b.Id == request.BookId)).ReturnsAsync(true);
            //    mockBookRepo.Setup(repo => repo.GetAllAsync(b => b.Id == request.BookId)).ReturnsAsync(new Book { Id = request.BookId, Stock = 1 });

            //    var mockDebtsService = new Mock<IDebtsService>();
            //    mockDebtsService.Setup(service => service.SuskaiciuotiKiekDienuVeluojamaGrazinti(request.LocalUserId)).ReturnsAsync(0);
            //    mockDebtsService.Setup(service => service.SuskaiciuotiSkolosDydi(0)).Returns(0);
            //    mockDebtsService.Setup(service => service.SuskaiciuotiKiekTuriSkolu(request.LocalUserId)).ReturnsAsync(1);

            //    var mockReservationRepo = new Mock<IReservationRepository>();
            //    mockReservationRepo.Setup(repo => repo.CreateAsync(It.IsAny<Reservation>())).Returns(Task.CompletedTask);

            //    var mockStockService = new Mock<IStockService>();
            //    mockStockService.Setup(service => service.UpdateTakenLibraryBooks(request.LocalUserId, 1)).Returns(Task.CompletedTask);
            //    mockStockService.Setup(service => service.UpdateTakenLibraryBooksKN(request.BookId, -1)).Returns(Task.CompletedTask);

            //    var reservationController = new ReservationController(mockUserRepo.Object, mockBookRepo.Object, mockDebtsService.Object, mockReservationRepo.Object, mockStockService.Object);

            //    //   Act
            //    var result = await reservationController.CreateReservation(request);

            //    // Assert
            //    Assert.IsInstanceOfType(result, typeof(CreatedAtActionResult));
            //    Assert.AreEqual((result as CreatedAtActionResult).StatusCode, 201);
            //    Assert.IsInstanceOfType((result as CreatedAtActionResult).Value, typeof(CreateReservationDTO));
            //}






     }
}
