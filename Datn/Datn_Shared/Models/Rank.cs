using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public  class Rank
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [RegularExpression(@"\d*[aA-zZ]\d*", ErrorMessage = "The field Name only has input number")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"\d*[0-9]\d*", ErrorMessage = "The field NecessaryPoints only has input number")]
        public int NecessaryPoints {  get; set; }
        public string Description { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
