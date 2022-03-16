using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAP_C2009L_HoangThaiSon.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RunningTime { get; set; }
        public double BoxOffice { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}