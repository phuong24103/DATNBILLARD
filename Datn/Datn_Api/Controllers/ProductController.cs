using Datn_Api.IServices;
using Datn_Api.Services;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.MaterialViewModels;
using Datn_Shared.ViewModels.ProductViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _iprosv;
        public ProductController( IProductService productService)
        {
                _iprosv = productService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllProduct()
        {
            var mate = await _iprosv.GetAllProduct();
            return Ok(mate);
        }
        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetProductById([FromRoute] Guid id)
        {
            var mate = await _iprosv.GetProductById(id);
            return Ok(mate);
        }
        [HttpGet("{name}")]
        public async Task<IActionResult> GetProductByName([FromRoute] string name)
        {
            var product = await _iprosv.GetProductByName(name);
            return Ok(product);
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreateProduct>> CreateProduct(CreateProduct createProduct)
        {
            await _iprosv.CreateProduct(createProduct);
            return Ok(createProduct);
        }
        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdateProduct>> UpdateProduct([FromRoute] Guid id, [FromBody] UpdateProduct updateProduct)
        {
            await _iprosv.UpdateProduct(id, updateProduct);
            return Ok(updateProduct);
        }
        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Product>> DeleteProduct([FromRoute] Guid id)
        {
            await _iprosv.DeleteProduct(id);
            return Ok();
        }
    }
}
