﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookService.Models
{
    public class Author
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        //1 - n
        //public ICollection<Book> Books { get; set; }
    }
}