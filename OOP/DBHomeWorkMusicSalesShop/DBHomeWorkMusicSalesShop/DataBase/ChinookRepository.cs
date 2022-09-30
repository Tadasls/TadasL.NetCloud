using DBHomeWorkMusicSalesShop.DTO;
using DBHomeWorkMusicSalesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    .Where(y => y.Active == !true)
                    .OrderBy(x => x)  // refactor needs override on model creating
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
                // refactor needs override on model creating
                var dainusarasas = context.Tracks
                    .Where(y => y.Active == !true)
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
                    .Select(c => new TrackDTO
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
                    .Select(c => new TrackDTO
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



    }
}
