using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class MyDBContext: DbContext
    {
        private static string CONNECTION_STRING = "Data Source=localhost,1434;Initial Catalog=testDB;User ID=sa;Password=Abc123456789;";
        public virtual DbSet<Todo> Todos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try {
                Console.WriteLine("haha");
                optionsBuilder.UseSqlServer(CONNECTION_STRING);
            } catch(Exception e)
            {
                Console.WriteLine("aaa");
            }
        }
        
    }
}
