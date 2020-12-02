using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Contracts.Report;

namespace Chinook.Logic.Marketing.Report
{
    internal class AlbumStatistic : IAlbumStatistic
    {
        public int MinTime { get; set; }

        public string MinTimeName { get; set; }

        public int MaxTime { get; set; }

        public string MaxTimeName { get; set; }

        public double Average { get; set; }
    }
}
