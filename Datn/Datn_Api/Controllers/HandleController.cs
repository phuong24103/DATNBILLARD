using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.HandleViewModels;
using Datn_Shared.ViewModels.MaterialViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HandleController : ControllerBase
    {
        private readonly IHandleService _Ihandlesv;
        public HandleController(IHandleService handleService)
        {
                _Ihandlesv = handleService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllHandle()
        {
            var mate = await _Ihandlesv.GetAllHandle();
            return Ok(mate);
        }
        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetHandleById([FromRoute] Guid id)
        {
            var mate = await _Ihandlesv.GetHandleById(id);
            return Ok(mate);
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateHandle>> CreateHandle(CreateHandle createHandle)
        {
            await _Ihandlesv.CreateHandle(createHandle);
            return Ok(createHandle);
        }
        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateHandle>> UpdateHandle([FromRoute] Guid id, [FromBody] UpdateHandle updateHandle)
        {
            await _Ihandlesv.UpdateHandle(id, updateHandle);
            return Ok(updateHandle);
        }
        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Handle>> DeleteHandle([FromRoute] Guid id)
        {
            await _Ihandlesv.DeleteHandle(id);
            return Ok();
        }
    }
}
