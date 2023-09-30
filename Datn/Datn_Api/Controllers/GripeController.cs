using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.GripeViewModels;
using Datn_Shared.ViewModels.MaterialViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GripeController : ControllerBase
    {
        private readonly IGripeService _igripeService;
        public GripeController(IGripeService gripeService)
        {
            _igripeService = gripeService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllGripe()
        {
            var mate = await _igripeService.GetAllGripe();
            return Ok(mate);
        }
        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetGripeById([FromRoute] Guid id)
        {
            var mate = await _igripeService.GetGripeById(id);
            return Ok(mate);
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateGripe>> CreateGripe(CreateGripe createGripe)
        {
            await _igripeService.CreateGripe(createGripe);
            return Ok(createGripe);
        }
        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateGripe>> UpdateGripe([FromRoute] Guid id, [FromBody] UpdateGripe updateGripe)
        {
            await _igripeService.UpdateGripe(id, updateGripe );
            return Ok(updateGripe);
        }
        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Gripe>> DeleteGripe([FromRoute] Guid id)
        {
            await _igripeService.DeleteGripe(id);
            return Ok();
        }
    }
}
