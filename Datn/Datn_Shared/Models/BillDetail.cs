using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class BillDetail
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("BillId")]
        public Guid BillId { get; set; }
        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }


    }
}
