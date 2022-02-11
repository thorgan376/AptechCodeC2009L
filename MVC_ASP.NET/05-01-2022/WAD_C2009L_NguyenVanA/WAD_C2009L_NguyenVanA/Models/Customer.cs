
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WAD_C2009L_NguyenVanA.Models
{    
    public partial class Customer
    {
        
        public int CustomerId { get; set; }
        [Required(ErrorMessage ="You must enter fullname")]
        [StringLength(maximumLength:32, MinimumLength=3, ErrorMessage ="Length must be between 3 and 32")]
        public string Fullname { get; set; }
        [Required]
        //[DataType(DataType.DateTime)]        
        public System.DateTime Birthday { get; set; }
        [Required(ErrorMessage = "Address must not be null")]
        public string Address { get; set; }
        [Required(ErrorMessage ="You must enter email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="You must enter username")]
        [StringLength(maximumLength: 20, MinimumLength = 8, ErrorMessage ="Username must be 8->20 in length")]
        public string Username { get; set; }

        [Required(ErrorMessage ="You must enter password")]
        [StringLength(maximumLength: 255, MinimumLength = 8)]
        public string Password { get; set; }
        
        [Required]
        [UsernameValidation(8)]
        [Compare("ConfirmPassword", ErrorMessage = "Password doesn't match.")]
        public string ConfirmPassword { get; set; }        
        public int ClassId { get; set; }    
        public virtual Class Class { get; set; }
    }
}
