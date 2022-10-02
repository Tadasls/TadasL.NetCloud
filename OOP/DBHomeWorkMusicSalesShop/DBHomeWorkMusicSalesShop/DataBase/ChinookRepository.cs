using Castle.Core.Resource;
using DBHomeWorkMusicSalesShop.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DBHomeWorkMusicSalesShop.DataBase
{
    public class ChinookRepository
    {
        private readonly ChinookContext _context;
        public ChinookRepository(ChinookContext context)
        {
            _context = context;
        }

        public virtual IEnumerable<dynamic> GetCustomers()
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
                    .Where(x => x.InvoiceDate.Value.Year >= year1 && x.InvoiceDate.Value.Year <= year2);


                double? veiklosPelnasEBIT = 0;

                foreach (var saskaita in invoisuSarasas)
                {
                    veiklosPelnasEBIT = veiklosPelnasEBIT + saskaita.Total;

                }

                Console.WriteLine($" Veiklos pelnas {veiklosPelnasEBIT}");
                return veiklosPelnasEBIT;
            }
        }
        public void GetAllInvoicesDataByZanras()
        {
            using (var context = new ChinookContext())
            {

                var invoicesItem = context.Genres
                 .Include(x => x.Tracks)
                 .ThenInclude(x => x.InvoiceItems)
                 .ToList();


                foreach (var item in invoicesItem)
                {
                    Console.WriteLine($"{item.Name}");
                    Console.WriteLine($"{item.Tracks.Count()}");

                }
            }

        }
        public void GetAllInvoicesByCustomers()
        {

            using (var context = new ChinookContext())
            {

                var invoicesItem = context.Invoices
                    .Include(x => x.InvoiceItems)
                    .ThenInclude(y => y.Track)
                    .ThenInclude(y => y.Genre)
                    .ToList();

               
                foreach (var item in invoicesItem)
                {
                    Console.WriteLine($"{item.Customer.FirstName}"); 
                    Console.WriteLine($"{item.Total }");
                }


            }




            /*
             * 
 select	
SUM(invoices.total ) as Suma ,
customers.FirstName as klientoVardas,
customers.LastName as KlientoPavarde
from Invoices 
Inner join customers on invoices.CustomerId = customers.CustomerId
Group By invoices.CustomerId

 */
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
        public IEnumerable<dynamic> GetTracksForAdmins()
        {
            using (var context = new ChinookContext())
            {
                var dainusarasas = context.Tracks
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
                        Aktyvumas = x.Active,
                    });

                Console.WriteLine("sarasas Dainu isrusiuotas pagal AZ :");
                if (dainusarasas.ToList().Count == 0)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else
                {
                    foreach (var track in dainusarasas)
                    {
                        Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras.Name}, {track.Albumas.Title}, {track.Trukme}, {track.Kaina} ");
                    }
                }
                return dainusarasas;
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
                        Aktyvumas = x.Active,
                    });

                Console.WriteLine("sarasas Dainu isrusiuotas pagal AZ :");
                if (dainusarasas.ToList().Count == 0)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else if (dainusarasas.FirstOrDefault().Aktyvumas == false)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else
                {
                    foreach (var track in dainusarasas)
                    {
                        Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras.Name}, {track.Albumas.Title}, {track.Trukme}, {track.Kaina} ");
                    }
                }
                return dainusarasas.ToList();
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
                        Aktyvumas = x.Active,
                    });


                Console.WriteLine("sarasas isrusiuotas ZA :");


                if (dainusarasas.ToList().Count == 0)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else if (dainusarasas.FirstOrDefault().Aktyvumas == false)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else
                {
                    foreach (var track in dainusarasas)
                    {
                        Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras.Name}, {track.Albumas.Title}, {track.Trukme}, {track.Kaina} ");
                    }
                }
                return dainusarasas.ToList();
            }
        }
        public IEnumerable<dynamic> GetTracksByGenre()
        {
            using (var context = new ChinookContext())
            {
                var dainusarasas = context.Tracks
                    .Where(x => x.Active == true)
                    .OrderBy(x => x.Genre)
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
                        Aktyvumas = x.Active,
                    });

                Console.WriteLine("sarasas Dainu isrusiuotas pagal Genre :");
                if (dainusarasas.ToList().Count == 0)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else if (dainusarasas.FirstOrDefault().Aktyvumas == false)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else
                {
                    foreach (var track in dainusarasas)
                    {
                        Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras.Name}, {track.Albumas.Title}, {track.Trukme}, {track.Kaina} ");
                    }
                }
                return dainusarasas.ToList();
            }
        }
        public IEnumerable<dynamic> GetTracksByComposer()
        {
            using (var context = new ChinookContext())
            {
                var dainusarasas = context.Tracks
                    .Where(x => x.Active == true)
                    .OrderBy(x => x.Composer)
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
                        Aktyvumas = x.Active,
                    });

                Console.WriteLine("sarasas Dainu isrusiuotas pagal Kompozitoriu :");
                if (dainusarasas.ToList().Count == 0)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else if (dainusarasas.FirstOrDefault().Aktyvumas == false)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else
                {
                    foreach (var track in dainusarasas)
                    {
                        Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras.Name}, {track.Albumas.Title}, {track.Trukme}, {track.Kaina} ");
                    }
                }
                return dainusarasas.ToList();
            }
        }
        public IEnumerable<dynamic> GetTracksByComposerAndAlbum()
        {
            using (var context = new ChinookContext())
            {
                var dainusarasas = context.Tracks
                    .Where(x => x.Active == true)
                    .OrderBy(x => x.Composer)
                    .OrderBy(y=>y.Album)
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
                        Aktyvumas = x.Active,
                    });

                Console.WriteLine("sarasas Dainu isrusiuotas pagal Kompozitoriu ir Albuma:");
                if (dainusarasas.ToList().Count == 0)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else if (dainusarasas.FirstOrDefault().Aktyvumas == false)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else
                {
                    foreach (var track in dainusarasas)
                    {
                        Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras.Name}, {track.Albumas.Title}, {track.Trukme}, {track.Kaina} ");
                    }
                }
                return dainusarasas.ToList();
            }
        }

        public IEnumerable<dynamic> GetTracksByID(int trackId)
        {
            using (var context = new ChinookContext())
            {

                var dainusarasas = context.Tracks
                    .Where(x => x.TrackId == trackId)
                    .Where(x => x.Active == true)
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
                        Aktyvumas = x.Active,


                    });
                Console.Clear();
                Console.WriteLine("sarasas pagal ID: ");
                Console.WriteLine(" | #       |  Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | ");

                if (dainusarasas.ToList().Count == 0)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else if (dainusarasas.FirstOrDefault().Aktyvumas == false)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else
                {
                    foreach (var track in dainusarasas)
                    {
                        Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras.Name}, {track.Albumas.Title}, {track.Trukme}, {track.Kaina} ");
                    }
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
                    .Where(x => x.Active == true)
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
                        Aktyvumas = x.Active,

                    });

                Console.Clear();
                Console.WriteLine(" Surastas sarasas pagal Name:");

                if (dainusarasas.ToList().Count == 0)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else if (dainusarasas.FirstOrDefault().Aktyvumas == false)
                {
                    Console.WriteLine(" Pavadinimas nerastas");
                }
                else
                {
                    foreach (var track in dainusarasas)
                    {
                        Console.WriteLine($" {track.IrasoId}, {track.Vardas}, {track.Kompozitorius}, {track.Zanras.Name}, {track.Albumas.Title}, {track.Trukme}, {track.Kaina} ");
                    }
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
                    .Where(x => x.Active == true)
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
                    .Where(x => x.Active == true)
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
                    .Where(x => x.Active == true)
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
                    .Where(x => x.Active == true)
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
        public IEnumerable<dynamic> GetTracksByComposerAndAlbum(string ieskomaskompozitorius, string ieskomasAlbumas)
        {

            using (var context = new ChinookContext())
            {
                
                var dainusarasas = context.Tracks
                    .Where(x => x.Active == true)
                    .Where(x => x.Composer == ieskomaskompozitorius)
                    .OrderBy(x => x.Composer)
                    .Include(x => x.Genre)
                    .Include(a => a.Album)
                    .Where(x => x.Album.Title == ieskomasAlbumas)
                    .OrderBy(x => x.Album.Title)
                    .ToList();

                Console.Clear();
                Console.WriteLine("sarasas pagal Composer ir albuma: ");
                Console.WriteLine(" | #       |  Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | ");

                foreach (var track in dainusarasas)
                {
                    Console.WriteLine($" {track.TrackId}, {track.Name}, {track.Composer}, {track.Genre}, {track.Album}, {track.Milliseconds}, {track.UnitPrice} ");
                }
                return dainusarasas.ToList();
            }
        }
        public IEnumerable<dynamic> GetTracksByLenght(int ieskomaPagalNuoMili, int ieskomaPagalIkiMili)
        {
            using (var context = new ChinookContext())
            {

                var dainusarasas = context.Tracks
                    .Where(x => x.Active == true)
                    .Include(x => x.Genre)
                    .Where(x => x.Milliseconds > ieskomaPagalNuoMili)
                    .Where(x => x.Milliseconds < ieskomaPagalIkiMili)
                    .ToList();

                Console.Clear();
                Console.WriteLine("sarasas pagal Trukme: ");
                Console.WriteLine(" | #       |  Name, Composer, Genre->Name, Album->Title, Milliseconds, Price | ");

                foreach (var track in dainusarasas)
                {
                    Console.WriteLine($" {track.TrackId}, {track.Name}, {track.Composer}, {track.Genre}, {track.Album}, {track.Milliseconds}, {track.UnitPrice} ");
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
        public void CreateNewInvoice(Invoice invoice)
        {
            using (var context = new ChinookContext())
            {
                context.Invoices.Add(invoice);
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
                 Console.WriteLine($"FirstName  {cust.FirstName} | Suveskite Naujus duomenis: ");
                newChanges.FirstName = Console.ReadLine();
                if (newChanges.FirstName != "") { cust.FirstName = newChanges.FirstName; }

                Console.WriteLine($"LastName  {cust.LastName}| Suveskite Naujus duomenis:");
                newChanges.LastName = Console.ReadLine();
                if (newChanges.LastName != "") { cust.LastName = newChanges.LastName; }

                Console.WriteLine($"Company  {cust.Company}| Suveskite Naujus duomenis:");
                newChanges.Company = Console.ReadLine();
                if (newChanges.Company != "") { cust.Company = newChanges.Company; }

                Console.WriteLine($"Address  {cust.Address}| Suveskite Naujus duomenis:");
                newChanges.Address = Console.ReadLine();
                if (newChanges.Address != "") { cust.Address = newChanges.Address; }

                Console.WriteLine($"City  {cust.City}| Suveskite Naujus duomenis:");
                newChanges.City = Console.ReadLine();
                if (newChanges.City != "") { cust.City = newChanges.City; }

                Console.WriteLine($"State  {cust.State}| Suveskite Naujus duomenis:");
                newChanges.State = Console.ReadLine();
                if (newChanges.State != "") { cust.State = newChanges.State; }

                Console.WriteLine($"Country  {cust.Country}| Suveskite Naujus duomenis:");
                newChanges.Country = Console.ReadLine();
                if (newChanges.Country != "") { cust.Country = newChanges.Country; }

                Console.WriteLine($"PostalCode  {cust.PostalCode}| Suveskite Naujus duomenis:");
                newChanges.PostalCode = Console.ReadLine();
                if (newChanges.PostalCode != "") { cust.PostalCode = newChanges.PostalCode; }

                Console.WriteLine($"Phone  {cust.Phone}| Suveskite Naujus duomenis:");
                newChanges.Phone = Console.ReadLine();
                if (newChanges.Phone != "") { cust.Phone = newChanges.Phone; }

                Console.WriteLine($"Fax  {cust.Fax}| Suveskite Naujus duomenis:");
                newChanges.Fax = Console.ReadLine();
                if (newChanges.Fax != "") { cust.Fax = newChanges.Fax; }

                Console.WriteLine($"Email  {cust.Email}| Suveskite Naujus duomenis:");
                newChanges.Email = Console.ReadLine();
                if (newChanges.Email != "") { cust.Email = newChanges.Email; }
                context.SaveChanges();
            }
        }
        public void UpdateTrackData(long trackId)
        {
            using (var context = new ChinookContext())
            {
                Console.Clear();
                Track newData = new Track();
                var trx = context.Tracks.Find(trackId);
                Console.WriteLine($"Dabartinis Statusas yra {trx.Active.ToString().Replace("True", "Active").Replace("False", "Inactive")} ar norite Deaktyvuoti  press - Y /  jei Aktyvuoti press A / q - gryzti atgal ");
                char input = Console.ReadKey().KeyChar;
                if (input == 'q' || input == 'Q') return;
                if (input == 'Y' || input == 'y') { newData.Active = false; }
                if (input == 'A' || input == 'a') { newData.Active = true; }
                if (newData.Active != null) { trx.Active = newData.Active; }
                context.SaveChanges();
            }
        }

    }
 }

