using Datn_Shared.Models;
using Datn_Shared.ViewModels.RankViewModels;
using Datn_Shared.ViewModels.TipViewModels;

namespace Datn_Api.IServices
{
    public interface ITipService
    {
        public Task<bool> CreateTip(CreateTip tip);

        public Task<bool> UpdateTip(Guid id, UpdateTip tip);

        public Task<bool> DeleteTip(Guid id);

        public Task<Tip> GetTipById(Guid id);

        public Task<IEnumerable<Tip>> GetAllTip();
    }
}
