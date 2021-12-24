namespace WAD_C2009L_NguyenVanA.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web;
    using WAD_C2009L_NguyenVanA.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WAD_C2009L_NguyenVanA.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WAD_C2009L_NguyenVanA.Models.DataContext context)
        {
            Console.WriteLine("Configuration seed");
            base.Seed(context);
            var students = new List<Student>
            {
                new Student() {
                    StudentId = 1,
                    StudentName = "nguyen van A",
                    StudentClass = "C2009L",
                    StudentDOB = new DateTime(2000, 12, 25),
                },
                new Student()
                {
                    StudentId = 2,
                    StudentName = "nguyen van B",
                    StudentClass = "C2009L",
                    StudentDOB = new DateTime(2000, 12, 25),
                },
                new Student()
                {
                    StudentId = 3,
                    StudentName = "nguyen van D",
                    StudentClass = "C2009L",
                    StudentDOB = new DateTime(2001, 09, 11),
                },
                new Student()
                {
                    StudentId = 4,
                    StudentName = "nguyen van E",
                    StudentClass = "C2009L",
                    StudentDOB = new DateTime(2003, 10, 22),
                },
                new Student()
                {
                    StudentId = 5,
                    StudentName = "nguyen van B",
                    StudentClass = "C2009L",
                    StudentDOB = new DateTime(2002, 08, 21),
                }
            };
            students.ForEach(student => context.Students.Add(student));
            context.SaveChanges();
            var subjects = new List<Subject>
            {
                new Subject() {
                    SubjectId = 1,
                    SubjectName = "EPC",
                },
                new Subject()
                {
                    SubjectId = 2,
                    SubjectName = "PHP",
                },
                new Subject()
                {
                    SubjectId = 3,
                    SubjectName = "ASP.NET MVC",
                },
                new Subject()
                {
                    SubjectId = 4,
                    SubjectName = "Java",
                }
            };
            subjects.ForEach(subject => context.Subjects.Add(subject));
            context.SaveChanges();
            var exams = new List<Exam> {
                new Exam() {
                    StudentId = 1,
                    SubjectId = 2,
                    Mark = 5,
                },
                new Exam()
                {
                    StudentId = 2,
                    SubjectId = 2,
                    Mark = 6,
                },
                new Exam()
                {
                    StudentId = 3,
                    SubjectId = 2,
                    Mark = 7,
                },
                new Exam()
                {
                    StudentId = 1,
                    SubjectId = 4,
                    Mark = 9,
                },
                new Exam()
                {
                    StudentId = 2,
                    SubjectId = 3,
                    Mark = 4,
                },
                new Exam()
                {
                    StudentId = 3,
                    SubjectId = 3,
                    Mark = 3,
                },
                new Exam()
                {
                    StudentId = 3,
                    SubjectId = 4,
                    Mark = 2,
                }
            };
            exams.ForEach(exam => context.Exams.Add(exam));
            context.SaveChanges();
        }
    }
}
