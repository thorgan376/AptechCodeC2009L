using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EAP_Music_NguyenVanA.Models
{
    public class Genre
    {
        //property = function
        public int GenreId { get; set; }
        [Required]
        public string GenreName { get; set; }        
        public virtual ICollection<Album> Albums { get; set; }
        /*
        Genre() {
            Albums = new HashSet<Album>();
        }
        */


    }
}