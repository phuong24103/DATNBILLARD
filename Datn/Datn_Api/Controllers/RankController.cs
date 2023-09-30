using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.RankViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankController : ControllerBase
    {
        private readonly IRankService _rankService;

        public RankController(IRankService rankService)
        {
            _rankService = rankService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllRank()
        {
            var user = await _rankService.GetAllRank();
            return Ok(user);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetRankById([FromRoute] Guid id)
        {
            var post = await _rankService.GetRankById(id);
            return Ok(post);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateRank>> CreateRank(CreateRank user)
        {
            await _rankService.CreateRank(user);
            return Ok(user);
        }

        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateRank>> UpdateRank([FromRoute] Guid id, [FromBody] UpdateRank user)
        {
            await _rankService.UpdateRank(id, user);
            return Ok(user);
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Rank>> DeleteRank([FromRoute] Guid id)
        {
            await _rankService.DeleteRank(id);
            return Ok();
        }
    }
}