using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.RenViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class RenService : IRenService
        
    {
         private readonly MyDbContext _db;
        public RenService(MyDbContext myDb)
        {
                _db = myDb;
        }
        public async Task<bool> CreateRen(CreateRen ren )
        {
            Ren ren1 = new Ren()
            {
                Id = Guid.NewGuid(),
                Name = ren.Name,
                Status = ren.Status,
            };
            try
            {
                await _db.Rens.AddAsync(ren1);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteRen(Guid id)
        {
            var r = await _db.Rens.FindAsync(id);
            if (r == null) return false;
            try
            {
                r.Status = 2;
                _db.Update(r);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                    return false;
            }
        }

        public async Task<IEnumerable<Ren>> GetAllRen()
        {
            return await _db.Rens.ToListAsync();
        }

        public async Task<Ren> GetRenById(Guid id)
        {
            return await _db.Rens.FindAsync(id);
        }

        public async Task<bool> UpdateRen(Guid id, RenUpdate ren )
        {
            var r = await  _db.Rens.FindAsync( id);
            if (r == null) return false;
            r.Name =  ren.Name;
            r.Status = ren.Status;
            try
            {
                _db.Update(r);
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
