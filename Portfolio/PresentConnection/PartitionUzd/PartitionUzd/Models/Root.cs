using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionUzd.Models
{
    public class Root
    {
        [Key]
        public string id { get; set; }

        public string partitionKey { get; set; }

        public virtual ICollection<Tenant> tenants{ get; set; }
    }
}
