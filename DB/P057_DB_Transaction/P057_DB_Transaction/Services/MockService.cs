using P057_DB_TransactionChangeTracking.Dto;
using P057_DB_TransactionChangeTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P057_DB_TransactionChangeTracking.Services
{
    public class MockService
    {
        public void DisplayAllSongs()
        {
            var songs = new List<Song>();

            var songDto = songs.Select(s => new SongMockDto // Projekcija
            {
                Id = s.Id,
                Title = s.Title
            });
        }
    }
}