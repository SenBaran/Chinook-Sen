using System;
using System.Collections.Generic;
using Chinook.Contracts.Model;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Model.Persistence
{
    [DataClass(FileName = "Csv/Playlist.csv", Separator = ";")]
    internal class Playlist : ModelObject, IPlaylist
    {
        [DataPropertyInfo(IsRequired = true, OrderPosition = 1)]
        public string Name { get; set; }
    }
}
