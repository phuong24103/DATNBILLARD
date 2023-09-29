using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.UserViewModels
{
    public class CreateUser
    {
        public Guid Id { get; set; }
        public Guid RankId { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int Point { get; set; }
        public int Status { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PassWord { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
    }
}