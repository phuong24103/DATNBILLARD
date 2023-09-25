using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("RankId")]
        public Guid RankId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int Gender { get; set; }
        [RegularExpression(@"\d*[0-9]\d*", ErrorMessage = "The field PhoneNumber only has input number")]
        public string PhoneNumber { get; set; }
        [RegularExpression(@"^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@" + "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$", ErrorMessage = "Vui lòng nhập đúng email")]
        public string Email { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Address{ get; set;}
        [Required]
        public string Status{ get; set;}
        public int Point { get; set;}
     

        public virtual Rank Rank { get; set;}
        public virtual Cart Cart { get; set;}
        public virtual ICollection<WishList> WishList { get; set;}
        public  virtual ICollection<Product> Product { get; set;}
    }
}
