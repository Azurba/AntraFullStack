using System;
using HRM.ApplicationCore.Entity;
using HRM.ApllicationCore.Repository;
using Hrm.Infrastructure.Repository;
using Hrm.Infrastructure.Data;

namespace HRM.Infrastructure.Repository
{
	public class EmployeeTypeRepositoryAsync : BaseRepositoryAsync<EmployeeType>, IEmployeeTypeRepositoryAsync
    {
		public EmployeeTypeRepositoryAsync(HrmDbContext _context) : base(_context)
        {
		}
	}
}

