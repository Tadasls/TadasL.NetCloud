using P043_Uzduotys.Interfaces;
using P043_Uzduotys.Models.Concrete;

namespace P043_Uzduotys.Services
{
    public class InvoiceSenderEmail : IInvoiceSenderService
    {
        public void Send(Invoice invoce)
        {
            Console.WriteLine("sending EMAIL");
        }
    }
}