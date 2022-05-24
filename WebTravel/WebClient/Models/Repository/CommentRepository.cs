using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebClient.Models.Repository
{
    public class CommentRepository : BaseRepository
    {
        public CommentRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<int> Add(Comment obj)
        {
            return await Post<Comment>("/api/comment", obj);
        }
        public async Task<int> Edit(Comment obj)
        {
            return await Post<Comment>("/api/comment/edit", obj);
        }
        public async Task<List<Comment>> GetCommentsByTourIdParent(string id)
        {
            return await Get<List<Comment>>($"/api/comment/commenttourparent/{id}");
        }
        public async Task<List<Comment>> GetCommentsByTourId(string id)
        {
            return await Get<List<Comment>>($"/api/comment/commenttour/{id}");
        }
    }
}
