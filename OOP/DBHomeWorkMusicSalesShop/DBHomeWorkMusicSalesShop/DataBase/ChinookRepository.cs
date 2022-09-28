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
        public IEnumerable<dynamic> GetTracks()
        {
            using (var context = new ChinookContext())
            {

              

                var dainusarasas = context.Tracks
                    .Select(c => new
                    {
                        Vardas = c.Name,
                        Kompozitorius = c.Composer,
                        Zanras = c.Genre,
                        Albumas = c.Album,
                        Trukme = c.Milliseconds,
                        Kaina = c.UnitPrice,
                       
                       
                    });
                Console.WriteLine("sarasas:");
                foreach (var track in dainusarasas)
                {
                    Console.WriteLine($" {track.Vardas}, {track.Kompozitorius}, {track.Zanras}, {track.Albumas}, {track.Trukme}, {track.Kaina}");
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
                    .Select(c => new
                    {
                        Vardas = c.Name,
                        Kompozitorius = c.Composer,
                        Zanras = c.Genre,
                        Albumas = c.Album,
                        Trukme = c.Milliseconds,
                        Kaina = c.UnitPrice,


                    });
                Console.WriteLine("sarasas:");
                foreach (var track in dainusarasas)
                {
                    Console.WriteLine($" {track.Vardas}, {track.Kompozitorius}, {track.Zanras}, {track.Albumas}, {track.Trukme}, {track.Kaina}");
                }
                return dainusarasas.ToList();
            }
        }





    }
}
