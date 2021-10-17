using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Content { get; set; }
        [Required]
        public bool IsFinished { get; set; }
        public override string ToString() => $"Id: {Id}, Content: {Content},IsFinished:{IsFinished}";
    }
}
