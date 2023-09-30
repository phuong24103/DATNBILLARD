using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.GripeViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class GripeService : IGripeService
    {
        private readonly MyDbContext _db;
        public GripeService(MyDbContext myDbContext)
        {
            _db = myDbContext;
        }
        public async Task<bool> CreateGripe(CreateGripe gripe)
        {
            Gripe gripe1 = new Gripe() {
                Id = Guid.NewGuid(),
                 Name = gripe.Name,
            Status = gripe.Status};
            try
            {
                await _db.Gripes.AddAsync(gripe1);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteGripe(Guid id) { 
        
            var g = await _db.Gripes.FindAsync(id);
            if (g == null) return false;

            try
            {
                g.Status = 2;
                _db.Gripes.Update(g);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }    
        }

        public async Task<IEnumerable<Gripe>> GetAllGripe()
        {
            return await _db.Gripes.ToListAsync();
        }

        public async Task<Gripe> GetGripeById(Guid id)
        {
            return await _db.Gripes.FindAsync(id);
        }

        public async Task<bool> UpdateGripe(Guid id, UpdateGripe gripe)
        {
            var g = await _db.Gripes.FindAsync(id);
            if (g == null) return false;
            g.Name = gripe.Name;
            g.Status = gripe.Status;
            try
            {
                _db.Gripes.Update(g);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
