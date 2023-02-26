using System;
using HRM.ApplicationCore.Entity;
using HRM.ApllicationCore.Repository;
using Hrm.Infrastructure.Data;
using Hrm.Infrastructure.Repository;

namespace HRM.Infrastructure.Repository
{
	public class RoleRepositoryAsync : BaseRepositoryAsync<Role>, IRoleRepositoryAsync
    {
		public RoleRepositoryAsync(HrmDbContext _context) : base(_context)
        {
		}
	}
}

