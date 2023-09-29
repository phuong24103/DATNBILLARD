using Datn_Shared.ViewModels.UserRoleViewModels;

namespace Datn_Api.IServices
{
    public interface IUserRoleService
    {
        public Task<bool> CreateUserRole(CreateUserRole userrole);

        public Task<bool> UpdateUserRole(Guid id, UpdateUserRole userrole);

        public Task<bool> DeleteUserRole(Guid id);

        public Task<UserRoleView> GetUserRoleById(Guid id);

        public Task<List<UserRoleView>> GetAllUserRole();
    }
}