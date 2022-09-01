using P034_Praktika.Models;
using P042_Praktika.Enums;
using P042_Praktika.Models.Abstract;
using P043_Uzduotys.Models.Abstract;
using P043_Uzduotys.Models.Concrete;

namespace P043_Uzduotys.Interfaces
{
    public interface IUniversityBookStore
    {
        void Fill(string dataSeed);
        void Buy(Book book, int qtty);
        Invoice Sale(BookStorePerson person, string title, BookType bookType, int qtty);
    }
}
