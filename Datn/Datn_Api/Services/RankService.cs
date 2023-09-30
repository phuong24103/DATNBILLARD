using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.RankViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class RankService : IRankService
    {
        private readonly MyDbContext _context;

        public RankService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateRank(CreateRank rank)
        {
            Rank r = new Rank()
            {
                Id = rank.Id,
                Name = rank.Name,
                NecessaryPoints = rank.NecessaryPoints,
                Description = rank.Description
            };
            try
            {
                await _context.Ranks.AddAsync(r);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteRank(Guid id)
        {
            var rank = _context.Ranks.Find(id);
            if (rank == null) return false;
            try
            {
                _context.Ranks.Remove(rank);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Rank>> GetAllRank()
        {
            return await _context.Ranks.ToListAsync();
        }

        public async Task<Rank> GetRankById(Guid id)
        {
            return await _context.Ranks.FindAsync(id);
        }

        public async Task<bool> UpdateRank(Guid id, UpdateRank rank)
        {
            var r = _context.Ranks.Find(id);
            if (r == null) return false;
            r.Id = rank.Id;
            r.Name = rank.Name;
            r.NecessaryPoints = rank.NecessaryPoints;
            r.Description = rank.Description;
            try
            {
                _context.Update(r);
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