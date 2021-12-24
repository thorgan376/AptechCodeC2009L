namespace WAD_C2009L_NguyenVanA.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WAD_C2009L_NguyenVanA.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WAD_C2009L_NguyenVanA.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WAD_C2009L_NguyenVanA.Models.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            base.Seed(context);
            Console.WriteLine("Seeddddd");
            context.Students.Add(new Student()
            {
                StudentId = 1,
                StudentName = "nguyen van A",
                StudentClass = "C2009L",
                StudentDOB = new DateTime(2000, 12, 25),
            });
            context.Students.Add(new Student()
            {
                StudentId = 2,
                StudentName = "nguyen van B",
                StudentClass = "C2009L",
                StudentDOB = new DateTime(2000, 12, 25),
            });
            context.Students.Add(new Student()
            {
                StudentId = 3,
                StudentName = "nguyen van D",
                StudentClass = "C2009L",
                StudentDOB = new DateTime(2001, 09, 11),
            });
            context.Students.Add(new Student()
            {
                StudentId = 4,
                StudentName = "nguyen van E",
                StudentClass = "C2009L",
                StudentDOB = new DateTime(2003, 10, 22),
            });
            context.Students.Add(new Student()
            {
                StudentId = 5,
                StudentName = "nguyen van B",
                StudentClass = "C2009L",
                StudentDOB = new DateTime(2002, 08, 21),
            });
            context.SaveChanges();
            context.Subjects.Add(new Subject()
            {
                SubjectId = 1,
                SubjectName = "EPC",
            });
            context.Subjects.Add(new Subject()
            {
                SubjectId = 2,
                SubjectName = "PHP",
            });
            context.Subjects.Add(new Subject()
            {
                SubjectId = 3,
                SubjectName = "ASP.NET MVC",
            });
            context.Subjects.Add(new Subject()
            {
                SubjectId = 4,
                SubjectName = "Java",
            });
            context.SaveChanges();
            context.Exams.Add(new Exam()
            {
                StudentId = 1,
                SubjectId = 2,
                Mark = 5,
            });
            context.Exams.Add(new Exam()
            {
                StudentId = 2,
                SubjectId = 2,
                Mark = 6,
            });

            context.Exams.Add(new Exam()
            {
                StudentId = 3,
                SubjectId = 2,
                Mark = 7,
            });

            context.Exams.Add(new Exam()
            {
                StudentId = 1,
                SubjectId = 4,
                Mark = 9,
            });

            context.Exams.Add(new Exam()
            {
                StudentId = 2,
                SubjectId = 3,
                Mark = 4,
            });

            context.Exams.Add(new Exam()
            {
                StudentId = 3,
                SubjectId = 3,
                Mark = 3,
            });

            context.Exams.Add(new Exam()
            {
                StudentId = 3,
                SubjectId = 4,
                Mark = 2,
            });

            context.SaveChanges();
        }
    }
}
