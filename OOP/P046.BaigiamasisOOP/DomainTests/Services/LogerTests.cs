using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace Domain.Services.Tests
{
    [TestClass()]
    public class LogerTests
    {
        public void CreateStringForTxt_Test()
        {
            //Arrange
            
            Tower fakeBokstas = new Tower();
            
           
           
            //var fileReader = new FileReader();
            //string path = fileReader.GetFilePath("LogTxt.txt");

            var fakeMove = 2;



            var expected = "žaidime kuris pradėtas "; //žaidime kuris pradėtas 2022 - 09 - 10 23 - 04, ėjimu nr 1 vienos dalių diskas buvo paimtas iš pirmo sulpelio ir padėtas į antra

            //Act
            //var actual = Logger.WriteLog();

            //Assert
        //    Assert.AreEqual(expected, actual);
        }
    }
}