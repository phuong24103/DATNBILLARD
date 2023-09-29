using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.UserRoleViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleService _userroleService;

        public UserRoleController(IUserRoleService userroleService)
        {
            _userroleService = userroleService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllUser()
        {
            var user = await _userroleService.GetAllUserRole();
            return Ok(user);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetUserRoleById([FromRoute] Guid id)
        {
            var post = await _userroleService.GetUserRoleById(id);
            return Ok(post);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateUserRole>> CreateUserRole(CreateUserRole userrole)
        {
            await _userroleService.CreateUserRole(userrole);
            return Ok(userrole);
        }

        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateUserRole>> UpdateUserRole([FromRoute] Guid id, [FromBody] UpdateUserRole userrole)
        {
            await _userroleService.UpdateUserRole(id, userrole);
            return Ok(userrole);
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<UserRole>> DeleteUser([FromRoute] Guid id)
        {
            await _userroleService.DeleteUserRole(id);
            return Ok();
        }
    }
}