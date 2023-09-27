using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public  class UsedVoucher
    {
        [Key]
        public Guid BillId { get; set; }
        [ForeignKey("VoucherId")]
        public Guid VoucherId { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual Bill Bill { get; set; }  
    }
}
