namespace PresentC2invoice.Models
{
    public interface ICustomer
    {
        bool IsVATPayer { get; }
        string Country { get; }
    }



}
