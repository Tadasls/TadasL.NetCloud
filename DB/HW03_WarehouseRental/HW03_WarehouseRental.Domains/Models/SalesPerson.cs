using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HW03_WarehouseRental.Domains.Models
{
    public class SalesPerson
    {
        [Key]
        public int SalesPersonId { get; set; }
        
        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        [MaxLength(75)]
        [Required]
        public string SalesRegion { get; set; }

        public virtual IList<Sale> Sale { get; set; }

    }
}