namespace PresentC2invoice.Models
{
    public interface ICompany
    {
        bool IsVATPayer { get; }
        string Country { get; }
    }


}
