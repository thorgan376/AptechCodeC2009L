using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EAP_Music_NguyenVanANew.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        [Required]
        [StringLength(32, MinimumLength =3, ErrorMessage ="Title must be 3 to 32 in length")]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Artist { get; set; }
        [Required]
        [Range(1, 15)]
        public double Price { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}