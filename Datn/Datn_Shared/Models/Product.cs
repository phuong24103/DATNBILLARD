using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("MaterialId")]
        public Guid MaterialId { get; set; }
        [ForeignKey("RenId")]
        public Guid RenId { get; set; }
        [ForeignKey("HandleId")]
        public Guid HandleId { get; set; }
        [ForeignKey("TopId")]
        public Guid TopId { get; set; }
        [ForeignKey("GripeId")]
        public Guid GripeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double ImportPrice { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int AvailableQuantity { get; set; }
        [Required]
        public int Sold {  get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public string Producer { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        
        public virtual Material Material { get; set; }
        public  virtual Ren Ren { get; set; }
        public virtual Handle Handle { get; set; }
        public virtual Top Top { get; set; }
        public virtual Gripe Gripe { get; set; }
        public virtual ICollection <WishList> WishList { get; set; }
        public virtual ICollection <CartDetail> cartDetails { get; set; }
        public virtual ICollection<BillDetail> billDetails { get; set; }
        public virtual ICollection<CategoryDetail> categoryDetails { get; set; }


    }
}
