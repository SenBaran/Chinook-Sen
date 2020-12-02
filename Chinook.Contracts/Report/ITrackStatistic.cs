using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Contracts.Model;

namespace Chinook.Contracts.Report
{
    public interface ITrackStatistic
    {
        public ITrack Min { get; }
        public ITrack Max { get; }
        public double Average { get;}
    }
}
