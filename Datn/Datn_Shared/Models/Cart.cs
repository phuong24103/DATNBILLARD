﻿using System;
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
        public Guid UserId { get; set; }
        public string? Description { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; }
    }
}
