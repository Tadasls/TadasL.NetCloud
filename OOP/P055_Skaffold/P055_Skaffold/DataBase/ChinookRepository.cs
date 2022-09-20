using Microsoft.EntityFrameworkCore;
using P055_Skaffold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P055_Skaffold.DataBase
{
    public class ChinookRepository
    {

        
        private readonly ChinookContext _context;

        public ChinookRepository(ChinookContext context)
        {
            _context = context;
        }

       
      // 2. Prašykite metodą, kuris pagal pateiktą 'Country' grąžintų visus 'customers' iš tos šalies (vardą, kliento id ir šalies pavadinimą)

        public IEnumerable<dynamic> GetCustomer(string country)
        {
            using (var ctx = new ChinookContext())
            {
                var res = ctx.Customers.Where(x => x.Country == country)
                    .Select(c => new
                {
                    Vardas = c.FirstName,
                    KlientoId = c.CustomerId,
                    SaliesPavadinimas = c.Country,
                });
                return res;
            }

        }




        // 3. Prašykite metodą, kuris pagal pateiktą kliento 'Country' grąžintų visus 'invoice' iš tos šalies
        // (kliento pilnas vardas, sąskaitos id, sąskaitos data, sąskaitos šalis)

        public List<Invoice> GetInvoices(string country)
        {
            using (var context = new ChinookContext())
            {
                var invoisuSarasas = context.Invoices.Include(x=> x.Customer.Country == country);
                return invoisuSarasas.ToList();
            }

        }








    }
}
