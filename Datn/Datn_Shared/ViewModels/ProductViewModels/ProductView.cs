using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.ProductViewModels
{
    public class ProductView
    {
        public Guid Id { get; set; }

        public Guid MaterialId { get; set; }
  
        public Guid RenId { get; set; }
    
        public Guid HandleId { get; set; }
      
        public Guid TipId { get; set; }
   
        public Guid GripeId { get; set; }
        public string Name { get; set; }
        public double ImportPrice { get; set; }
        public double Price { get; set; }
        public int AvailableQuantity { get; set; }
        public int Sold { get; set; }
        public string Image { get; set; }
        public DateTime CreateDate { get; set; }
        public string Producer { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }

        public  Material Material { get; set; }
        public  Ren Ren { get; set; }
        public  Handle Handle { get; set; }
        public  Tip Tip { get; set; }
        public  Gripe Gripe { get; set; }
    }
}
