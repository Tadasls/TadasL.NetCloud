﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppMSSQL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMSSQL.Models;
using WebAppMSSQL.Models.Enums;

namespace WebAppMSSQL.Services.Tests
{
    [TestClass()]
    public class UserHelpServiceTests
    {
        //[TestMethod()]
        //public async Task GetFavoriteAutorsForUserTest()
        //{
        //    int fakeUserID = 1;

        //    var fakeReservationRepo = new List<Reservation>
        //         {
        //         new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now.AddDays(10), ReturnDate = DateTime.Now.AddDays(-30) },
        //         new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now.AddDays(20), ReturnDate = DateTime.Now.AddDays(-20) },
        //         new Reservation { LocalUserId = 1, ActualReturnDate = DateTime.Now.AddDays(30), ReturnDate = DateTime.Now.AddDays(-10) },
        //         new Reservation { LocalUserId = 4, ActualReturnDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(-2) }
        //         };


        //    var fakeBooksRepo = new List<Book>
        //         {
        //            new Book(1, "The Bible", "Several authors", ECoverType.Paperback, 0001,1),
        //        new Book(2, "Quotations from Chairman Mao Tse-Tung", "Mao Zedong", ECoverType.Hardcover, 1964, 2),
        //        new Book(3, "The Quran", "Several authors", ECoverType.Hardcover, 0700, 3),
        //        new Book(4, "The Lord Of The Rings", "John Tolkien", ECoverType.Hardcover, 1954, 4),
        //        new Book(5, "Le Petit Prince", "Antoine de Saint-Exupery", ECoverType.Electronic, 1943, 5),
        //        new Book(6, "Harry Potter and the Philosopher’s Stone", "Joanne Rowling", ECoverType.Paperback, 1997, 6),
        //        new Book(7, "Scouting for Boys", "Robert Baden-Powell", ECoverType.Paperback, 1908, 7),
        //        new Book(8, "And Then There Were None", "Agatha Christie", ECoverType.Paperback, 1939, 8),
        //        new Book(9, "The Hobbit", "John Tolkien ", ECoverType.Hardcover, 1937, 9),
        //        new Book(10, "The Dream Of The Red Chambe", "Cao Xueqin", ECoverType.Paperback, 1791, 10)
        //         };

           
        //    var expected = 3;
        //    var userHelpService = new UserHelpService();
        //    var result = await userHelpService.GetFavoriteAutorsForUser(fakeUserID, fakeReservationRepo, fakeBooksRepo);

        //    Assert.AreEqual(expected, result);
        //}
    }
}