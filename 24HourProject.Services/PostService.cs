using _24HourProject.Data;
using _24HourProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourProject.Services
{
<<<<<<< HEAD:24HourProject.Services/PostService.cs
    public class PostService
    {
        private readonly Guid _authorId;

        public PostService(Guid authorId)
=======
    public class PostServices
    {
        private readonly Guid _authorId;

        public PostServices(Guid authorId)
>>>>>>> 101803650261a7f09e6d02d734a7fd2a507fb8fa:24HourProject.Services/PostServices.cs
        {
            _authorId = authorId;
        }

        public bool CreatePost(PostCreate model)
        {
            var entity =
                new Post()
                {
                    PostId = model.PostId,
                    Title = model.Title,
                    Text = model.Text,
                    AuthorId = _authorId
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Post.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PostList> GetPosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Posts
                        .Where(e => e.AuthorId == _authorId)
                        .Select(
                            e =>
                                new PostList
                                {
<<<<<<< HEAD:24HourProject.Services/PostService.cs
                                    Title = e.Title
                                    Text = e.Text
=======
                                    
>>>>>>> 101803650261a7f09e6d02d734a7fd2a507fb8fa:24HourProject.Services/PostServices.cs
                                }
                       );
                return query.ToArray();
            }
        }

        public PostDetail GetPostById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Posts
                        .Single(e => e.PostId == id && e.AuthorId == _authorId);
                return
                    new PostDetail
                    {
                        
                    };
            }
        }

        public bool UpdatePost(PostEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Posts
                        .Single(e => e.PostId == model.PostId && e.AuthorId == _authorId);
                entity.Title = model.Title;
                entity.Text = model.Text;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeletePost(int postId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Notes
                        .Single(e => e.PostId == postId && e.AuthorId == _authorId);
                ctx.Notes.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
