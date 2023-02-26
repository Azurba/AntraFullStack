using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Onboarding.ApplicationCore.Entity
{
    public class EmployeeCategory
    {
        public int LookupCode { get; set; }
        [Column("varchar(512)")]
        public string Description { get; set; }
    }
}
