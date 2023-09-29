using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllCart()
        {
            var cart = await _cartService.GetAllCart();
            return Ok(cart);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetCartById([FromRoute] Guid id)
        {
            var cart = await _cartService.GetCartById(id);
            return Ok(cart);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateCart>> CreateUserRole(CreateCart cart)
        {
            await _cartService.CreateCart(cart);
            return Ok(cart);
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Cart>> DeleteUser([FromRoute] Guid id)
        {
            await _cartService.DeleteCart(id);
            return Ok();
        }
    }
}