using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHomeWorkMusicSalesShop.DTO
{
    public class TrackDTO
    {
        public TrackDTO()
        {

        }

       

        public TrackDTO(long irasoId, string vardas, string kompozitorius, string zanras, string albumas, long trukme, double? kaina)
        {
            IrasoId = irasoId;
            Vardas = vardas;
            Kompozitorius = kompozitorius;
            Zanras = zanras;
            Albumas = albumas;
            Trukme = trukme;
            Kaina = kaina;
        }

        public long IrasoId { get; set; }
        public string Vardas { get; set; }
        public string Kompozitorius { get; set; }
        public string Zanras { get; set; }
        public string Albumas { get; set; }
        public long Trukme { get; set; }
        public double? Kaina { get; set; }
       


     


    }
}
