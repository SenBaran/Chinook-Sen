using System;
using System.Collections.Generic;
using Chinook.Contracts.Model;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Model.Persistence
{
    internal class ModelObject : IIdentifiable
    {
        [DataPropertyInfo(IsRequired = true, OrderPosition = 0)]
        public int Id { get; set; }
    }
}
