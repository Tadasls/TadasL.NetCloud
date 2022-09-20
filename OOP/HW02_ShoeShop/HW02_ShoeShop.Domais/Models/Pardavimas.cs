using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P055_BatuParduotuve.Database.Models
{
    public class Pardavimas
    {
        [Key]
        public int PardavimasId { get; set; }
        public int BatuDydisId { get; set; }
        public int Kiekis { get; set; }
        public virtual BatuDydis BatuDydis { get; set; }

        [NotMapped]
        public virtual decimal Isleista => BatuDydis.Batas.Kaina * Kiekis;

    }
}