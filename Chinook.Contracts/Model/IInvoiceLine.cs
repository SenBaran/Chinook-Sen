using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Model
{
    public interface IInvoiceLine : IIdentifiable
    {
        public int InvoiceId { get; set; }
        public IInvoice Invoice { get; set; }
        public int Quantity { get; set; }
        public int TrackId { get; set; }
        public double UnitPrice { get; set; }
    }
}
