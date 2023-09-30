using Datn_Shared.Models;
using Datn_Shared.ViewModels.MaterialViewModels;
using Datn_Shared.ViewModels.RankViewModels;

namespace Datn_Api.IServices
{
    public interface IMaterialService
    {
        public Task<bool> CreateMaterial (CreateMaterial material);

        public Task<bool> UpdateMaterial(Guid id, UpdateMaterial material);

        public Task<bool> DeleteMaterial(Guid id);

        public Task<Material> GetMaterialById(Guid id);

        public Task<IEnumerable<Material>> GetAllMaterial();
    }
}
