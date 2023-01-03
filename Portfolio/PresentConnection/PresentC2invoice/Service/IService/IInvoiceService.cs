using PresentC2invoice.Models;

namespace PresentC2invoice.Service.IService
{
    public interface IInvoiceService
    {
       
        decimal CalculateVAT(ICustomer customer, ICompany serviceProvider, decimal orderAmount);
        decimal CalculateVATForCountry(string country, decimal orderAmount);
      

    }
}