using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WAD_C2009L_NguyenVanA.Models
{
    public class DataContext: DbContext
    {
        public DataContext():base("DefaultConnection")
        {
            Database.SetInitializer<DataContext>(new DataInitializer());

        }
       public DbSet<Subject> Subjects { get; set; }
       public DbSet<Exam> Exams { get; set; }
       public DbSet<Student> Students { get; set; }
    }
}