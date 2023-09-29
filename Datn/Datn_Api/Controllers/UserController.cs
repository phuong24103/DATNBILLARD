using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.PostViewModels;
using Datn_Shared.ViewModels.UserViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserservice _userService;

        public UserController(IUserservice userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllUser()
        {
            var user = await _userService.GetAllUser();
            return Ok(user);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetUserById([FromRoute] Guid id)
        {
            var post = await _userService.GetUserById(id);
            return Ok(post);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateUser>> CreateUser(CreateUser user)
        {
            await _userService.CreateUser(user);
            return Ok(user);
        }

        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateUser>> UpdateUser([FromRoute] Guid id, [FromBody] UpdateUser user)
        {
            await _userService.UpdateUser(id, user);
            return Ok(user);
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<User>> DeleteUser([FromRoute] Guid id)
        {
            await _userService.DeleteUser(id);
            return Ok();
        }
    }
}