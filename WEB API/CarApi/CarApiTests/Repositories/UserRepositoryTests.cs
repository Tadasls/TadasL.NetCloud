using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarApi.Controllers;
using CarApi.Models.Dto;
using CarApi.Repositories.Interfaces;
using CarApi.Services.Interfaces;
using CarApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;

namespace CarApi.Repositories.Tests
{



    [TestClass()]
    public class UserControllerTests
    {

        Mock<IConfiguration> mockConfiguration = new Mock<IConfiguration>();

        [TestInitialize]
        public void OnInicialize()
        {
            Mock<IConfigurationSection> mockSection = new Mock<IConfigurationSection>();
            mockSection.Setup(x => x.Value).Returns(Guid.NewGuid().ToString());
            mockConfiguration.Setup(x => x.GetSection(It.IsAny<string>())).Returns(mockSection.Object);
        }



        [TestMethod()]
        public void LoginAsync_shouldBeOk_Test()
        {
            var fake_username = "testas";
            var fake_password = "testas";
            var fake_user = new Models.LocalUser { Id = 1, UserName = fake_username, Role = "admin" };



            Mock<IUserRepository> mockUserRepository = new Mock<IUserRepository>();
            mockUserRepository.Setup(x => x.TryLogin(fake_username, fake_password, out fake_user)).Returns(true); //grazinamas kazkoks useris ir nekvieciama db



            IJwtService jwtService = new JwtService(mockConfiguration.Object);

            //Mock<IJwtService> mockJwtService = new Mock<IJwtService>();
            //mockJwtService.Setup(x => x.GetJwtToken(It.IsAny<int>(), It.IsAny<string>())).Returns("test_token");

            //Mock<IUserService> mockUserService = new Mock<IUserService>();
            //mockUserService.Setup(x => x.VerifyPasswordHash(It.IsAny<string>(), It.IsAny<byte[]>(), It.IsAny<byte[]>())).Returns(true);
            IUserService userService = new UserService();

            var sut = new UserController(mockUserRepository.Object, userService, jwtService);
            var actual = sut.Login(new LoginRequest { UserName = fake_username, Password = fake_password });

            Assert.IsInstanceOfType(actual, typeof(OkObjectResult));
        }
        [TestMethod()]
        public void LoginAsyncTest_shouldBeBadLogin()
        {
            var fake_username = "testas";
            var fake_password = "testas";
            var fake_user = new Models.LocalUser { Id = 1, UserName = fake_username, Role = "admin" };

            Mock<IUserRepository> mockUserRepository = new Mock<IUserRepository>();
            mockUserRepository.Setup(x => x.TryLogin(fake_username, fake_password, out fake_user)).Returns(false); //grazinamas kazkoks useris ir nekvieciama db

            IJwtService jwtService = new JwtService(mockConfiguration.Object);
            IUserService userService = new UserService();

            var sut = new UserController(mockUserRepository.Object, userService, jwtService);
            var actual = sut.Login(new LoginRequest { UserName = fake_username, Password = fake_password });

            Assert.IsInstanceOfType(actual, typeof(UnauthorizedObjectResult));
        }
    }
}