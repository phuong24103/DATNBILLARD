using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class Cart
    {
        [Key]
        public Guid CustomerId { get; set; }
        public string Description { get; set; }
        public virtual Customer Customer { get; set; }
       public virtual ICollection<CartDetail> cartDetails { get; set; }

    }
}
