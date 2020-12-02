using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Logic.Model.Persistence;
using Chinook.Contracts.Model;
using System.Linq;

namespace Chinook.Logic
{
    public class Analysis
    {
        private static IEnumerable<Album> albums;
        private static IEnumerable<Artist> artists;
        private static IEnumerable<Customer> customers;
        private static IEnumerable<Employee> employees;
        private static IEnumerable<Genre> genres;
        private static IEnumerable<Invoice> invoices;
        private static IEnumerable<InvoiceLine> invoiceLines;
        private static IEnumerable<MediaType> mediaTypes;
        private static IEnumerable<Playlist> playlists;
        private static IEnumerable<PlaylistTrack> playlistTracks;
        private static IEnumerable<Track> tracks;

        private static Analysis instance;

        private Analysis()
        {
            albums = CsvMapper.Logic.CsvHelper.Read<Album>();
            artists = CsvMapper.Logic.CsvHelper.Read<Artist>();
            customers = CsvMapper.Logic.CsvHelper.Read<Customer>();
            employees = CsvMapper.Logic.CsvHelper.Read<Employee>();
            genres = CsvMapper.Logic.CsvHelper.Read<Genre>();
            invoices = CsvMapper.Logic.CsvHelper.Read<Invoice>();
            invoiceLines = CsvMapper.Logic.CsvHelper.Read<InvoiceLine>();
            mediaTypes = CsvMapper.Logic.CsvHelper.Read<MediaType>();
            playlists = CsvMapper.Logic.CsvHelper.Read<Playlist>();
            playlistTracks = CsvMapper.Logic.CsvHelper.Read<PlaylistTrack>();
            tracks = CsvMapper.Logic.CsvHelper.Read<Track>();
        }

        public static Analysis Instance {
            get 
            {
                if (instance == null) instance = new Analysis();
                return instance;
            }
        }

        public ITrack GetMinTrack()
        {
            return tracks.OrderBy(e => e.Milliseconds).FirstOrDefault();
        }
        public ITrack GetMaxTrack()
        {
            return tracks.OrderBy(e => e.Milliseconds).LastOrDefault();
        }
        public double GetAverageTrack()
        {
            return tracks.Select(e => e.Milliseconds).Average();
        }
        public void GetMinAlbum()
        {
            var alb = from al in albums
                      join tr in tracks on al.Id equals tr.AlbumId into tr
                      select tr;
            
            alb.ToList().ForEach(e => e.ToList().ForEach(a => a))
        }
    }
}
