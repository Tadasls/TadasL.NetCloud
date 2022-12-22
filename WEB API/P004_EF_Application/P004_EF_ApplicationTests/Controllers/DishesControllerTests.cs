using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using P004_EF_Application.Models;
using P004_EF_Application.Models.Dto;
using P004_EF_Application.Repository.IRepository;
using P004_EF_Application.Services.Adapters.IAdapters;

namespace P004_EF_Application.Controllers.Tests
{
    [TestClass()]
    public class DishesControllerTests
    {
        [TestMethod]
        public async Task GetDishes_Should_returnAllDischesTest()
        {
            // Arrange
            var dish_repository_mock = new Mock<IDishRepository>();
            var dish_adapter_mock = new Mock<IDishAdapter>();

            var fakeOb = new List<Dish>
            {
            new Dish { DishId = 1, Name = "Pizza", Type = "testas", SpiceLevel = "Low", Country = "Lt", RecipeItems = new List<RecipeItem>() },
            new Dish { DishId = 1, Name = "Pizza2", Type = "testas2", SpiceLevel = "Low2", Country = "Lt2", RecipeItems = new List<RecipeItem>() },
            };

            var expected = new List<GetDishDTO>
            {
                new GetDishDTO(fakeOb[0]),
                new GetDishDTO(fakeOb[1])
            };

            dish_repository_mock.Setup(d => d.GetAllAsync(It.IsAny<Expression<Func<Dish, bool>>>()))
                .ReturnsAsync(fakeOb);

            var dishController = new DishesController(dish_repository_mock.Object, dish_adapter_mock.Object);

            // Act
            var sut = await dishController.GetDishes() as OkObjectResult; //subject under test

            // Assert
            Assert.AreEqual(expected[0].Name, (sut.Value as List<GetDishDTO>)[0].Name);
            Assert.AreEqual(expected[1].Name, (sut.Value as List<GetDishDTO>)[1].Name);
        }
    

    }
}