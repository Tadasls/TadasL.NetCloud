using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_ShoeShop.Domais.Models
{
    [Table("Dydziai")]
    public class ShoeSize
    {
        public int Size { get; set; }
        public int Quatity { get; set; }


    }
}
