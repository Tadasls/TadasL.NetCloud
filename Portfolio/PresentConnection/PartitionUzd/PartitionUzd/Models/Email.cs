using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionUzd.Models
{
    public class Email
    {
        [Key]
        public string email { get; set; }
        public bool alternate { get; set; }
    }
}
