using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Model
{
    public interface IAlbum : IIdentifiable
    {
        public int ArtistId { get; set; }
        public IArtist Artist { get; set; }
        public string Title { get; set; }
    }
}
