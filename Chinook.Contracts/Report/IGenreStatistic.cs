using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Report
{
    public interface IGenreStatistic
    {
        public string MaxSoldGenreName { get;}
        public int MaxSoldGenreCount { get;}
        public string MinSoldGenreName { get; }
        public int MinSoldGenreCount { get; }
    }
}
