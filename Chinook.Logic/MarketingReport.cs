using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Contracts.Report;
using Chinook.Contracts.Model;
using Chinook.Logic.Model.Persistence;
using Chinook.Logic.Marketing.Report;
using System.Linq;

namespace Chinook.Logic
{
    public class MarketingReport
    {
        public ITrackStatistic GetTrackStatistic()
        {
            TrackStatistic trackStatistic = new TrackStatistic();
            var tracks = CsvMapper.Logic.CsvHelper.Read<Track>();

            trackStatistic.Min = tracks.OrderBy(e => e.Milliseconds).FirstOrDefault();
            trackStatistic.Max = tracks.OrderBy(e => e.Milliseconds).LastOrDefault();
            trackStatistic.Average = tracks.Select(e => e.Milliseconds).Average();

            return trackStatistic;
        }

        public IAlbumStatistic GetAlbumStatistic()
        {
            var tracks = CsvMapper.Logic.CsvHelper.Read<Track>();
            var albums = CsvMapper.Logic.CsvHelper.Read<Album>();
            
            return default(IAlbumStatistic);
        }
    }
}
