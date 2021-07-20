using _24HourProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Models
{
    class ReplyDetail
    {
        [Required]
        [ForeignKey(nameof(Comment))]
        public string CommentId { get; set; }
        public virtual Comment Comment { get; set; }

        public int ReplyId { get; set; }

        public string ReplyText { get; set; }

        public Guid ReplyAuthorId { get; set; }
    }
}
