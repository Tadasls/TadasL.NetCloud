using Microsoft.EntityFrameworkCore;
using P055_Skaffold.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public IEnumerable<dynamic> GetCustomer2(string country)
        {
            using (var context = new ChinookContext())
            {
                var customersListByCountry = context.Customers.Where(x => x.Country == country)
                    .Select(c => new
                    {
                        Vardas = c.FirstName,
                        KlientoId = c.CustomerId,
                        SaliesPavadinimas = c.Country,
                    });
                Console.WriteLine("2 uzd:");
                foreach (var customer in customersListByCountry)
                {
                    Console.WriteLine($" {customer.KlientoId}, {customer.Vardas}, {customer.SaliesPavadinimas}");
                }
                return customersListByCountry.ToList();
            }
        }
        // 3. Prašykite metodą, kuris pagal pateiktą kliento 'Country' grąžintų visus 'invoice' iš tos šalies (kliento pilnas vardas, sąskaitos id, sąskaitos data, sąskaitos šalis)
        public IEnumerable<dynamic> GetInvoices3(string country)
        {
            using (var context = new ChinookContext())
            {
                var customerSarasas = context.Customers
                    .Select(x => x);
                    var invoisuSarasas = context.Invoices.Where(y => y.BillingCountry == country)
                    .Join(
                         customerSarasas,
                    i => i.CustomerId,
                    c => c.CustomerId,
                    (i, c) => new { c.FirstName, c.LastName, i.InvoiceId, i.InvoiceDate, i.BillingCountry });

                Console.WriteLine("3uzd:");
                foreach (var invoice in invoisuSarasas)
                {
                    Console.WriteLine($" {invoice.FirstName}, {invoice.LastName}, {invoice.InvoiceDate}, {invoice.BillingCountry}");
                }
                return invoisuSarasas.ToList();
            }
        }
        // 4. Prašykite metodą, kuris darbuotojus 'employees' grąžina sugrupuotus paga pavadinimą 'Title'
        public IEnumerable<dynamic> GetEmployeesByTitle4()
        {
            using (var context = new ChinookContext())
            {
                var emplByTileGroups = context.Employees.GroupBy(t => t.Title)
                    .Select(e => new 
                    {
                        TitleGroup = e.Key,
                        EmployeeName = e.Select(x => x.FirstName + x.LastName).ToArray(),
                    });
                Console.WriteLine("4 uzd:");
                foreach (var group in emplByTileGroups)
                {
                    Console.WriteLine(group.TitleGroup);
                    foreach (var employee in group.EmployeeName)
                    {
                        Console.WriteLine($"   {employee}");
                    }
                }
                return emplByTileGroups.ToList();
            }
        }
        // 5. Prašykite metodą, kuris grąžina tik unikalius šalių pavadinimus iš 'customers' lentelės
        public IEnumerable<dynamic> GetUniqueCountryListFromCustomers5()
        {
            using (var context = new ChinookContext())
            {
                var uniqCountryList = context.Customers
                    .Select(c => new
                {
                    SaliesPavadinimas = c.Country.ToArray(),
                }).Distinct();
                Console.WriteLine("5 uzd:");
                foreach (var country in uniqCountryList)
                {
                Console.WriteLine(country.SaliesPavadinimas);
                }
                return uniqCountryList.ToList();
            }
        }
        // 6. Prašykite metodą, kuris grąžina tik tas sąskaitas už kurias atsakingi 'Sales Support Agent'.(darbuotojo pilnas vardas, sąskaitos id, sąskaitos data, sąskaitos šalis, suma)
        public IEnumerable<dynamic> GetInvoicesResponsibleBySalesAgents6()
        {
            using (var context = new ChinookContext())
            {
                var emplList = context.Employees
                   .Where(x => x.Title == "Sales Support Agent");
                var invoisuSarasasSpecAgento = context.Invoices
                .Join(
                     emplList,
                i => i.CustomerId,
                e => e.EmployeeId,
                (i, e) => new { e.FirstName, e.LastName, i.InvoiceId, i.InvoiceDate, i.BillingCountry, i.Total });

                Console.WriteLine("6uzd:");
                foreach (var invoice in invoisuSarasasSpecAgento)
                {
                    Console.WriteLine($" {invoice.FirstName}, {invoice.LastName}, {invoice.InvoiceId}, {invoice.InvoiceDate}, {invoice.BillingCountry}, {invoice.Total}");
                }
                return invoisuSarasasSpecAgento.ToList();
            }



        }
        //7. Prašykite metodą, kuris grąžina kiek sąskaitų buvo išrašyta už metus
        public IEnumerable<dynamic> Metodas7()
        {
            using (var context = new ChinookContext())
            {
                var kazkas = context.Customers;

                return kazkas.ToList();
            }
           
        }


        //  8. Prašykite metodą, kuris grąžina kiek prekių(invoice_items) buvo parduota su kiekviena sąskaita 
        public IEnumerable<dynamic> Metodas8()
        {
            using (var context = new ChinookContext())
            {
                var kazkas = context.Customers;

                return kazkas.ToList();
            }

        }
        //  9. Prašykite metodą, kuris grąžina kiek kiekvienoje kliento valstybėje buvo išrašyta sąskaitų 
        public IEnumerable<dynamic> Metodas9()
        {
            using (var context = new ChinookContext())
            {
                var kazkas = context.Customers;

                return kazkas.ToList();
            }

        }
        //  10. Prašykite metodą, kuris grąžina kiek prekių(invoice_items) buvo parduota su kiekvienoje kliento valstybėje 
        public IEnumerable<dynamic> Metodas10()
        {
            using (var context = new ChinookContext())
            {
                var kazkas = context.Customers;

                return kazkas.ToList();
            }

        }
        //  11. Prašykite metodą, kuris grąžina nupirko(invoice_items) 'track' pavadinimą ir 'artist' vardą
        public IEnumerable<dynamic> Metodas11()
        {
            using (var context = new ChinookContext())
            {
                var kazkas = context.Customers;

                return kazkas.ToList();
            }

        }
        //  12. Prašykite metodą, kuris grąžina kiek 'tracks' yra kiekviename 'playlist' (playlist pavadinimas, kiekis)
        public IEnumerable<dynamic> Metodas12()
        {
            using (var context = new ChinookContext())
            {
                var kazkas = context.Customers;

                return kazkas.ToList();
            }

        }
        //  13. Prašykite metodą, kuris grąžina kurie metai buvo patys pelningiausi
        public IEnumerable<dynamic> Metodas13()
        {
            using (var context = new ChinookContext())
            {
                var kazkas = context.Customers;

                return kazkas.ToList();
            }

        }
        //  14. Prašykite metodą, kuris grąžina top 5 parduodamus 'tracks'
        public IEnumerable<dynamic> Metodas14()
        {
            using (var context = new ChinookContext())
            {
                var kazkas = context.Customers;

                return kazkas.ToList();
            }

        }
        //  15. Prašykite metodą, kuris grąžina top 3 parduodamus 'artists'
        public IEnumerable<dynamic> Metodas15()
        {
            using (var context = new ChinookContext())
            {
                var kazkas = context.Customers;

                return kazkas.ToList();
            }

        }
        //  16. Prašykite metodą, kuris grąžina top 2 parduodamus 'genres'
        public IEnumerable<dynamic> Metodas16()
        {
            using (var context = new ChinookContext())
            {
                var kazkas = context.Customers;

                return kazkas.ToList();
            }

        }
        //  17. Prašykite metodą, kuris grąžina top 1 parduodamą 'media_types'
        public IEnumerable<dynamic> Metodas17()
        {
            using (var context = new ChinookContext())
            {
                var kazkas = context.Customers;

                return kazkas.ToList();
            }

        }
        //  18. Prašykite metodą, kuris grąžina kiekvienoje šalyje yra klientų
        public IEnumerable<dynamic> Metodas18()
        {
            using (var context = new ChinookContext())
            {
                var kazkas = context.Customers;

                return kazkas.ToList();
            }

        }



    }
}
