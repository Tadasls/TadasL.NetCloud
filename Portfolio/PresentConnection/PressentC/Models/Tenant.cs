using System.ComponentModel.DataAnnotations.Schema;

namespace PressentConnection
{
    public partial class Program
    {
        public class Tenant
        {
            public string tenant { get; set; }
            public string userPrincipalName { get; set; }
            public string objectId { get; set; }
            //[NotMapped]
            virtual public List<Email> emails { get; set; } = new List<Email>();
            public bool deleted { get; set; }

            virtual public Root Root { get; set; }
        }

















    }
}