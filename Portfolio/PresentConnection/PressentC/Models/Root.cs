namespace PressentConnection
{
    public partial class Program
    {
        public class Root
        {
            //200k User entries
            public string id { get; set; }
            public string partitionKey { get; set; }
            virtual public List<Tenant> tenants { get; set; } = new List<Tenant>();
        }

















    }
}