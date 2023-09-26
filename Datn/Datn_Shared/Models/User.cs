using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class User : IdentityUser<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("RoleId")]
        public Guid RoleId { get; set; }
        [ForeignKey("RankId")]
        public Guid RankId { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address{ get; set;}
        public int Point { get; set; }
        public int Status{ get; set;}
        public virtual Rank Rank { get; set;}
        public virtual Cart Cart { get; set;}
        public virtual ICollection<WishList> WishLists { get; set;}
        public virtual ICollection<Bill> Bills { get; set;}
    }
}
