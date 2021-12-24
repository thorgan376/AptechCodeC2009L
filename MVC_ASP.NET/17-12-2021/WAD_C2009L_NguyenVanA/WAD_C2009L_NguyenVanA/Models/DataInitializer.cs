using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WAD_C2009L_NguyenVanA.Models
{
    //Database Initializer(Code First)
    public class DataInitializer: DropCreateDatabaseIfModelChanges<DataContext>
    {
        public override void InitializeDatabase(DataContext context)
        {
            base.InitializeDatabase(context);
            //Seed(context);

        }
        protected override void Seed(DataContext context)
        {
            /*
                Enable-Migrations    
                Enable-Migrations -ContextTypeName WAD_C2009L_NguyenVanA.Models.DataContext 
                add-migration Initial
                update-database
             */

            //ko dung cau lenh sql
            base.Seed(context);
            context.Students.Add(new Student() { 
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
            context.Subjects.Add(new Subject() { 
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
            context.Exams.Add(new Exam() { 
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