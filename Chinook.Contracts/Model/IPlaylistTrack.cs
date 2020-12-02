using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Model
{
    public interface IPlaylistTrack
    {
        public int TrackId { get; set; }
        public int PlaylistId { get; set; }
        public IPlaylist Playlist { get; set; }

    }
}
