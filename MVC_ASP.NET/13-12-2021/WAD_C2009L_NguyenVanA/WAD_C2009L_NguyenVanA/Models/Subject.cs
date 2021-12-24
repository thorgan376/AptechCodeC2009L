using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAD_C2009L_NguyenVanA.Models;

namespace WAD_C2009L_NguyenVanA
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public String SubjectName { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        //constructor
        public Subject() {
            this.Exams = new List<Exam>();
        }
    }
}

