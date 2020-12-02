using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Model
{
    public interface IPlaylist : IIdentifiable
    {
        public string Name { get; set; }
    }
}
