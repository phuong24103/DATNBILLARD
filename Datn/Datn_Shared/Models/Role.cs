using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string RoleName   { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual ICollection<Employee> Employees { get; set;}


    }
}
