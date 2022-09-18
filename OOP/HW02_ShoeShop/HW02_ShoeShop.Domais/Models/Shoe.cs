using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_ShoeShop.Domais.Models
{
    [Table("Batai")]
    public class Shoe
    {
        [Key]
        public int ShoesId { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [MaxLength(10)]
        [Required]
        public double Price { get; set; }




    }
}
