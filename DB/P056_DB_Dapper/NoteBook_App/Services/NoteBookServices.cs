using NoteBook_App.DataBase;
using NoteBook_App.DataBase.Dapper;
using NoteBook_App.Interfaces;
using NoteBook_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook_App.Services
{
    public class NoteBookServices : INoteBookService
    {
        private readonly DatabaseConfig _databaseConfig;
        private readonly INoteBookRepository _noteBookRepository;

        public NoteBookServices()
        {
            _databaseConfig = new DatabaseConfig();
            _noteBookRepository = new NoteBookRepository(_databaseConfig);
        }

        public void Run()
        {
            char selection;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add NoteBook");
                Console.WriteLine("2. List NoteBooks");
                Console.WriteLine("3. Remove NoteBooks with name");
                Console.WriteLine("4. Update");
                Console.WriteLine("q. Quit");

                selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        AddNotebook();
                        break;
                    case '2':
                        ShowNotebooks();
                        break;
                    case '3':
                        DeleteNotebooks();
                        break;
                    case '4':
                        UpdateNoteBook();
                        break;
                    case 'q':
                        return;
                    case 'Q':
                        return;
                    default:
                        break;
                }

                PauseScreen();
            }
        }

        public void UpdateNoteBook()
        {
            Console.WriteLine(" pasirinkite ka updatinti");
            ShowNotebooks();
                int updateNotebookId = Convert.ToInt32(Console.ReadLine());
            NoteBook notebook = _noteBookRepository.Get(updateNotebookId);
            if(notebook == null)
            {
                Console.WriteLine($"nera tokio {notebook?.Id}");
                return;
            }
            Console.WriteLine("\n\nPlease enter new name of the NoteBook:");
            notebook.Name = Console.ReadLine();
            Console.WriteLine("\n\nPlease enter new description of the NoteBook:");
            notebook.Description = Console.ReadLine();

            _noteBookRepository.UpdateNoteBook(notebook);

            Console.WriteLine($"\n{notebook.Id} - {notebook.Name} - {notebook.Description}  added to the database\n");

        }

        public void ShowNotebooks()
        {
            IEnumerable<NoteBook> notebooks = _noteBookRepository.Get();

            Console.WriteLine();

            foreach (NoteBook notebook in notebooks)
            {
                Console.WriteLine($"{notebook.Id}. {notebook.Name} - {notebook.Description}");
            }
        }

        public void AddNotebook()
        {
            NoteBook NewNoteBook = new NoteBook();
            Console.WriteLine("\n\nPlease enter name of the NoteBook:");
            NewNoteBook.Name = Console.ReadLine();
            Console.WriteLine("\n\nPlease enter description of the NoteBook:");
            NewNoteBook.Description = Console.ReadLine();
            Console.WriteLine("\n\nPlease enter Priority of the NoteBook:");
            NewNoteBook.Priority = Console.ReadLine();

            _noteBookRepository.Create(NewNoteBook);

            Console.WriteLine($"\n{NewNoteBook.Name} - {NewNoteBook.Description} - {NewNoteBook.Priority}  added to the database\n");
        }

        private void PauseScreen()
        {
            Console.WriteLine("{0}{1}Press any key to continue..", Environment.NewLine, Environment.NewLine);
            Console.ReadKey();
        }

        public void DeleteNotebooks()
        {
            Console.WriteLine("\n\nPlease enter name of the NoteBook that should be deleted:");
            string NOteBpookNameToDelete = Console.ReadLine();

            int noteBooksDeletedCount = _noteBookRepository.Delete(NOteBpookNameToDelete);

            Console.WriteLine($"\n{noteBooksDeletedCount} called {NOteBpookNameToDelete} were removed.\n");
        }
    }
}
