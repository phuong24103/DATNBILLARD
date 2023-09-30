using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.ProductViewModels
{
    public class UpdateProduct
    {
        public Guid MaterialId { get; set; }

        public Guid RenId { get; set; }

        public Guid HandleId { get; set; }

        public Guid TipId { get; set; }

        public Guid GripeId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public double ImportPrice { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public int AvailableQuantity { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public int Sold { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public DateTime CreateDate { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public string Producer { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public int Status { get; set; }

        public string Description { get; set; }
    }
}
