namespace EAP_C2009L_NguyenVanA.Migrations
{
    using EAP_C2009L_NguyenVanA.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EAP_C2009L_NguyenVanA.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EAP_C2009L_NguyenVanA.Models.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            base.Seed(context);
            //insert data
            Console.WriteLine("seeding...");
            context.Categories.Add(new Category { CategoryId = 1, CategoryName = "Smartphone" });
            context.Categories.Add(new Category { CategoryId = 2, CategoryName = "Tablet" });
            context.Categories.Add(new Category { CategoryId = 3, CategoryName = "Laptop" });
            context.SaveChanges();
            context.Products.Add(new Product
            {
                ProductId = 01,
                ProductName = "iPhone",
                Price = 399,
                Quantity = 3,
                ReleaseDate = DateTime.Parse("2007-06-29"),
                CategoryId = 1
            });
            context.Products.Add(new Product
            {
                ProductId = 02,
                ProductName = "Galaxy Note",
                Price = 355,
                Quantity = 3,
                ReleaseDate = DateTime.Parse("2015-09-01"),
                CategoryId = 1
            });
            context.Products.Add(new Product
            {
                ProductId = 03,
                ProductName = "xPeria",
                Price = 319,
                Quantity = 3,
                ReleaseDate = DateTime.Parse("2015-09-01"),
                CategoryId = 1
            });
            context.Products.Add(new Product
            {
                ProductId = 04,
                ProductName = "iPad",
                Price = 319,
                Quantity = 10,
                ReleaseDate = DateTime.Parse("2010-07-01"),
                CategoryId = 2
            });

            context.Products.Add(new Product
            {
                ProductId = 05,
                ProductName = "Galaxy Tab",
                Price = 655,
                Quantity = 7,
                ReleaseDate = DateTime.Parse("2013-07-07"),
                CategoryId = 2
            });
            context.Products.Add(new Product
            {
                ProductId = 06,
                ProductName = "xPeria Tablet",
                Price = 619,
                Quantity = 3,
                ReleaseDate = DateTime.Parse("2013-10-03"),
                CategoryId = 2
            });
            context.Products.Add(new Product
            {
                ProductId = 07,
                ProductName = "iMac",
                Price = 1099,
                Quantity = 3,
                ReleaseDate = DateTime.Parse("2016-09-10"),
                CategoryId = 3
            });
            context.Products.Add(new Product
            {
                ProductId = 08,
                ProductName = "ATIV Book",
                Price = 1055,
                Quantity = 5,
                ReleaseDate = DateTime.Parse("2011-03-04"),
                CategoryId = 3
            });
            context.Products.Add(new Product
            {
                ProductId = 09,
                ProductName = "Vaio",
                Price = 1019,
                Quantity = 5,
                ReleaseDate = DateTime.Parse("2002-12-14"),
                CategoryId = 3
            });
            context.Products.Add(new Product
            {
                ProductId = 10,
                ProductName = "Lumia",
                Price = 315,
                Quantity = 5,
                ReleaseDate = DateTime.Parse("2012-04-14"),
                CategoryId = 1
            });
            context.Products.Add(new Product
            {
                ProductId = 11,
                ProductName = "Oppo",
                Price = 415,
                Quantity = 5,
                ReleaseDate = DateTime.Parse("2015-12-14"),
                CategoryId = 1
            });
            context.Products.Add(new Product
            {
                ProductId = 12,
                ProductName = "Asus ZendPad",
                Price = 125,
                Quantity = 5,
                ReleaseDate = DateTime.Parse("2015-08-14"),
                CategoryId = 2
            });
            context.Products.Add(new Product
            {
                ProductId = 13,
                ProductName = "Dell Vostro",
                Price = 751,
                Quantity = 5,
                ReleaseDate = DateTime.Parse("2013-12-14"),
                CategoryId = 3
            });
            context.Products.Add(new Product
            {
                ProductId = 14,
                ProductName = "HP Pavillion",
                Price = 832,
                Quantity = 5,
                ReleaseDate = DateTime.Parse("2011-07-11"),
                CategoryId = 3
            });
            context.Products.Add(new Product
            {
                ProductId = 15,
                ProductName = "Surface Pro",
                Price = 1790,
                Quantity = 5,
                ReleaseDate = DateTime.Parse("2013-10-22"),
                CategoryId = 2
            });
            context.SaveChanges();
        }
    }
}
