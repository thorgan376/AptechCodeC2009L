using EAP_Music_NguyenVanANew.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EAP_Music_NguyenVanANew
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        public DataContext()
        {

        }
    }
}