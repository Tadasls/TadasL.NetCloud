using Castle.Core.Resource;
using DBHomeWorkMusicSalesShop.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
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
                    .Where(x => x.InvoiceDate.Value.Year >= year1 && x.InvoiceDate.Value.Year >= year2)
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
        public void GetAllInvoicesByZanras()
        {

            using (var context = new ChinookContext())
            {
                //using (var dbContextTransaction = context.Database.BeginTransaction())
                //{

                // ExecuteSqlRaw yra atliekamas iskart (Po panaudojimo pats call'ina context.SaveChanges())
                //var results = context.Database.
                //string query = @" select	
                // SUM(invoice_items.UnitPrice ) as Suma ,
                //    genres.Name as Pavadinimai 
                //    from invoice_items 
                //     Inner Join  Tracks  on invoice_items.TrackId =tracks.TrackId
                //    Inner JOIN genres On tracks.GenreId = genres.GenreId
                //    GROUP By genres.name";



                //    // context.SaveChanges();
                //   var test =  results.ToString();
                //   dbContextTransaction.Commit();

                ////}
                ///

                    
            }

        }


        /*
         select	
SUM(invoices.total ) as Suma ,
customers.FirstName as klientoVardas,
customers.LastName as KlientoPavarde
from Invoices 
Inner join customers on invoices.CustomerId = customers.CustomerId
Group By invoices.CustomerId

         */



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
                Console.WriteLine($"FirstName  {cust.FirstName}");
                newChanges.FirstName = Console.ReadLine();
                if (newChanges.FirstName != null) { cust.FirstName = newChanges.FirstName; }

                Console.WriteLine($"LastName  {cust.LastName}");
                newChanges.LastName = Console.ReadLine();
                if (newChanges.LastName != null) { cust.LastName = newChanges.LastName; }

                Console.WriteLine($"Company  {cust.Company}");
                newChanges.Company = Console.ReadLine();
                if (newChanges.Company != null) { cust.Company = newChanges.Company; }

                Console.WriteLine($"Address  {cust.Address}");
                newChanges.Address = Console.ReadLine();
                if (newChanges.Address != null) { cust.Address = newChanges.Address; }

                Console.WriteLine($"City  {cust.City}");
                newChanges.City = Console.ReadLine();
                if (newChanges.City != null) { cust.City = newChanges.City; }

                Console.WriteLine($"State  {cust.State}");
                newChanges.State = Console.ReadLine();
                if (newChanges.State != null) { cust.State = newChanges.State; }

                Console.WriteLine($"Country  {cust.Country}");
                newChanges.Country = Console.ReadLine();
                if (newChanges.Country != null) { cust.Country = newChanges.Country; }

                Console.WriteLine($"PostalCode  {cust.PostalCode}");
                newChanges.PostalCode = Console.ReadLine();
                if (newChanges.PostalCode != null) { cust.PostalCode = newChanges.PostalCode; }

                Console.WriteLine($"Phone  {cust.Phone}");
                newChanges.Phone = Console.ReadLine();
                if (newChanges.Phone != null) { cust.Phone = newChanges.Phone; }

                Console.WriteLine($"Fax  {cust.Fax}");
                newChanges.Fax = Console.ReadLine();
                if (newChanges.Fax != null) { cust.Fax = newChanges.Fax; }

                Console.WriteLine($"Email  {cust.Email}");
                newChanges.Email = Console.ReadLine();
                if (newChanges.Email != null) { cust.Email = newChanges.Email; }
                context.SaveChanges();
            }
        }
        public void UpdateTrackData(long trackId)
        {
            using (var context = new ChinookContext())
            {
                Track newData = new Track();
                var trx = context.Tracks.Find(trackId);
                Console.WriteLine($"Dabartinis Statusas yra {trx.Active.ToString().Replace("True", "Active").Replace("False", "Inactive")} ar norite Deaktyvuoti  press - Y /  jei palikte Aktyvuoti press A / q - gryzti atgal ");
                char input = Console.ReadKey().KeyChar;
                if (input == 'q' || input == 'Q') return;
                if (input == 'Y' || input == 'y') { newData.Active = false; }
                else { newData.Active = true; }
                if (newData.Active != null) { trx.Active = newData.Active; }
                context.SaveChanges();
            }
        }

    }
 }

