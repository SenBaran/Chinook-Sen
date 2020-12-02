using Chinook.Contracts.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Logic.Marketing.Report
{
    internal class TrackStatistic : Contracts.Report.ITrackStatistic
    {
        public double Average { get; set; }

        public ITrack Min { get; set; }

        public ITrack Max { get; set; }
    }
}
