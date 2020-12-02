using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Model
{
    public interface IEmployee : IIdentifiable
    {
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string ReportsTo { get; set; }
        public string State { get; set; }
        public string Supervisor { get; set; }
        public string Title { get; set; }
    }
}
