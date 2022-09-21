using NoteBook_App.Models;

namespace NoteBook_App.DataBase
{
    public interface INoteBookRepository
    {
        public void Create(NoteBook product);
        public IEnumerable<NoteBook> Get();
        public int Delete(string productName);
    }
}