using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Model
{
    public interface IIdentifiable
    {
        public int Id { get; set; }
    }
}
