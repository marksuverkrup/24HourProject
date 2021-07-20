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
<<<<<<< HEAD
        public class Note
        {
            //[Key]
            [Required]
            public int CommentId { get; set; }
=======
        //[Key]
        [Required]
        public int Id { get; set; }
>>>>>>> 101803650261a7f09e6d02d734a7fd2a507fb8fa

        public string Text { get; set; }

        [Required]
        public Guid AuthorId { get; set; }

        public virtual List<Comment> Replies { get; set; }
    }
}
