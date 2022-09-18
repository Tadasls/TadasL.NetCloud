using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HW02_ShoeShop.Domais.Models
{
    public class Sale
    {
       
        public int SalesID { get; set; }
                     
        public int Pair { get; set; }

        [NotMapped]
        [Required, MaxLength(100)]
        public double PurchaseTotal { get; set; }


        public int ShoesId { get; set; }
        public virtual IList<Shoe> Shoes { get; set; }

    }
}
