using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Contracts.Model;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Model.Persistence
{
    [DataClass(FileName = "Csv/Artist.csv", Separator = ";")]
    internal class Artist : ModelObject, IArtist
    {
        [DataPropertyInfo(IsRequired = true, OrderPosition = 1)]
        public string Name { get; set; }
    }
}
