using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Onboarding.ApplicationCore.Entity
{
    public class EmployeeRole
    {
        public int LookupCode { get; set; }
        [Column("varchar(50)")]
        public string Name { get; set; }
        [Column("varchar(50)")]
        public string ABBR { get; set; }
    }
}
