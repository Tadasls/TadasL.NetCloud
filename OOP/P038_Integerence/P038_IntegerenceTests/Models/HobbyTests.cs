using Microsoft.VisualStudio.TestTools.UnitTesting;
using P038_Integerence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038_Integerence.Models.Tests
{
    [TestClass()]
    public class HobbyTests
    {
        [TestMethod()]
        public void EncodeCsvTest()
        {
            var fake = "1,Astrology,Astrologija";
            var hobby = new Hobby();
            hobby.EncodeCsv(fake);
            var expected = new Hobby(1, "Astrology", "Astrologija");

            Assert.AreEqual(expected.Text, hobby.Text);
            Assert.AreEqual(expected.TextLt, hobby.TextLt);
        }
    }
}