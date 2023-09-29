using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.PostViewModels
{
    public class CreatePost
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public string? Content { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tiêu đề")]
        public string? Title { get; set; }

        public string? Image { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập trạng thái")]
        public int Status { get; set; }
    }
}