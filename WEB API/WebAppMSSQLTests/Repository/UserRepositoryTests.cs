using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppMSSQL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMSSQL.Models.DTO;
using Microsoft.Extensions.Logging;
using Moq;
using WebAppMSSQL.Controllers;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Services.IServices;
using WebAppMSSQL.Data;
using WebAppMSSQL.Services;

namespace WebAppMSSQL.Repository.Tests
{
    [TestClass()]
    public class UserRepositoryTests
    {
        //[TestMethod()]
        //public void LoginAsyncTest()
        //{
        //    var loginRequest = new LoginRequest
        //    {
        //        Username = "testuser",
        //        Password = "correctpassword"
        //    };


            
            
        //    //var membersService = new Mock<IMembershipService>();
        //    //var stockService = new Mock<IStockService>();
        //    //var userRepo = new Mock<IUserRepository>();
        //    //var userRepo = new KnygynasContext _db;
        //    //var userRepo = new IPasswordService _passwordService;
        //    //var jwtService  = new Mock<IJwtService>();
        //    //var membersService = new IMembershipService _membersService;




        //    var userService = new UserRepository(membersService.Object, stockService.Object);

        //    // Act
        //    var loginResponse =  userService.LoginAsync(loginRequest);

        //    // Assert
        //    Assert.IsNotNull(loginResponse);
        //}
    }
}