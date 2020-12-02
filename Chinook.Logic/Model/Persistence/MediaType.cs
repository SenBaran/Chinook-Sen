using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Contracts.Model;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Model.Persistence
{
    [DataClass(FileName = "Csv/MediaType.csv", Separator = ";")]
    internal class MediaType : ModelObject, IMediaType
    {
        [DataPropertyInfo(IsRequired = true, OrderPosition = 1)]
        public string Name { get; set; }
    }
}
