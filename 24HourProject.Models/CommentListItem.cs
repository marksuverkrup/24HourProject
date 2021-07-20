using _24HourProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    public class CommentListItem
    {
        [Display(Name = "Comment ID")]
        public int CommentId { get; set; }

        [Display(Name = "Text")]
        public string Text { get; set; }

        public Guid AuthorId { get; set; }

        public virtual List<Comment> Replies { get; set; }

    }
}
