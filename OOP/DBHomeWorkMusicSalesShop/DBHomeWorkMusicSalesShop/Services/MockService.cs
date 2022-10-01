using DBHomeWorkMusicSalesShop.DTO;
using DBHomeWorkMusicSalesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHomeWorkMusicSalesShop.Services
{
    public class MockService
    {
        public void DisplayAllSongs()
        {
            var tracks = new List<Track>();

            var songDto = tracks.Select(s => new TrackDTO
            {
                IrasoId = s.TrackId,
                Vardas = s.Name
            });
        }
    }
}
