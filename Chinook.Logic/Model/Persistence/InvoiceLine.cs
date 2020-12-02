using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Contracts.Model;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Model.Persistence
{
    [DataClass(FileName = "Csv/InvoiceLine.csv", Separator = ";")]
    internal class InvoiceLine : ModelObject, IInvoiceLine
    {
        [DataPropertyInfo(IsRequired = true, OrderPosition = 1)]
        public int InvoiceId { get; set; }
        [DataPropertyInfo(OrderPosition = -1)]
        public IInvoice Invoice { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 4)]
        public int Quantity { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 2)]
        public int TrackId { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 3)]
        public double UnitPrice { get; set; }
    }
}
