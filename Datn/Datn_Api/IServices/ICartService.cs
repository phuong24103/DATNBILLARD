using Datn_Shared.ViewModels.CartViewModels;

namespace Datn_Api.IServices
{
    public interface ICartService
    {
        public Task<bool> CreateCart(CreateCart cart);

        public Task<bool> DeleteCart(Guid id);

        public Task<CartView> GetCartById(Guid id);

        public Task<List<CartView>> GetAllCart();
    }
}