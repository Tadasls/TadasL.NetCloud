using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_WarehouseRental.Domains.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        
        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        public string InventorySize { get; set; }
       
        
        public virtual Warehouse Warehouse { get; set; }
        public virtual IList<Sale> Sales { get; set; }


    }
}
