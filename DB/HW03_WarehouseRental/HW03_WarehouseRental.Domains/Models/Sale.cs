using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_WarehouseRental.Domains.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public double Price { get; set; }
        public DateTime CreationDate { get; set; }

        //(MtM)
        public virtual IList<Customer> Customer { get; set; }
        public virtual IList<SalesPerson> SalesPerson { get; set; }


        [NotMapped]
        public double RevenuePerRentedSquare { get; set; }
        public double AverageWarehouseRevenuePerCustomer { get; set; }
        


    }
}
