namespace EAP_C2009L_HoangThaiSon.Migrations
{
    using EAP_C2009L_HoangThaiSon.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EAP_C2009L_HoangThaiSon.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EAP_C2009L_HoangThaiSon.Models.DataContext context)
        {
            base.Seed(context);
            //insert data here
            Console.WriteLine("Test if it work or not");
            context.Genres.Add(new Genre { GenreId = 1, GenreName = "Science Fiction Film" });
            context.Genres.Add(new Genre { GenreId = 2, GenreName = "Romantic Disaster Film" });
            context.Genres.Add(new Genre { GenreId = 3, GenreName = "Opera Film" });
            context.Genres.Add(new Genre { GenreId = 4, GenreName = "Super Hero Film" });
            context.Genres.Add(new Genre { GenreId = 5, GenreName = "Action Film" });
            context.Genres.Add(new Genre { GenreId = 6, GenreName = "3D Animated Feature Film" });
            context.Genres.Add(new Genre { GenreId = 7, GenreName = "Musical" });
            context.SaveChanges();
            // Genres done
            context.Movies.Add(new Movie { MovieId = 01, Title = "Avatar", ReleaseDate = DateTime.Parse("2009-12-10"), RunningTime = 161, GenreId = 1, BoxOffice = 2.788 });
            context.Movies.Add(new Movie { MovieId = 02, Title = "Titanic", ReleaseDate = DateTime.Parse("1997-11-01"), RunningTime = 195, GenreId = 2, BoxOffice = 2.187 });
            context.Movies.Add(new Movie { MovieId = 03, Title = "Star Wars: The Force Awakens", ReleaseDate = DateTime.Parse("2015-12-14"), RunningTime = 135, GenreId = 3, BoxOffice = 1.763 });
            context.Movies.Add(new Movie { MovieId = 04, Title = "Jurassic World", ReleaseDate = DateTime.Parse("2015-05-29"), RunningTime = 124, GenreId = 1, BoxOffice = 1.669 });
            context.Movies.Add(new Movie { MovieId = 05, Title = "Marvel Avengers", ReleaseDate = DateTime.Parse("2012-04-11"), RunningTime = 143, GenreId = 4, BoxOffice = 1.520 });
            context.Movies.Add(new Movie { MovieId = 06, Title = "Fast And Furius", ReleaseDate = DateTime.Parse("2015-04-11"), RunningTime = 137, GenreId = 5, BoxOffice = 1.515 });
            context.Movies.Add(new Movie { MovieId = 07, Title = "Frozen", ReleaseDate = DateTime.Parse("2013-11-19"), RunningTime = 102, GenreId = 6, BoxOffice = 1.276 });
            context.Movies.Add(new Movie { MovieId = 08, Title = "Iron Man 3", ReleaseDate = DateTime.Parse("2013-05-03"), RunningTime = 130, GenreId = 4, BoxOffice = 1.215 });
            context.Movies.Add(new Movie { MovieId = 09, Title = "Minions", ReleaseDate = DateTime.Parse("2015-06-11"), RunningTime = 91, GenreId = 6, BoxOffice = 1.157 });
            context.Movies.Add(new Movie { MovieId = 10, Title = "Transformers", ReleaseDate = DateTime.Parse("2007-06-12"), RunningTime = 144, GenreId = 1, BoxOffice = 0.71 });
            context.Movies.Add(new Movie { MovieId = 11, Title = "High School Musical", ReleaseDate = DateTime.Parse("2016-01-20"), RunningTime = 98, GenreId = 7, BoxOffice = 0.4 });
            context.Movies.Add(new Movie { MovieId = 12, Title = "Gangnam Style", ReleaseDate = DateTime.Parse("2007-06-12"), RunningTime = 93, GenreId = 7, BoxOffice = 0.5 });
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
