using DBHomeWorkMusicSalesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHomeWorkMusicSalesShop.DTO
{
    public class PerkamaDaina
    {

        public PerkamaDaina()
        {

        }

        public PerkamaDaina(Track trackData)
        {
            TrackId = trackData.TrackId;
            Active = trackData.Active;
            Name = trackData.Name;
            AlbumId = trackData.AlbumId;
            MediaTypeId = trackData.MediaTypeId;
            GenreId = trackData.GenreId;
            Composer = trackData.Composer;
            Milliseconds = trackData.Milliseconds;
            Bytes = trackData.Bytes;
            UnitPrice = trackData.UnitPrice;
            Album = trackData.Album;
            Genre = trackData.Genre;
            MediaType = trackData.MediaType;
            InvoiceItems = trackData.InvoiceItems;
            Playlists = trackData.Playlists;
        }

        public long TrackId { get; set; }
        public bool Active { get; set; } = true;
        public string Name { get; set; } = null!;
        public long? AlbumId { get; set; }
        public long MediaTypeId { get; set; }
        public long? GenreId { get; set; }
        public string? Composer { get; set; }
        public long Milliseconds { get; set; }
        public long? Bytes { get; set; }
        public double? UnitPrice { get; set; } = null!;
        public virtual Album? Album { get; set; }
        public virtual Genre? Genre { get; set; }
        public virtual MediaType MediaType { get; set; } = null!;
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
        public virtual ICollection<Playlist> Playlists { get; set; }



    }
}
