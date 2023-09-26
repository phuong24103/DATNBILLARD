using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public string Content {  get; set; }
        public string Title {  get; set; }
        public string   Image {  get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public virtual User User { get; set; }

    }
}
