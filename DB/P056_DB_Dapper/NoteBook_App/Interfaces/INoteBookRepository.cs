using NoteBook_App.Models;

namespace NoteBook_App.Interfaces
{
    public interface INoteBookRepository
    {
        public void Create(NoteBook notebook);
        public IEnumerable<NoteBook> Get();
        public NoteBook Get(int notebookId);
        public int Delete(string productName);

        public void UpdateNoteBook(NoteBook notebook);
    }
}