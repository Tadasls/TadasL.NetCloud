using Castle.Core.Resource;
using DBHomeWorkMusicSalesShop.DTO;
using DBHomeWorkMusicSalesShop.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DBHomeWorkMusicSalesShop.DataBase
{
    public class ChinookRepository
    {
        private readonly ChinookContext _context;
        public ChinookRepository(ChinookContext context)
        {
            _context = context;
        }

        public IEnumerable<dynamic> GetCustomers()
        {
            using (var context = new ChinookContext())
            {
                //.Customers.Where(x => x.Country == country)
                var customersListByCountry = context.Customers
                    .Select(c => new
                    {
                        Vardas = c.FirstName,
                        Pavarde = c.LastName,
                        KlientoId = c.CustomerId,
                       // SaliesPavadinimas = c.Country,
                    });
                Console.WriteLine("sarasas:");
                foreach (var customer in customersListByCountry)
                {
                    Console.WriteLine($" {customer.KlientoId}, {customer.Vardas}, {customer.Pavarde}");
                }
                return customersListByCountry.ToList();
            }
        }
        public void GetInvoices(int customerId)
        {
            using (var context = new ChinookContext())
            {

                var klientoDuomenys = context.Customers
                    .Where(x => x.CustomerId == customerId)
                .Select(x => x);

                foreach (var klientas in klientoDuomenys)
                {
                    Console.WriteLine("Klientas : ");
                    Console.WriteLine($"" +
                        $" Vardas {klientas.FirstName}," +
                        $"\n Pavarde {klientas.LastName}," +
                        $"\n Adresas {klientas.Address}," +
                        $"\n Miestas {klientas.City}," +
                        $"\n Valstija {klientas.State}," +
                        $"\n Salis {klientas.Country}," +
                        $"\n Pasto Kodas {klientas.PostalCode}");

                }


                var invoisuSarasas = context.Invoices
             .Where(c => c.CustomerId == customerId)
             .Select(c => new
             {
                 SaskaitosId = c.CustomerId,
                 SumaViso = c.Total,
                 SaskaitosData = c.InvoiceDate,
                 PrekiuKiekis = c.InvoiceItems.Count,

             });

                Console.WriteLine(" Saskaitu sarasas:");
                Console.WriteLine(" ID / Data / Prekiu kiekis / Suma Viso:");

                foreach (var saskaita in invoisuSarasas)
                {
                    Console.WriteLine($" {saskaita.SaskaitosId} , {saskaita.SaskaitosData}, {saskaita.PrekiuKiekis}, {saskaita.SumaViso}");
                }
               
            }
        }

        public double? GetAllInvoices()
        {
            using (var context = new ChinookContext())
            {
                var invoisuSarasas = context.Invoices;


                double? veiklosPelnasEBIT = 0; 

                foreach (var saskaita in invoisuSarasas)
                {
                    veiklosPelnasEBIT = veiklosPelnasEBIT + saskaita.Total;

                }

                Console.WriteLine($" Veiklos pelnas {veiklosPelnasEBIT}");
                return veiklosPelnasEBIT;
            }
        }
        public double? GetAllInvoicesByTime()
        {
            using (var context = new ChinookContext())
            {
                Console.WriteLine("Iveskite metus nuo");
                int year1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Iveskite metus iki");
                int year2 = Convert.ToInt32(Console.ReadLine());


                var invoisuSarasas = context.Invoices
                    .Where(x=>x.InvoiceDate.Value.Year >= year1 && x.InvoiceDate.Value.Year >= year2)
                    ;


                double? veiklosPelnasEBIT = 0;

                foreach (var saskaita in invoisuSarasas)
                {
                    veiklosPelnasEBIT = veiklosPelnasEBIT + saskaita.Total;

                }

                Console.WriteLine($" Veiklos pelnas {veiklosPelnasEBIT}");
                return veiklosPelnasEBIT;
            }
        }


        public IEnumerable<dynamic> GetEmployees()
        {
            using (var context = new ChinookContext())
            {

                var darbuotojuIdSarasas = context.Employees
                    .Select(c => new
                    {
                        Vardas = c.FirstName,
                        Pavarde = c.LastName,
                        DarbuotojoId = c.EmployeeId,
                        
                    });
                Console.WriteLine("sarasas:");
                foreach (var darbuotojas in darbuotojuIdSarasas)
                {
                    Console.WriteLine($" {darbuotojas.DarbuotojoId}, {darbuotojas.Vardas}, {darbuotojas.Pavarde}");
                }
                return darbuotojuIdSarasas.ToList();
            }
        }
        public IEnumerable<dynamic> GetTracks()
        {
            using (var context = new ChinookContext())
            {

                var dainusarasas = context.Tracks
                    .Where(x => x.Active == true)
                    .OrderBy(x => x)  
                    .Select(x => new
                    {
                        IrasoId = x.TrackId,
                        Vardas = x.Name,
                        Kompozitorius = x.Composer,
                        Zanras = x.Genre,
                        ZanroPavadinimas = x.Genre.Name,
                        Albumas = x.Album,
                        AlbumoPavadinimas = x.Album.Title,
                        Trukme = x.Milliseconds,
                        Kaina = x.UnitPrice,
                        AktyvStatus = x.Active,
                    });

                Console.WriteLine("sarasas Dainu isrusiuotas pagal AZ :");
                foreach (var track in dainusarasas)
                {
                    Console.WriteLine($" {track.IrasoId}, {track.Vardas}");
                    //{track.Vardas},{track.Kompozitorius},{track.Zanras}, {track.Zanras.Name}, {track.Albumas}, {track.Albumas.Title}, {track.Trukme}, {track.Kaina}

                }
                return dainusarasas;
            }
        }
        public IEnumerable<dynamic> GetTracksSorted()
        {
            using (var context = new ChinookContext())
            {
               
                var dainusarasas = context.Tracks
                    .Where(x => x.Active == true)
                    .OrderByDescending(x => x)
                    .Select(x => new
                    {
                        IrasoId = x.TrackId,
                        Vardas = x.Name,
                        Kompozitorius = x.Composer,
                        Zanras = x.Genre,
                        ZanroPavadinimas = x.Genre.Name,
                        Albumas = x.Album,
                        AlbumoPavadinimas = x.Album.Title,
                        Trukme = x.Milliseconds,
                        Kaina = x.UnitPrice,
                        AktyvStatus = x.Active,
                    });

                Console.WriteLine("sarasas isrusiuotas ZA :");
                foreach (var track in dainusarasas)
                {
                    Console.WriteLine($" {track.IrasoId}, {track.Vardas}");
                    // {track.Kompozitorius},{track.Zanras}, {track.Zanras.Name}, {track.Albumas}, {track.Albumas.Title}, {track.Trukme}, {track.Kaina}
                    ;
                }
                return dainusarasas;
            }
        }


        public IEnumerable<dynamic> GetTracksByID(int trackId)
        {
            using (var context = new ChinookContext())
            {

                var dainusarasas = context.Tracks
                    .Where(x => x.TrackId == trackId)
                    .Select(c => new 
                    {
                        IrasoId = c.TrackId,
                        Vardas = c.Name,
                        Kompozitorius = c.Composer, 
                        Zanras = c.Genre.Name,
                        Albumas = c.Album.Title,
                        Trukme = c.Milliseconds,
                        Kaina = c.UnitPrice,


                    });
                Console.Clear();
                Console.WriteLine("sarasas pagal ID: ");
                Console.WriteLine(" | #       |  Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | ");

                foreach (var track in dainusarasas)
                {
                    Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras}, {track.Albumas}, {track.Trukme}, {track.Kaina},  {track.Zanras},  ");
                }
                return dainusarasas.ToList();
            }
        }
        public IEnumerable<dynamic> GetTracksByName(string trackName)
        {
            using (var context = new ChinookContext())
            {

                var dainusarasas = context.Tracks
                    .Where(x => x.Name == trackName)
                    .Select(c => new
                    {
                        IrasoId = c.TrackId,
                        Vardas = c.Name,
                        Kompozitorius = c.Composer,
                        Zanras = c.Genre.Name,
                        Albumas = c.Album.Title,
                        Trukme = c.Milliseconds,
                        Kaina = c.UnitPrice,

                    });
                Console.Clear();
                Console.WriteLine(" Surastas sarasas pagal Name:");
                if (dainusarasas.ToList().Count == 0)
                {
                    Console.WriteLine(" Pavadinimas nerastas"); 
                }


                foreach (var track in dainusarasas)
                {
                    Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras}, {track.Albumas}, {track.Trukme}, {track.Kaina},  {track.Zanras},  ");
                }
                return dainusarasas.ToList();


            }
        }
        public IEnumerable<dynamic> GetTracksByAlbumID(int albumId)
        {
            using (var context = new ChinookContext())
            {

                var dainusarasas = context.Tracks
                    .Where(x => x.AlbumId == albumId)
                    .Select(c => new 
                    {
                        IrasoId = c.TrackId,
                        Vardas = c.Name,
                        Kompozitorius = c.Composer,
                        Zanras = c.Genre.Name,
                        Albumas = c.Album.Title,
                        Trukme = c.Milliseconds,
                        Kaina = c.UnitPrice,


                    });
                Console.Clear();
                Console.WriteLine("sarasas pagal AlbumID: ");
                Console.WriteLine(" | #       |  Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | ");

                foreach (var track in dainusarasas)
                {
                    Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras}, {track.Albumas}, {track.Trukme}, {track.Kaina},  {track.Zanras},  ");
                }
                return dainusarasas.ToList();
            }
        }
        public IEnumerable<dynamic> GetTracksByAlbumName(string albumName)
        {
            using (var context = new ChinookContext())
            {

                var dainusarasas = context.Tracks
                    .Where(c => c.Album.Title == albumName)
                    .Select(c => new
                    {
                        IrasoId = c.TrackId,
                        Vardas = c.Name,
                        Kompozitorius = c.Composer,
                        Zanras = c.Genre.Name,
                        Albumas = c.Album.Title,
                        Trukme = c.Milliseconds,
                        Kaina = c.UnitPrice,
                    });
                Console.Clear();
                Console.WriteLine("sarasas pagal Albumname: ");
                Console.WriteLine(" | #       |  Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | ");

                foreach (var track in dainusarasas)
                {
                    Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras}, {track.Albumas}, {track.Trukme}, {track.Kaina},  {track.Zanras},  ");
                }
                return dainusarasas.ToList();
            }
        }
        public IEnumerable<dynamic> GetTracksByComposer(string composer)
        {
            using (var context = new ChinookContext())
            {

                var dainusarasas = context.Tracks
                    .Where(c => c.Composer == composer)
                    .Select(c => new
                    {
                        IrasoId = c.TrackId,
                        Vardas = c.Name,
                        Kompozitorius = c.Composer,
                        Zanras = c.Genre.Name,
                        Albumas = c.Album.Title,
                        Trukme = c.Milliseconds,
                        Kaina = c.UnitPrice,


                    });
                Console.Clear();
                Console.WriteLine("sarasas pagal Composer: ");
                Console.WriteLine(" | #       |  Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | ");

                foreach (var track in dainusarasas)
                {
                    Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras}, {track.Albumas}, {track.Trukme}, {track.Kaina},  {track.Zanras},  ");
                }
                return dainusarasas.ToList();
            }
        }
        public IEnumerable<dynamic> GetTracksByGenre(string genre)
        {
            using (var context = new ChinookContext())
            {

                var dainusarasas = context.Tracks
                    .Where(c => c.Genre.Name == genre)
                    .Select(c => new
                    {
                        IrasoId = c.TrackId,
                        Vardas = c.Name,
                        Kompozitorius = c.Composer,
                        Zanras = c.Genre.Name,
                        Albumas = c.Album.Title,
                        Trukme = c.Milliseconds,
                        Kaina = c.UnitPrice,

                    });
                Console.Clear();
                Console.WriteLine("sarasas pagal Composer: ");
                Console.WriteLine(" | #       |  Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | ");

                foreach (var track in dainusarasas)
                {
                    Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras}, {track.Albumas}, {track.Trukme}, {track.Kaina},  {track.Zanras},  ");
                }
                return dainusarasas.ToList();
            }
        }


        public void CreateNewCustomer(Customer customer)
        {
            using (var context = new ChinookContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }
        public void DeleteCustomer(long customerId)
        {
            using (var context = new ChinookContext())
            {
                var istrintasKlientoId = context.Customers.Find(customerId);
                context.Customers.Remove(istrintasKlientoId);
                context.SaveChanges();
            }
        }
        public void UpdateCustomerData(long customerId)
        {
            using (var context = new ChinookContext())
            {
                Customer newChanges = new Customer();
                var cust = context.Customers.Find(customerId);
                Console.WriteLine($"Vardas  {cust.FirstName}");
                newChanges.FirstName = Console.ReadLine();
                if (newChanges.FirstName != null) { cust.FirstName = newChanges.FirstName; }

                Console.WriteLine(cust.LastName);
                newChanges.LastName = Console.ReadLine();
                if (newChanges.LastName != null) { cust.LastName = newChanges.LastName; }

                Console.WriteLine(cust.Company);
                newChanges.Company = Console.ReadLine();
                if (newChanges.Company != null) { cust.Company = newChanges.Company; }

                if (newChanges.Address != null) { cust.Address = newChanges.Address; }
                if (newChanges.City != null) { cust.City = newChanges.City; }
                if (newChanges.State != null) { cust.State = newChanges.State; }
                if (newChanges.Country != null) { cust.Country = newChanges.Country; }
                if (newChanges.PostalCode != null) { cust.PostalCode = newChanges.PostalCode; }
                if (newChanges.Phone != null) { cust.Phone = newChanges.Phone; }
                if (newChanges.Fax != null) { cust.Fax = newChanges.Fax; }
                if (newChanges.Email != null) { cust.Email = newChanges.Email; }
                context.SaveChanges();
            }
        }







    }
}
