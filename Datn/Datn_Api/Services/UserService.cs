using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.UserViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class UserService : IUserservice
    {
        private readonly MyDbContext _context;

        public UserService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateUser(CreateUser user)
        {
            User u = new User()
            {
                Id = Guid.NewGuid(),
                RankId = user.RankId,
                Gender = user.Gender,
                DateOfBirth = user.DateOfBirth,
                Address = user.Address,
                Point = user.Point,
                Status = user.Status,
                UserName = user.UserName,
                Email = user.Email,
                PasswordHash = user.PassWord,
                PhoneNumber = user.PhoneNumber
            };
            try
            {
                await _context.Users.AddAsync(u);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteUser(Guid id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return false;
            try
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<UserView>> GetAllUser()
        {
            List<UserView> lstUserView = new List<UserView>();
            lstUserView = await
                (from a in _context.Users
                 join b in _context.Ranks on a.RankId equals b.Id
                 select new UserView()
                 {
                     Id = a.Id,
                     RankId = b.Id,
                     Gender = a.Gender,
                     DateOfBirth = a.DateOfBirth,
                     Address = a.Address,
                     Point = a.Point,
                     Status = a.Status,
                     UserName = a.UserName,
                     Email = a.Email,
                     PassWord = a.PasswordHash,
                     PhoneNumber = a.PhoneNumber
                 }).ToListAsync();
            return lstUserView;
        }

        public async Task<UserView> GetUserById(Guid id)
        {
            UserView lstUserView = new UserView();
            lstUserView = await
                (from a in _context.Users
                 join b in _context.Ranks on a.RankId equals b.Id
                 select new UserView()
                 {
                     Id = a.Id,
                     RankId = b.Id,
                     Gender = a.Gender,
                     DateOfBirth = a.DateOfBirth,
                     Address = a.Address,
                     Point = a.Point,
                     Status = a.Status,
                     UserName = a.UserName,
                     Email = a.Email,
                     PassWord = a.PasswordHash,
                     PhoneNumber = a.PhoneNumber
                 }).FirstAsync();
            return lstUserView;
        }

        public async Task<bool> UpdateUser(Guid id, UpdateUser user)
        {
            var u = _context.Users.Find(id);
            if (u == null) return false;
            u.Gender = user.Gender;
            u.DateOfBirth = user.DateOfBirth;
            u.Address = user.Address;
            u.Point = user.Point;
            u.Status = user.Status;
            u.UserName = user.UserName;
            u.Email = user.Email;
            u.PasswordHash = user.PassWord;
            u.PhoneNumber = user.PhoneNumber;
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