using ApiMokymai.Data.DTO;
using ApiMokymai.Interfaces;
using ApiMokymai.Models;

namespace ApiMokymai.Services
{
    public class BookManager: IBookManager
    {

        private readonly IBookSet _bookSet;
        private readonly IBookWraper _wrapper;

        public BookManager(IBookSet bookSet, IBookWraper bookWrapper)
        {
            _bookSet = bookSet;
            _wrapper = bookWrapper;
        }

        public List<GetBookDto> Get()
        {
            var sarasas = _bookSet.Books;
            var dto = sarasas.Select(s => _wrapper.Bind(s)).ToList();
            return dto;
        }

        public GetBookDto Get(int id) => Exists(id) ? _wrapper.Bind(_bookSet.Books.Where(b => b.Id == id).FirstOrDefault()) : throw new Exception();
       
        public bool Exists(int id) => _bookSet.Books.Where(b => b.Id == id).Any() ? true : false;

        public List<GetBookDto> Filter(Dictionary<string, string> filter)
        {
            IEnumerable<Book> books = _bookSet.Books;
            foreach (var item in filter)
            {
                if (item.Key == "Pavadinimas") books = books.Where(b => b.Title.ToLower() == item.Value.ToLower());
                if (item.Key == "Autorius") books = books.Where(b => b.Author.ToLower() == item.Value.ToLower());
                if (item.Key == "KnygosTipas") books = books.Where(b => (int)b.Cover == int.Parse(item.Value));
            }
            return books.Select(b => _wrapper.Bind(b)).ToList();
        }

        public int Add(CreateBookDto book)
        {
            var bookToAdd = _wrapper.Bind(book);
            _bookSet.Books.Add(bookToAdd);
            return bookToAdd.Id;
        }

        public void Update(UpdateBookDto book)
        {
            var bookToUpdate = _bookSet.Books.Find(b => b.Id == book.Id);
            bookToUpdate = _wrapper.Bind(book);
        }

        public void Delete(int id)
        {
            if (Exists(id))
                _bookSet.Books.Remove(_bookSet.Books.Where(b => b.Id == id).FirstOrDefault());
        }







    }
}
