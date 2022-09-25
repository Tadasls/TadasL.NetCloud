using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_WarehouseRental.Domains.Models
{
    public class Warehouse
    {
                
           

        [Key]
        public int WareHouseId { get; set; }


        [MaxLength(50)]
        [Required]
        public string Location { get; set; }


        [MaxLength(150)]
        [Required]
        public string ProductionType { get; set; }
        public int CurrentInventoryCapacity { get; set; }
        public int MaxInventoryCapacity { get; set; }



        [NotMapped]
        public int AvailableInventoryCapacity { get; set; } // = MaxInventoryCapacity - CurrentInventoryCapacity

        public virtual List<Customer> Customers { get; set; }








    }
}
