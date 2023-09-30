using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.MaterialViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class MaterialService : IMaterialService
    {
        private readonly MyDbContext _dbcontext;
        public MaterialService(MyDbContext myDbContext)
        {
                _dbcontext = myDbContext;
        }

        public async Task<bool> CreateMaterial(CreateMaterial material)
        {
            Material material1 = new Material()
            {
                Id = Guid.NewGuid(),
                Name = material.Name,
                Status = material.Status,
            };
            try
            {
                await _dbcontext.Materials.AddAsync(material1);
                await _dbcontext.SaveChangesAsync();
                return true;    
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteMaterial(Guid id)
        {
            var material = _dbcontext.Materials.FirstOrDefault(x => x.Id == id);
            if (material == null) return false;
            try
            {
                material.Status = 2;
                _dbcontext.Materials.Update(material);
                
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<IEnumerable<Material>> GetAllMaterial()
        {
          return await _dbcontext.Materials.ToListAsync();
        }

        public async Task<Material> GetMaterialById(Guid id)
        {
           return await _dbcontext.Materials.FindAsync( id);
        }

        public async Task<bool> UpdateMaterial(Guid id, UpdateMaterial material)
        {
            var  m = await _dbcontext.Materials.FindAsync(id);
            if (m == null) return false;
            m.Name = material.Name;
            m.Status = material.Status;
            try
            {
                 
                _dbcontext.Update(material);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
