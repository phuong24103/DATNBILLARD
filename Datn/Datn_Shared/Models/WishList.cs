using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class WishList
    {
        [Key]
        public Guid Id {  get; set; }
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
        public virtual User User { get; set; }
        public virtual Product  Product { get; set; }
    }
}
