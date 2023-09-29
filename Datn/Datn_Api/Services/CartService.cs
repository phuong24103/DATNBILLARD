using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class CartService : ICartService
    {
        private readonly MyDbContext _context;

        public CartService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCart(CreateCart cart)
        {
            Cart c = new Cart()
            {
                UserId = cart.UserId,
                Description = cart.Description
            };
            try
            {
                await _context.Carts.AddAsync(c);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteCart(Guid id)
        {
            var cart = _context.Carts.Find(id);
            if (cart == null) return false;
            try
            {
                _context.Carts.Remove(cart);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<CartView>> GetAllCart()
        {
            List<CartView> lstCartView = new List<CartView>();
            lstCartView = await
                (from a in _context.Carts
                 join b in _context.Users on a.UserId equals b.Id
                 select new CartView()
                 {
                     UserId = b.Id,
                     Description = a.Description
                 }).ToListAsync();
            return lstCartView;
        }

        public async Task<CartView> GetCartById(Guid id)
        {
            CartView lstCartView = new CartView();
            lstCartView = await
                (from a in _context.Carts
                 join b in _context.Users on a.UserId equals b.Id
                 select new CartView()
                 {
                     UserId = b.Id,
                     Description = a.Description
                 }).FirstAsync();
            return lstCartView;
        }
    }
}