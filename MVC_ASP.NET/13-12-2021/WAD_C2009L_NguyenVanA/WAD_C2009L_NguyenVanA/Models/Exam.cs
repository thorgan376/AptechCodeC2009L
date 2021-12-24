using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAD_C2009L_NguyenVanA.Models
{
    public class Exam
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Mark { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject {get; set;}
    }
}
