﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Model
{
    public interface ICostumer : IIdentifiable
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get { return FirstName + " " + LastName; } }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public int SupportRepId { get; set; }

    }
}
