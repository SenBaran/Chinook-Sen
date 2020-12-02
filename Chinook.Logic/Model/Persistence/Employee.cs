using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Contracts.Model;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Model.Persistence
{
    [DataClass(FileName = "Csv/Employee.csv", Separator = ";")]
    internal class Employee : ModelObject, IEmployee
    {
        [DataPropertyInfo(IsRequired = true, OrderPosition = 7)]
        public string Address { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 5)]
        public DateTime BirthDate { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 8)]
        public string City { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 10)]
        public string Country { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 14)]
        public string Email { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 13)]
        public string Fax { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 2)]
        public string FirstName { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 6)]
        public DateTime HireDate { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 1)]
        public string LastName { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 12)]
        public string Phone { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 11)]
        public string PostalCode { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 4)]
        public string ReportsTo { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 9)]
        public string State { get; set; }
        [DataPropertyInfo(OrderPosition = -1)]
        public string Supervisor { get; set; }
        [DataPropertyInfo(IsRequired = true, OrderPosition = 3)]
        public string Title { get; set; }
    }
}
