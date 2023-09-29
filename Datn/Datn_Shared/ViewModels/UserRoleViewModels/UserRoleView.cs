using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.UserRoleViewModels
{
    public class UserRoleView
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public string Discriminator { get; set; }
        public Role Role { get; set; }
    }
}