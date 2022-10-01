using Castle.Core.Resource;
using DBHomeWorkMusicSalesShop.DTO;
using DBHomeWorkMusicSalesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

                Console.WriteLine("sarasas Dainu :");
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

      


    }
}
