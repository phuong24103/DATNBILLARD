using Datn_Shared.ViewModels.PostViewModels;
using Datn_Shared.ViewModels.UserViewModels;

namespace Datn_Api.IServices
{
    public interface IUserservice
    {
        public Task<bool> CreateUser(CreateUser user);

        public Task<bool> UpdateUser(Guid id, UpdateUser user);

        public Task<bool> DeleteUser(Guid id);

        public Task<UserView> GetUserById(Guid id);

        public Task<List<UserView>> GetAllUser();
    }
}