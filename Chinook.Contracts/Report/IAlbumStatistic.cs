using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Report
{
    public interface IAlbumStatistic
    {
        public int MinTime { get;}
        public string MinTimeName { get; }
        public int MaxTime { get; }
        public string MaxTimeName { get; }
        public double Average { get;}
    }
}
