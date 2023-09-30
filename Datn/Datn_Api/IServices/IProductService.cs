using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductViewModels;
using Datn_Shared.ViewModels.RankViewModels;

namespace Datn_Api.IServices
{
    public interface IProductService
    {
        public Task<bool> CreateProduct(CreateProduct product);

        public Task<bool> UpdateProduct(Guid id, UpdateProduct product);

        public Task<bool> DeleteProduct(Guid id);

        public Task<ProductView> GetProductById(Guid id);
        public Task<IEnumerable<ProductView>> GetProductByName(string name);

        public Task<IEnumerable<ProductView>> GetAllProduct();
    }
}
