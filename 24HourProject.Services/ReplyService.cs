using _24HourProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ReplyService
    {
        private readonly Guid _userId;
        public ReplyService(Guid userId)
        {
            _userId = userId;
        }

    }

    public bool CreateReply(ReplyCreate model)
    {
        var entity =
            new Reply()
            {
                CommentId = model.CommentId,
                OwnerId = _userId,
                ReplyText = model.ReplyText,
            };

        using (var ctx = new ApplicationDbContext())
        {
            ctx.Reply.Add(entity);
            return ctx.SaveChanges() == 1;
        }
    }

    public IEnumerable<ReplyListItem> GetReplys()
    {
        using (var ctx = new ApplicationDbContext())
        {
            var query =
                ctx
                .Replys
                .Where(e => e.OwnerId == _userId)
                .Select(
                    e =>
                    new ReplyListItem
                    {
                        ReplyId = e.ReplyId,
                        ReplyText = e.ReplyText,
                    }
                    );
            return query.ToArray();
        }
    }
    public ReplyDetail GetReplyById(int id)
    {
        using (var ctx = new ApplicationDbContext())
        {
            var entity =
                ctx
                .Replys
                .Single(e => e.ReplyId == id && e.OwnerId == _userId);
            return
                new ReplyDetail
                {
                    ReplyId = entity.ReplyId,
                    ReplyText = entity.ReplyText,
                };

        }
    }

    public bool UpdateReply(ReplyEdit model)
    {
        using (var ctx = new ApplicationDbContext())
        {
            var entity =
                ctx
                .Replys
                .Single(e => e.ReplyId == model.ReplyId && e.OwnerId == _userId);

            entity.ReplyId = model.ReplyId;
            entity.ReplyText = model.ReplyText;

            return ctx.SaveChanges() == 1;
        }
    }

    public bool DeleteReply(int ReplyId)
    {
        using (var ctx = new ApplicationDbContext())
        {
            var entity =
                ctx
                .Replys
                .Single(e => e.ReplyId == ReplyId && e.OwnerId == _userId);

            ctx.Replys.Remove(entity);

            return ctx.SaveChanges() == 1;
        }
    }
}
