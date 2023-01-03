namespace PresentC2invoice.Models
{
    public class Company : ICompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Industry { get; set; }
        public string HeadquarterAddress { get; set; }
        public string Country { get; set; }
        public bool IsVATPayer { get; set; }
        // http://ec.europa.eu/taxation_customs/vies/checkVatTestService.wsdl

        public Company()
        {

        }

        public Company(int id, string name, string industry, string headquarterAddress, string country, bool isVATPayer)
        {
            Id = id;
            Name = name;
            Industry = industry;
            HeadquarterAddress = headquarterAddress;
            Country = country;
            IsVATPayer = isVATPayer;
        }
    }


}
