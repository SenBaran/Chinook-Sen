using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Model
{
    public interface IInvoice : IIdentifiable
    {
        public string BillingCity { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingState { get; set; }
        public int CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double Total { get; set; }

    }
}
