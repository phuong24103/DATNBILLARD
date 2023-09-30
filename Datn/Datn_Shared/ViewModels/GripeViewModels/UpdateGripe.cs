using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.GripeViewModels
{
    public class UpdateGripe
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
