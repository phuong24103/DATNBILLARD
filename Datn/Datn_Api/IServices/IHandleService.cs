using Datn_Shared.Models;
using Datn_Shared.ViewModels.HandleViewModels;
using Datn_Shared.ViewModels.RankViewModels;

namespace Datn_Api.IServices
{
    public interface IHandleService
    {
        public Task<bool> CreateHandle(CreateHandle handle);

        public Task<bool> UpdateHandle(Guid id, UpdateHandle handle);

        public Task<bool> DeleteHandle(Guid id);

        public Task<Handle> GetHandleById(Guid id);

        public Task<IEnumerable<Handle>> GetAllHandle();
    }
}
