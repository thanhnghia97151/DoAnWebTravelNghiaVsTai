using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using WebTravelApi.Models;

namespace WebTravelApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : BaseController
    {
        public CommentController(IConfiguration configuration) : base(configuration)
        {
        }
        [HttpPost]
        public int Add(Comment obj)
        {
            return provider.Comment.Add(obj);
        }
        [HttpPost("edit")]
        public int Edit(Comment obj)
        {
            return provider.Comment.Edit(obj);
        }
        [HttpGet("commenttour/{id}")]
        public IEnumerable<Comment> GetCommentsByTourId(string id)
        {
            return provider.Comment.GetCommentsByTourId(id);
        }
        [HttpGet("commenttourparent/{id}")]
        public IEnumerable<Comment> GetCommentsByTourIdParent(string id)
        {
            return provider.Comment.GetCommentsByTourIdParent(id);
        }

    }
}
