using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Contracts.Model;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Model.Persistence
{
    [DataClass(FileName = "Csv/Invoice.csv", Separator = ";")]
    internal class Invoice : ModelObject, IInvoice
    {
        [DataPropertyInfo(IsRequired = true, OrderPosition = 3)]
        public string BillingAddress { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 4)]
        public string BillingCity { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 6)]
        public string BillingCountry { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 7)]
        public string BillingPostalCode { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 5)]
        public string BillingState { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 1)]
        public int CustomerId { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 2)]
        public DateTime InvoiceDate { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 8)]
        public double Total { get; set; }
    }
}
