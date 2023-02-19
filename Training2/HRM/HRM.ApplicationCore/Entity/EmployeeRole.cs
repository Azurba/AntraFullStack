using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApplicationCore.Entity
{
    public class EmployeeRole
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActived { get; set; }

    }
}
