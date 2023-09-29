using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.PostViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Xml.Linq;

namespace Datn_Api.Services
{
    public class PostService : IPostService
    {
        private readonly MyDbContext _context;

        public PostService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreatePost(CreatePost post)
        {
            Post p = new Post()
            {
                Id = Guid.NewGuid(),
                UserId = post.UserId,
                Content = post.Content,
                Title = post.Title,
                Image = post.Image,
                CreateDate = DateTime.Now,
                Description = post.Description,
                Status = post.Status,
            };
            try
            {
                await _context.Posts.AddAsync(p);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeletePost(Guid id)
        {
            var post = _context.Posts.Find(id);
            if (post == null) return false;
            try
            {
                _context.Posts.Remove(post);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<PostView>> GetAllPost()
        {
            List<PostView> lstPostView = new List<PostView>();
            lstPostView = await
                (from a in _context.Posts
                 join b in _context.Users on a.UserId equals b.Id
                 select new PostView()
                 {
                     Id = a.Id,
                     UserId = a.UserId,
                     Content = a.Content,
                     Title = a.Title,
                     Image = a.Image,
                     CreateDate = a.CreateDate,
                     Description = a.Description,
                     Status = a.Status,
                     Users = b
                 }).ToListAsync();
            return lstPostView;
        }

        public async Task<PostView> GetPostById(Guid id)
        {
            PostView lstPostView = new PostView();
            lstPostView = await
                (from a in _context.Posts
                 join b in _context.Users on a.UserId equals b.Id
                 where a.Id == id
                 select new PostView()
                 {
                     Id = a.Id,
                     UserId = a.UserId,
                     Content = a.Content,
                     Title = a.Title,
                     Image = a.Image,
                     CreateDate = a.CreateDate,
                     Description = a.Description,
                     Status = a.Status,
                     Users = b
                 }).FirstAsync();
            return lstPostView;
        }

        public async Task<List<PostView>> GetPostByTitle(string title)
        {
            List<PostView> lstPostView = new List<PostView>();
            lstPostView = await
                (from a in _context.Posts
                 join b in _context.Users on a.UserId equals b.Id
                 select new PostView()
                 {
                     Id = a.Id,
                     UserId = a.UserId,
                     Content = a.Content,
                     Title = a.Title,
                     Image = a.Image,
                     CreateDate = a.CreateDate,
                     Description = a.Description,
                     Status = a.Status,
                     Users = b
                 }).Where(p => p.Title.ToLower().Contains(title.ToLower())).ToListAsync();
            return lstPostView;
        }

        public async Task<bool> UpdatePost(Guid id, UpdatePost post)
        {
            var n = _context.Posts.Find(id);
            if (n == null) return false;
            n.Content = post.Content;
            n.Title = post.Title;
            n.Image = post.Image;
            n.Description = post.Description;
            n.Status = post.Status;
            try
            {
                _context.Update(n);
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