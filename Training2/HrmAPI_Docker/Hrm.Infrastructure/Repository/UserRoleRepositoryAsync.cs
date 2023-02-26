using System;
using HRM.ApplicationCore.Entity;
using HRM.ApllicationCore.Repository;
using Hrm.Infrastructure.Data;
using Hrm.Infrastructure.Repository;

namespace HRM.Infrastructure.Repository
{
	public class UserRoleRepositoryAsync : BaseRepositoryAsync<UserRole>, IUserRoleRepositoryAsync
    {
		public UserRoleRepositoryAsync(HrmDbContext _context) : base(_context)
        {
		}
	}
}

