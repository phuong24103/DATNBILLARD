using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class Bill
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("CustomerId")]
        public Guid CustomerId { get; set; }
        [ForeignKey("EmployeeId")]
        public Guid EmployeeId { get; set; }
        [ForeignKey("VoucherId")]
        public Guid VoucherId { get; set; }
        [ForeignKey("BillStatusId")]
        public Guid BillStatusId { get; set; }
        [ForeignKey("PaymentId")]
        public Guid PaymentId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public string Address { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Voucher Voucher { get; set; }
        public virtual BillStatus BillStatus { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual  ICollection<BillDetail> BillDetails { get; set; }    

    }
}
