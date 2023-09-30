using Datn_Api.IServices;
using Datn_Api.Services;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.MaterialViewModels;
using Datn_Shared.ViewModels.RankViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        private readonly IMaterialService _matesv;
        public MaterialController(IMaterialService materialService)
        {
                _matesv = materialService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult>GetAllMaterial()
        {
            var mate = await _matesv.GetAllMaterial();
            return Ok(mate);
        }
        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetMaterialById([FromRoute]Guid id )
        {
            var mate = await _matesv.GetMaterialById(id);
            return Ok(mate);
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateMaterial>> CreateMaterial(CreateMaterial createMaterial)
        {
            await _matesv.CreateMaterial(createMaterial);
            return Ok(createMaterial);
        }
        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateMaterial>> UpdateMaterial([FromRoute] Guid id, [FromBody] UpdateMaterial updateMaterial)
        {
            await _matesv.UpdateMaterial(id, updateMaterial);
            return Ok(updateMaterial);
        }
        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Material>> DeleteMaterial([FromRoute] Guid id)
        {
            await _matesv.DeleteMaterial(id);
            return Ok();
        }
    }
}
