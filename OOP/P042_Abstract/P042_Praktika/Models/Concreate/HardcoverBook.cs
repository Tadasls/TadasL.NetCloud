﻿using P042_Praktika.Models.Abstract;
using P043_Uzduotys.Models.Concrete;

namespace P042_Praktika.Models.Concrete
{
    public class HardcoverBook : Book
    {
        public override void SetDataTo(BookHtml bookHtml)
        {
            base.SetDataTo(bookHtml);
            bookHtml.HardcoverPrice = Price.ToString();
        }
    }
}