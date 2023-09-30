using Datn_Shared.Models;
using Datn_Shared.ViewModels.GripeViewModels;
using Datn_Shared.ViewModels.RankViewModels;

namespace Datn_Api.IServices
{
    public interface IGripeService
    {
        public Task<bool> CreateGripe(CreateGripe gripe);

        public Task<bool> UpdateGripe(Guid id, UpdateGripe gripe);

        public Task<bool> DeleteGripe(Guid id);

        public Task<Gripe> GetGripeById(Guid id);

        public Task<IEnumerable<Gripe>> GetAllGripe();
    }
}
