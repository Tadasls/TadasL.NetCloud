﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P055_BatuParduotuve.Database.Models
{
    public class Batas
    {
        [Key]
        public int BatasId { get; set; }

        [Required]
        public string Pavadinimas { get; set; }

        [Required]
        public string Tipas { get; set; }

        public decimal Kaina { get; set; }

        public virtual ICollection<BatuDydis> Dydziai { get; set; } = new HashSet<BatuDydis>();

    }
}