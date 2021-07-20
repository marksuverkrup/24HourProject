using _24HourProject.Data;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    class ReplyCreate
    {
        [System.ComponentModel.DataAnnotations.Required]
                
        [ForeignKey(nameof(Comment))]
        public string CommentId { get; set; }
        public virtual Comment Comment { get; set; }

        public int ReplyId { get; set; }

        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in the field.")]
        public string ReplyText { get; set; }

        public Guid ReplyAuthorId { get; set; }



    }
}
