using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class ProductService : IProductService
    {
        private readonly MyDbContext _dbContext;
        public ProductService(MyDbContext myDbContext)
        {
                _dbContext = myDbContext;
        }
        public async Task<bool> CreateProduct(CreateProduct product)
        {
           Product product1 = new Product() {
               Id = Guid.NewGuid(),
               MaterialId = product.MaterialId,
               GripeId = product.GripeId,
               RenId = product.RenId,
               TipId = product.TipId,
               HandleId = product.HandleId,

               Name = product.Name,
               ImportPrice = product.ImportPrice,
               Price = product.Price,
               AvailableQuantity = product.AvailableQuantity,
               Sold = product.Sold,
               Image = product.Image,
               CreateDate = product.CreateDate,
               Producer = product.Producer,
               Status = product.Status,
               Description = product.Description,
               
           }
           ;
            try
            {
                await _dbContext.Products.AddAsync(product1);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteProduct(Guid id)
        {
            var product =await _dbContext.Products.FindAsync(id);
            if (product == null) return false;
            try
            {
                product.Status = 2;
                _dbContext.Products.Update(product);

                await _dbContext.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<IEnumerable<ProductView>> GetAllProduct()
        {
           List<ProductView> products = new List<ProductView>();
            products = await
                (from a in _dbContext.Products
                 join b in _dbContext.Materials on a.MaterialId equals b.Id
                 join c in _dbContext.Rens on a.RenId  equals c.Id
                 join d in _dbContext.Handles on a.HandleId equals d.Id
                 join e in _dbContext.Tips on a.TipId equals e.Id
                 join f in _dbContext.Gripes on a.GripeId equals f.Id
                 select new ProductView()
                 {
                     Id = a.Id,
                     MaterialId = a.MaterialId,
                     RenId = a.RenId,
                     HandleId = a.HandleId,
                     TipId = a.TipId,
                     GripeId = a.GripeId,
                     Name = a.Name,
                     ImportPrice = a.ImportPrice,
                     Price = a.Price,
                     AvailableQuantity = a.AvailableQuantity,
                     Sold = a.Sold,
                     Image = a.Image,
                     CreateDate = a.CreateDate,
                     Producer = a.Producer,
                     Status = a.Status,
                     Description = a.Description,
                     Material = b,
                     Ren = c,
                     Handle = d,
                     Tip = e,
                     Gripe = f,

                 }).ToListAsync();
            return products;
        }

        public async Task<ProductView> GetProductById(Guid id)
        {
           ProductView productView = new ProductView();
            productView = await (from a in _dbContext.Products
                                 join b in _dbContext.Materials on a.MaterialId equals b.Id
                                 join c in _dbContext.Rens on a.RenId equals c.Id
                                 join d in _dbContext.Handles on a.HandleId equals d.Id
                                 join e in _dbContext.Tips on a.TipId equals e.Id
                                 join f in _dbContext.Gripes on a.GripeId equals f.Id
                                 where a.Id == id
                                 select new ProductView()
                                 {
                                     Id = a.Id,
                                     MaterialId = a.MaterialId,
                                     RenId = a.RenId,
                                     HandleId = a.HandleId,
                                     TipId = a.TipId,
                                     GripeId = a.GripeId,
                                     Name = a.Name,
                                     ImportPrice = a.ImportPrice,
                                     Price = a.Price,
                                     AvailableQuantity = a.AvailableQuantity,
                                     Sold = a.Sold,
                                     Image = a.Image,
                                     CreateDate = a.CreateDate,
                                     Producer = a.Producer,
                                     Status = a.Status,
                                     Description = a.Description,
                                     Material = b,
                                     Ren = c,
                                     Handle = d,
                                     Tip = e,
                                     Gripe = f,

                                 }).FirstAsync();
            return productView;

        }

        public async Task<IEnumerable<ProductView>> GetProductByName(string name)
        {
            List<ProductView> products = new List<ProductView>();
            products = await
                (from a in _dbContext.Products
                 join b in _dbContext.Materials on a.MaterialId equals b.Id
                 join c in _dbContext.Rens on a.RenId equals c.Id
                 join d in _dbContext.Handles on a.HandleId equals d.Id
                 join e in _dbContext.Tips on a.TipId equals e.Id
                 join f in _dbContext.Gripes on a.GripeId equals f.Id
                 select new ProductView()
                 {
                     Id = a.Id,
                     MaterialId = a.MaterialId,
                     RenId = a.RenId,
                     HandleId = a.HandleId,
                     TipId = a.TipId,
                     GripeId = a.GripeId,
                     Name = a.Name,
                     ImportPrice = a.ImportPrice,
                     Price = a.Price,
                     AvailableQuantity = a.AvailableQuantity,
                     Sold = a.Sold,
                     Image = a.Image,
                     CreateDate = a.CreateDate,
                     Producer = a.Producer,
                     Status = a.Status,
                     Description = a.Description,
                     Material = b,
                     Ren = c,
                     Handle = d,
                     Tip = e,
                     Gripe = f,

                 }).Where(p => p.Name.ToLower().Contains(name.ToLower())).ToListAsync();
            return products;
        }

        public async Task<bool> UpdateProduct(Guid id, UpdateProduct product)
        {
            var p = await _dbContext.Products.FindAsync(id);
            if (p == null) return false;
            p.Name = product.Name;
            p.ImportPrice = product.ImportPrice;
            p.Price = product.Price;
            p.AvailableQuantity = product.AvailableQuantity;
            p.Sold = product.Sold;
            p.Image = product.Image;
            p.CreateDate = product.CreateDate;
            p.Producer = product.Producer;
            p.Status = product.Status;
            p.Description = product.Description;
            p.MaterialId = product.MaterialId;
            p.RenId = product.RenId;
            p.HandleId = product.HandleId;
            p.TipId = product.TipId;
            p.GripeId = product.GripeId;
            try
            {
                _dbContext.Update(p);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
