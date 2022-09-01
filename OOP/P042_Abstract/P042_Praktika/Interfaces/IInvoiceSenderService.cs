using P043_Uzduotys.Models.Concrete;

namespace P043_Uzduotys.Interfaces
{
    public interface IInvoiceSenderService
    {
        void Send(Invoice invoce);
    }
}