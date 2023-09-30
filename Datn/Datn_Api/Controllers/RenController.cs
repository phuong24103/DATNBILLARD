using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.RenViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RenController : ControllerBase
    {
        private readonly IRenService _irensv;
        public RenController(IRenService renService)
        {
                _irensv = renService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllRen()
        {
            var mate = await _irensv.GetAllRen();
            return Ok(mate);
        }
        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetRenById([FromRoute] Guid id)
        {
            var mate = await _irensv.GetRenById(id);
            return Ok(mate);
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateRen>> CreateRen(CreateRen createRen)
        {
            await _irensv.CreateRen(createRen);
            return Ok(createRen);
        }
        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<RenUpdate>> UpdateRen([FromRoute] Guid id, [FromBody] RenUpdate renUpdate)
        {
            await _irensv.UpdateRen(id, renUpdate);
            return Ok(renUpdate);
        }
        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Ren>> DeleteRen([FromRoute] Guid id)
        {
            await _irensv.DeleteRen(id);
            return Ok();
        }
    }
}
