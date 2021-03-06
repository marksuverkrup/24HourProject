using _24HourProject.Data;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace _24HourProject.Models
{
    public class CommentCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many charcters in this field.")]
        public string Text { get; set; }

        [Required]
        public Guid AuthorId { get; set; }

        public virtual List<Comment> Replies { get; set; }
    }
}