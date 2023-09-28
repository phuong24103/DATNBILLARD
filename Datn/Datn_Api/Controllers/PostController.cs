using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.Post;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllPost()
        {
            var post = await _postService.GetAllPost();
            return Ok(post);
        }
        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetPostById([FromRoute] Guid id)
        {
            var post = await _postService.GetPostById(id);
            return Ok(post);
        }
        [HttpGet]
        [Route("GetByTitle/{title}")]
        public async Task<IActionResult> GetPostByTitle([FromRoute] string title)
        {
            var post = await _postService.GetPostByTitle(title);
            return Ok(post);
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreatePost>> CreatePost(CreatePost post)
        {
            await _postService.CreatePost(post);
            return Ok(post);
        }
        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdatePost>> UpdatePost([FromRoute] Guid id, [FromBody] UpdatePost post)
        {
            await _postService.UpdatePost(id, post);
            return Ok(post);
        }
        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Post>> DeletePost([FromRoute] Guid id)
        {
            await _postService.DeletePost(id);
            return Ok();
        }
    }
}
