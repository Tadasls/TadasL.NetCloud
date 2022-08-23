using Microsoft.VisualStudio.TestTools.UnitTesting;
using P038_Integerence.Models;
using P038_Praktika.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038_Praktika.Models.Tests
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

        [TestMethod()]
        public void EncodeCsvTest1()
        {
            var fake = "1";
            var hobby = new Hobby();
            hobby.EncodeCsv(fake);
            var expected = new Hobby(0, null, null);

            Assert.AreEqual(expected.Text, hobby.Text);
            Assert.AreEqual(expected.TextLt, hobby.TextLt);
        }
    }
}