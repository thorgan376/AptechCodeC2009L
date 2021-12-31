using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_C2009L_NguyenVanA.Models
{
    public class Exam
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public int SubjectId { get; set; }
        
        [Required] //NOT NULL
        [Display(Name = "Mark", ResourceType = typeof(Resource))]
        public int Mark { get; set; }
        
        public virtual Student Student { get; set; }
        public virtual Subject Subject {get; set;}
    }
}
