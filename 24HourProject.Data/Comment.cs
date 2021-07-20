using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Data
{
    public class Comment
    {
        public class Note
        {
            //[Key]
            [Required]
            public int Id { get; set; }

            public string Text { get; set; }

            [Required]
            public Guid AuthorId { get; set; }

            public virtual List<Comment> Replies { get; set; }
        }
    }
}
