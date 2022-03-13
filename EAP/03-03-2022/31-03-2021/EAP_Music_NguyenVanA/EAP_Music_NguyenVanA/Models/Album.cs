
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EAP_Music_NguyenVanA.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        [Required]
        [StringLength(32, MinimumLength = 3)]
        public String Title { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime ReleaseDate { get; set; }
        [Required]
        public String Artist { get; set; }

        [Required]
        [Range(1, 15)]
        public double Price { get; set; }
        public int GenreId { get; set; }
        
        [Newtonsoft.Json.JsonIgnore]
        public virtual Genre Genre {get; set;}
    }
}