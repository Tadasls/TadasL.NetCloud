using NoteBook_App.DataBase;
using NoteBook_App.DataBase.Dapper;
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
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. List Products");
                Console.WriteLine("3. Remove Products with name");
                Console.WriteLine("q. Quit");

                selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        AddProduct();
                        break;
                    case '2':
                        DisplayProducts();
                        break;
                    case '3':
                        RemoveProduct();
                        break;
                    case 'q':
                        return;
                    default:
                        break;
                }

                PauseScreen();
            }
        }

        public void DisplayProducts()
        {
            var products = _noteBookRepository.Get();

            Console.WriteLine();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id}. {product.Name} - {product.Description}");
            }
        }

        public void AddProduct()
        {
            var newProduct = new NoteBook();
            Console.WriteLine("\n\nPlease enter name of the product:");
            newProduct.Name = Console.ReadLine();
            Console.WriteLine("\n\nPlease enter description of the product:");
            newProduct.Description = Console.ReadLine();

            _noteBookRepository.Create(newProduct);

            Console.WriteLine($"\n{newProduct.Name} - {newProduct.Description} added to the database\n");
        }

        private void PauseScreen()
        {
            Console.WriteLine("{0}{1}Press any key to continue..", Environment.NewLine, Environment.NewLine);
            Console.ReadKey();
        }

        public void RemoveProduct()
        {
            Console.WriteLine("\n\nPlease enter name of the product that should be deleted:");
            string productNameToDelete = Console.ReadLine();

            int productsDeletedCount = _noteBookRepository.Delete(productNameToDelete);

            Console.WriteLine($"\n{productsDeletedCount} called {productNameToDelete} were removed.\n");
        }
    }
}
