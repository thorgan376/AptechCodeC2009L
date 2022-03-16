using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EAP_C2009L_Hoang_Thai_Son.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Required]
        [StringLength(32, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Range(60, 240)]
        public int RunningTime { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "You must enter valid float Number")]
        public double BoxOffice { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}