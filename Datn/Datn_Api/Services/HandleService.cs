using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.HandleViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class HandleService : IHandleService
    {
        private readonly MyDbContext _db;
        public HandleService(MyDbContext myDbContext)
        {
                _db = myDbContext;
        }

        public async Task<bool> CreateHandle(CreateHandle handle)
        {
            Handle handle1 = new Handle()
            {
                Id = Guid.NewGuid(),
                Name = handle.Name,
                Status = handle.Status,
                
        };
            try
            {
                await _db.Handles.AddAsync(handle1);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteHandle(Guid id)
        {
            var handle = await _db.Handles.FindAsync(id);
            if (handle == null) return false;
            try
            {
                handle.Status = 2;
                _db.Update(handle);
                await _db.SaveChangesAsync();
                return true;
                    
            }
            catch (Exception)
            {

                return false;
            }

        }

        public async Task<IEnumerable<Handle>> GetAllHandle()
        {
            return await _db.Handles.ToListAsync();
        }

        public async Task<Handle> GetHandleById(Guid id)
        {
            return await _db.Handles.FindAsync(id);
        }

        public async Task<bool> UpdateHandle(Guid id, UpdateHandle handle)
        {
          var h = await _db.Handles.FindAsync(id);
            if (h == null) return false;
            h.Name = handle.Name;
            h.Status = handle.Status;
            try
            {
                _db.Handles.Update(h);
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
