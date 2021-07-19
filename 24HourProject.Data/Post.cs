using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public List Comments { get; set; }
        public List Likes { get; set; }
        public Guid AuthorId { get; set; }
    }
}
