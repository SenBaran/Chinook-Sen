using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Contracts.Report;

namespace Chinook.Logic.Marketing.Report
{
    internal class GenreStatistic : IGenreStatistic
    {
        public string MaxSoldGenreName { get; set; }

        public int MaxSoldGenreCount { get; set; }

        public string MinSoldGenreName { get; set; }

        public int MinSoldGenreCount { get; set; }
    }
}
