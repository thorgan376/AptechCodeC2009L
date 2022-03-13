using EAP_Music_NguyenVanANew.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EAP_Music_NguyenVanANew
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        public override void InitializeDatabase(DataContext context)
        {
            base.InitializeDatabase(context);
        }

        protected override void Seed(DataContext context)
        {
            base.Seed(context);
            context.Genres.Add(new Genre()
            {
                GenreId = 1,
                GenreName = "Action",
            });
            context.Genres.Add(new Genre()
            {
                GenreId = 1,
                GenreName = "Adventure",
            });
            context.Genres.Add(new Genre()
            {
                GenreId = 1,
                GenreName = "Comedy",
            });
            context.Genres.Add(new Genre()
            {
                GenreId = 1,
                GenreName = "Historical",
            });
            context.Albums.Add(new Album()
            {
                AlbumId = 1,
                Title = "albuml 111",
                ReleaseDate = new DateTime(2008, 11, 20),
                Artist = "Artist 11",
                Price = 111.1,
                GenreId = 1,
            });
            context.Albums.Add(new Album()
            {
                AlbumId = 1,
                Title = "albuml 111",
                ReleaseDate = new DateTime(2008, 11, 20),
                Artist = "Artist 11",
                Price = 111.1,
                GenreId = 1,
            });
            context.Albums.Add(new Album()
            {
                AlbumId = 1,
                Title = "albuml 2222",
                ReleaseDate = new DateTime(2008, 11, 20),
                Artist = "Artist 22",
                Price = 222.1,
                GenreId = 1,
            });
            context.Albums.Add(new Album()
            {
                AlbumId = 1,
                Title = "albuml 333",
                ReleaseDate = new DateTime(2008, 11, 20),
                Artist = "Artist 333",
                Price = 33.1,
                GenreId = 2,
            });

        }
    }
}