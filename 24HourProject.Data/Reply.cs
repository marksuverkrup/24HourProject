using _24HourProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Reply
    {
        [Key]
        public int ReplyId { get; set; }

        [ForeignKey(nameof(Comment))]
        public string CommentId { get; set; }
        public virtual Comment Comment { get; set; }

        public string ReplyText { get; set; }

        public Guid ReplyAuthorId { get; set; }


    }
}
