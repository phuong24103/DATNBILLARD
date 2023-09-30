using Datn_Shared.Models;
using Datn_Shared.ViewModels.RankViewModels;

namespace Datn_Api.IServices
{
    public interface IRankService
    {
        public Task<bool> CreateRank(CreateRank rank);

        public Task<bool> UpdateRank(Guid id, UpdateRank rank);

        public Task<bool> DeleteRank(Guid id);

        public Task<Rank> GetRankById(Guid id);

        public Task<IEnumerable<Rank>> GetAllRank();
    }
}