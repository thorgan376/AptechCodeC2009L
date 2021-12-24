using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WAD_C2009L_NguyenVanA.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public String StudentName { get; set; }
        public DateTime StudentDOB { get; set; }
        public String StudentClass { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        //constructor
        public Student()
        {
            this.Exams = new List<Exam>();
        }
    }
}