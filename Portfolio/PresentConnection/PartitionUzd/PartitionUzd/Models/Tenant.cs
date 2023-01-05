using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionUzd.Models
{
    public class Tenant
    {
        [Key]
        public string tenant { get; set; }
        public string userPrincipalName { get; set; }
        public string objectId { get; set; }
        public bool deleted { get; set; }
        public virtual ICollection<Email> emails{ get; set; }
    }
}
