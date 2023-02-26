using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Onboarding.ApplicationCore.Entity
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required, Column("varchar(128)")]
        public string FirstName { get; set; }
        [Column("varchar(128)")]
        public string? MiddleName { get; set; }
        [Required, Column("varchar(128)")]
        public string LastName { get; set; }
        [Required, Column("varchar(9)")]
        public string SSN { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public EmployeeCategory EmployeeCategoryCode { get; set; }
        [Required]
        public EmployeeStatus EmployeeStatusCode { get; set; }
        public string Address { get; set; }
        [Required, Column("varchar(500)")]
        public string Email { get; set; }
        public EmployeeRole EmployeeRoleId { get; set; }
        
        

    }
}
