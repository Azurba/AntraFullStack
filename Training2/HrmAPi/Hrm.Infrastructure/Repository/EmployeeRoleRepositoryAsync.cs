using System;
using Hrm.Infrastructure.Data;
using Hrm.Infrastructure.Repository;
using HRM.ApllicationCore.Repository;
using HRM.ApplicationCore.Entity;

namespace HRM.Infrastructure.Repository
{
	public class EmployeeRoleRepositoryAsync : BaseRepositoryAsync<EmployeeRole>, IEmployeeRoleRepositoryAsync
    {
		public EmployeeRoleRepositoryAsync(HrmDbContext _context) : base(_context)
        {
		}
	}
}

