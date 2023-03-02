using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Authorization.ApplicationLayer.Entity
{
    public class RoleAuth
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
