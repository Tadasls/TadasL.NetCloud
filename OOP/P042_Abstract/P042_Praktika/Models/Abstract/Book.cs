using P043_Uzduotys.Models.Concrete;

namespace P042_Praktika.Models.Abstract
{
    public abstract class Book
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int BooksSold { get; set; }
        public int? Qtty { get; set; }
        public double? Price { get; set; }

        public virtual void SetDataTo(BookHtml bookHtml)
        {
            bookHtml.Genre = Genre;
            bookHtml.Title = Title;
            bookHtml.Author = Author;
            bookHtml.BooksSold = BooksSold.ToString();
            bookHtml.Qtty = Qtty.ToString();
        }
    }
}
