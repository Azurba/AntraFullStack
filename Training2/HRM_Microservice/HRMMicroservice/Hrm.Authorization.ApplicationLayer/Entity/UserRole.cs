using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Authorization.ApplicationLayer.Entity
{
    public class UserRole
    {
        public int Id { get; set; }
        
        public Account UserId { get; set; }

        public RoleAuth RoleId { get; set; }
    }
}
