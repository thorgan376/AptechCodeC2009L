using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAP_C2009L_HoangThaiSon.Models
{
    public class Genre
    {
        public int GenreId { get; set; } //Id thể loại
        public string GenreName { get; set; } //Tên thể loại
        public virtual ICollection<Movie> Movies { get; set; }
        public Genre()
        {
            this.Movies = new HashSet<Movie>();
        }

    }
}