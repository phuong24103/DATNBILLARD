using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.UserViewModels
{
    public class UserView
    {
        public Guid Id { get; set; }
        public Guid RankId { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int Point { get; set; }
        public int Status { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string PhoneNumber { get; set; }

        public Rank Rank { get; set; }
        public Cart Cart { get; set; }
        public Post Posts { get; set; }
        public WishList WishLists { get; set; }
        public Bill Bills { get; set; }
    }
}