using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WAD_C2009L_NguyenVanA.Models;

namespace WAD_C2009L_NguyenVanA
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        [Required]
        [Display(Name = "SubjectName", ResourceType = typeof(Resource))]
        public String SubjectName { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        //constructor
        public Subject() {
            this.Exams = new List<Exam>();
        }
    }
}

