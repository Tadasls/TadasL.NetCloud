using ApiMokymai.Books;

namespace ApiMokymai.Data
{
    public class Book
    {
        public Book() { }

        public Book(int id, string title, string author, ECoverType cover, int publishYear)
        {
            Id = id;
            Title = title;
            Author = author;
            PublishYear = publishYear;
            Cover = cover;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public ECoverType Cover { get; set; }
        public int PublishYear { get; set; }
    }
}
