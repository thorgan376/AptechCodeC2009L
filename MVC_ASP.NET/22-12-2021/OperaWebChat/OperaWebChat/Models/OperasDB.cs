using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OperaWebChat.Models
{
    public class OperasDB : DbContext
    {
        public OperasDB() : base()
        {
            this.Database.CommandTimeout = 180;
        }

        public DbSet<Opera> Operas { get; set; }
        public DbSet<Review> Reviews { get; set; }

    }
}