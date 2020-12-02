using System;
using System.Collections.Generic;
using Chinook.Contracts.Model;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Model.Persistence
{
    [DataClass(FileName = "Csv/Album.csv", Separator = ";")]
    internal class PlaylistTrack : IPlaylistTrack
    {
        [DataPropertyInfo(IsRequired = true, OrderPosition = 2)]
        public int TrackId { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 1)]
        public int PlaylistId { get; set; }
        [DataPropertyInfo(OrderPosition = -1)]
        public IPlaylist Playlist { get; set; }
    }
}
