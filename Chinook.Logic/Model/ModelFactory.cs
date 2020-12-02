using System;
using System.Collections.Generic;
using Chinook.Contracts.Model;
using Chinook.Logic.Model.Persistence;


namespace Chinook.Logic.Model
{
    public class ModelFactory
    {
        public static IAlbum CreateAlbum()
        {
            return new Album();
        }

        public static IArtist CreateArtist()
        {
            return new Artist();
        }

        public static ICostumer CreateCostumer()
        {
            return new Customer();
        }

        public static IEmployee CreateEmployee()
        {
            return new Employee();
        }

        public static IGenre CreateGenre()
        {
            return new Genre();
        }

        public static IInvoice CreateInvoice()
        {
            return new Invoice();
        }

        public static IInvoiceLine CreateInvoiceLine()
        {
            return new InvoiceLine();
        }

        public static IMediaType CreateMediaType()
        {
            return new MediaType();
        }

        public static IPlaylist CreatePlaylist()
        {
            return new Playlist();
        }

        public static IPlaylistTrack CreatePlaylistTrack()
        {
            return new PlaylistTrack();
        }

        public static ITrack CreateTrack()
        {
            return new Track();
        }
    }
}
