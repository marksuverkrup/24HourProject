<<<<<<< HEAD
﻿using _24HourProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
=======
﻿using System;
using System.Collections.Generic;
>>>>>>> origin/develop
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Reply
    {
        [Key]
        public int ReplyId { get; set; }

<<<<<<< HEAD
        [ForeignKey(nameof(Comment))]
=======
        ForeignKey(nameof(Comment))
>>>>>>> origin/develop
        public string CommentId { get; set; }
        public virtual Comment Comment { get; set; }

        public string ReplyText { get; set; }

        public Guid ReplyAuthorId { get; set; }


    }
}
