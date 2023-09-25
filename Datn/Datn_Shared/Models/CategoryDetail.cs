using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class CategoryDetail
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("CategoryId")]
        public Guid CategoryId { get; set; }
        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
        public int QuantityProduct { get; set; }
        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }

    }
}
