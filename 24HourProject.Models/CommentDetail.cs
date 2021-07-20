using _24HourProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    public class CommentDetail
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public Guid AuthorId { get; set; }

        public virtual List<Comment> Replies { get; set; }
    }
}