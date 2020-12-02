using System;
using System.Collections.Generic;
using Chinook.Contracts.Model;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Model.Persistence
{
    [DataClass(FileName = "Csv/Track.csv", Separator = ";")]
    internal class Track : ModelObject, ITrack
    {
        [DataPropertyInfo(IsRequired = true, OrderPosition = 2)]
        public int AlbumId { get; set; }
        [DataPropertyInfo(OrderPosition = -1)]
        public Album Album { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 7)]
        public int Bytes { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 5)]
        public string Composer { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 4)]
        public int GenreId { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 3)]
        public int MediaTypeId { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 6)]
        public int Milliseconds { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 1)]
        public string Name { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 8)]
        public double UnitPrice { get; set; }
    }
}
