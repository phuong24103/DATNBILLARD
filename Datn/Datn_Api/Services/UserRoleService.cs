using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.UserRoleViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class UserRoleService : IUserRoleService
    {
        private readonly MyDbContext _context;

        public UserRoleService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateUserRole(CreateUserRole userrole)
        {
            UserRole u = new UserRole()
            {
                UserId = userrole.UserId,
                RoleId = userrole.RoleId
            };
            try
            {
                await _context.UserRoles.AddAsync(u);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteUserRole(Guid id)
        {
            var userrole = _context.Users.Find(id);
            if (userrole == null) return false;
            try
            {
                _context.Users.Remove(userrole);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<UserRoleView>> GetAllUserRole()
        {
            List<UserRoleView> lstUserView = new List<UserRoleView>();
            lstUserView = await
                (from a in _context.UserRoles
                 join b in _context.Users on a.UserId equals b.Id
                 join c in _context.Roles on a.RoleId equals c.Id
                 select new UserRoleView()
                 {
                     UserId = b.Id,
                     RoleId = c.Id,
                 }).ToListAsync();
            return lstUserView;
        }

        public async Task<UserRoleView> GetUserRoleById(Guid id)
        {
            UserRoleView lstUserView = new UserRoleView();
            lstUserView = await
                (from a in _context.UserRoles
                 join b in _context.Users on a.UserId equals b.Id
                 join c in _context.Roles on a.RoleId equals c.Id
                 select new UserRoleView()
                 {
                     UserId = b.Id,
                     RoleId = c.Id,
                 }).FirstAsync();
            return lstUserView;
        }

        public async Task<bool> UpdateUserRole(Guid id, UpdateUserRole userrole)
        {
            var u = _context.UserRoles.Find(id);
            if (u == null) return false;
            u.UserId = userrole.UserId;
            u.RoleId = userrole.RoleId;
            try
            {
                _context.Update(u);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}