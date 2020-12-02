using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Model
{
    public interface ITrack : IIdentifiable
    {
        public int AlbumId { get; set; }
        public int Bytes { get; set; }
        public string Composer { get; set; }
        public int GenreId { get; set; }
        public int MediaTypeId { get; set; }
        public int Milliseconds { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
    }
}
