using Datn_Shared.Models;
using Datn_Shared.ViewModels.RankViewModels;
using Datn_Shared.ViewModels.RenViewModels;

namespace Datn_Api.IServices
{
    public interface IRenService
    {
        public Task<bool> CreateRen(CreateRen ren);

        public Task<bool> UpdateRen(Guid id, RenUpdate ren);

        public Task<bool> DeleteRen(Guid id);

        public Task<Ren> GetRenById(Guid id);

        public Task<IEnumerable<Ren>> GetAllRen();
    }
}
