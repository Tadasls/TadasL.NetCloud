using P043_Uzduotys.Interfaces;
using P043_Uzduotys.Models.Concrete;

namespace P043_Uzduotys.Services
{
    public class InvoiceSenderPost : IInvoiceSenderService
    {
        public void Send(Invoice invoice)
        {
            Console.WriteLine("sending POST");
        }
    }
}