using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionUzd.Models
{
    public class Project
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string partitionKey { get; set; } = null!;
    }
}
