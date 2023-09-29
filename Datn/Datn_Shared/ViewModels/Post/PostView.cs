using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.Post
{
    public class PostView
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public User User { get; set; }
    }
}
