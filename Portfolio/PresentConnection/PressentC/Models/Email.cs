using System.ComponentModel.DataAnnotations.Schema;

namespace PressentConnection
{
    public partial class Program
    {
       
        public class Email
        {
            public string email { get; set; }
            public bool alternative { get; set; }
            virtual public Tenant tenant { get; set; }

        }

















    }
}