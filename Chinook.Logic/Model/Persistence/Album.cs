using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Contracts.Model;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Model.Persistence
{
    [DataClass(FileName = "Csv/Album.csv", Separator = ";")]
    internal class Album : ModelObject, IAlbum
    {
        [DataPropertyInfo(IsRequired = true, OrderPosition = 2)]
        public int ArtistId { get; set; }
        [DataPropertyInfo(OrderPosition = -1)]
        public IArtist Artist { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 1)]
        public string Title { get; set; }
    }
}
