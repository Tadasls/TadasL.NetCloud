using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentC2invoice.Data;
using PresentC2invoice.Models;
using PresentC2invoice.Service.IService;
using PressentConnection.Data;

namespace PresentC2invoice.Service
{

    public class InvoiceService : IInvoiceService
    {

        private readonly DataBaseContext _db;
        public InvoiceService(DataBaseContext db)
        {
            _db = db;
        }

        private readonly ICustomer _customer;
        private readonly ICompany _serviceProvider;

        public InvoiceService(ICustomer customer, ICompany serviceProvider)
        {
            _customer = customer;
            _serviceProvider = serviceProvider;
        }

        public decimal CalculateVAT(ICustomer customer, ICompany serviceProvider, decimal orderAmount)
        {
            bool arEuCountry = IsCountryInEU(customer.Country);

            if (!serviceProvider.IsVATPayer || (serviceProvider.IsVATPayer && !arEuCountry) || (serviceProvider.IsVATPayer && arEuCountry && customer.IsVATPayer))
            {
                return 0;
            }

            //if (customer.Country == serviceProvider.Country|| (serviceProvider.IsVATPayer && arEuCountry && !customer.IsVATPayer))
            //{
            //    return CalculateVATForCountry(customer.Country, orderAmount);
            //}

            return CalculateVATForCountry(customer.Country, orderAmount);
        }

        public decimal CalculateVATForCountry(string country, decimal orderAmount)
        {
            if (country == "Lithuania") return orderAmount * 0.21m;
            return orderAmount * 0.15m;
        }

        public bool IsCountryInEU (string country)
        {
            if (CountryList.euCountries.Contains(country)) return true;
            return false;

        }




    }



}
