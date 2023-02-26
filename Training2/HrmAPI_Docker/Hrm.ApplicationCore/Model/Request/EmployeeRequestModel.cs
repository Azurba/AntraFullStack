using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRM.ApllicationCore.Model.Request
{
	public class EmployeeRequestModel
	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmailId { get; set; }
        public DateTime DOB { get; set; }
        public int SSN { get; set; }
        public string CurrentAddress { get; set; }
        public string Phone { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EmployeeRoleId { get; set; }
        public int EmployeeTypeId { get; set; }
        public int EmployeeStatusId { get; set; }
        public int ManagerId { get; set; }
	}
}

