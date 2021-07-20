using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _24HourProject_WebAPI.Controllers
{
    [Authorize]
    public class ReplyController : ApiController
    {

        public IHttpActionResult Get()
        {
            ReplyService replyService = CreateReplyService();
            var replys = replyService.GetReplys();
            return Ok(replys);
        }

        public IHttpActionResult Get(int replyid)
        {
            ReplyService replyService = CreateReplyService();
            var reply = replyService.GetReplyById(replyid);
            return Ok(reply);
        }

        public IHttpActionResult Post(ReplyCreate reply)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateReplyService();

            if (!service.CreateReply(reply))
                return InternalServerError();

            return Ok();
        }

        private ReplyService CreateReplyService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var replyService = new ReplyService(userId);
            return replyService;
        }

        public IHttpActionResult Put(ReplyEdit note)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateReplyService();

            if (!service.UpdateReply(reply))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int replyid)
        {
            var service = CreateReplyService();

            if (!service.DeleteReply(replyid))
                return InternalServerError();

            return Ok();
        }
    }
}
