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

namespace WebAppMSSQL.Controllers.Tests
{
    [TestClass()]
    public class ReservationControllerTests
    {
        //[TestMethod]
        //public async Task TestCreateReservation_Success()
        //{
        // //   Arrange
        //   var request = new CreateReservationDTO
        //   {
        //       LocalUserId = 1,
        //       BookId = 2,
        //       BorrowDate = DateTime.Now
        //   };

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

        // //   Act
        //   var result = await reservationController.CreateReservation(request);

        //   // Assert
        //    Assert.IsInstanceOfType(result, typeof(CreatedAtActionResult));
        //    Assert.AreEqual((result as CreatedAtActionResult).StatusCode, 201);
        //    Assert.IsInstanceOfType((result as CreatedAtActionResult).Value, typeof(CreateReservationDTO));
        //}
    }
}