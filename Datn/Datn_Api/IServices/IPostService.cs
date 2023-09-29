using Datn_Shared.Models;
using Datn_Shared.ViewModels.Post;

namespace Datn_Api.IServices
{
    public interface IPostService
    {
        public Task<bool> CreatePost(CreatePost post);
        public Task<bool> UpdatePost(Guid id, UpdatePost post);
        public Task<bool> DeletePost(Guid id);
        public Task<PostView> GetPostById(Guid id);
        public Task<List<PostView>> GetPostByTitle(string title);
        public Task<List<PostView>> GetAllPost();
    }
}
