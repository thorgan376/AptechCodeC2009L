using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EAP_Music_NguyenVanA.Models
{
    
    public class DataContext:DbContext
    {
        private static readonly String CONNECTION_STRING =
        "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sunli\\Dropbox\\code\\Aptech\\C1908GLeThanhNghi\\EAP\\31-03-2021\\EAP_Music_NguyenVanA\\EAP_Music_NguyenVanA\\App_Data\\DataContext.mdf;Integrated Security = True";
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Album> Albums { get; set; }

        public DataContext():base(CONNECTION_STRING)
        {
            Database.SetInitializer<DataContext>(new DBInitializer(this));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            base.OnModelCreating(modelBuilder);            
        }
    }

    public class DBInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        public DBInitializer(DataContext context)
        {

            this.Seed(context);
        }

        protected override void Seed(DataContext context)
        {
            IList<Genre> genres = new List<Genre>();
            genres.Add(new Genre() { GenreId = 1, GenreName = "Pop" });
            genres.Add(new Genre() { GenreId = 2, GenreName = "Rock" });
            genres.Add(new Genre() { GenreId = 3, GenreName = "Hip Hop" });
            genres.Add(new Genre() { GenreId = 4, GenreName = "Jazz" });
            genres.Add(new Genre() { GenreId = 5, GenreName = "Punk" });
            genres.Add(new Genre() { GenreId = 7, GenreName = "R&B" });
            genres.Add(new Genre() { GenreId = 8, GenreName = "Country" });
            genres.Add(new Genre() { GenreId = 9, GenreName = "Latin" });
            context.Genres.AddRange(genres);
            context.SaveChanges();
            IList<Album> albums = new List<Album>();
                        

            albums.Add(new Album() { AlbumId = 01, Title = "Twenty File", ReleaseDate = new DateTime(2015, 11, 20), Artist = "Adele", GenreId = 1, Price = 9.99});
            albums.Add(new Album() { AlbumId = 02, Title = "Nineteen Eighty-Nine", ReleaseDate = new DateTime(2014, 10, 27), Artist = "Taylor Swift", GenreId = 1, Price = 10.99});
            albums.Add(new Album() { AlbumId = 03, Title = "A million", ReleaseDate = new DateTime(2016, 09, 30), Artist = "Bon Iver", GenreId = 2, Price = 9.99});
            albums.Add(new Album() {  AlbumId = 04, Title = "Meteora", ReleaseDate = new DateTime(2003, 03, 25), Artist = "Linkin Park", GenreId = 2, Price = 7.99});
            albums.Add(new Album() { AlbumId = 05, Title = "Nevermind", ReleaseDate = new DateTime(1991, 09, 24), Artist = "Nivarna", GenreId = 2, Price = 9.99});
            albums.Add(new Album() { AlbumId = 06, Title = "To Pimp a Butterfly", ReleaseDate = new DateTime(2015, 03, 15), Artist = "Kendrick Lamar", GenreId = 3, Price = 8.99});
            albums.Add(new Album() { AlbumId = 07, Title = "The Chronic", ReleaseDate = new DateTime(1992, 12, 15), Artist = "Dr.Dre", GenreId = 3, Price = 9.99});
            albums.Add(new Album() { AlbumId = 08, Title = "Comes Away With Me", ReleaseDate = new DateTime(2002, 02, 26), Artist = "Norah Jones", GenreId = 4, Price = 6.99 });
            albums.Add(new Album() { AlbumId = 09, Title = "Kind of Blues", ReleaseDate = new DateTime(1959, 08, 17), Artist = "Miles Davids", GenreId = 4, Price = 7.99 });
            albums.Add(new Album() { AlbumId = 10, Title = "Dookie", ReleaseDate = new DateTime(1994, 02, 01), Artist = "Green Day", GenreId = 5, Price = 8.99 });
            albums.Add(new Album() { AlbumId = 11, Title = "Relapse", ReleaseDate = new DateTime(2009, 05, 15), Artist = "Eminem", GenreId = 6, Price = 9.99 });
            albums.Add(new Album() { AlbumId = 12, Title = "Get Rich or Die", ReleaseDate = new DateTime(2003, 02, 06), Artist = "Tryin", GenreId = 6, Price = 7.99 });
            albums.Add(new Album() { AlbumId = 13, Title = "Blonde", ReleaseDate = new DateTime(2016, 08, 20), Artist = "Frank Oceans", GenreId = 7, Price = 8.99 });
            albums.Add(new Album() {
                AlbumId = 14, Title = "Love, Marriage & Divorce", ReleaseDate = new DateTime(2014,02,04), Artist = "Babyface & Toni Braxton", GenreId = 7, Price =
                        9.99 });
            albums.Add(new Album() { AlbumId = 15, Title = "Lemonade", ReleaseDate = new DateTime(2016, 04, 23), Artist = "Beyonce", GenreId = 1, Price = 11.99 });
            albums.Add(new Album() { AlbumId = 16, Title = "Purpose", ReleaseDate = new DateTime(2015, 11, 13), Artist = "Justin Bieber", GenreId = 1, Price = 9.99 });
            albums.Add(new Album() { AlbumId = 17, Title = "Los Duo", ReleaseDate = new DateTime(2015, 02, 10), Artist = "Joan Gabriel", GenreId = 9, Price = 7.99});
            albums.Add(new Album() { AlbumId = 18, Title = "They Don’t KNow", ReleaseDate = new DateTime(2016, 09, 09), Artist = "Jason Aldean", GenreId = 9, Price = 9.99});
            context.Albums.AddRange(albums);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}