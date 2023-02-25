using System;
using Hrm.ApplicationCore.Entity;
using Hrm.Infrastructure.Data;
using Hrm.Infrastructure.Repository;
using HRM.ApllicationCore.Repository;
using HRM.ApplicationCore.Entity;

namespace HRM.Infrastructure.Repository
{
	public class JobCategoryRepositoryAsync: BaseRepositoryAsync<JobCategory>, IJobCategoryRepositoryAsync
	{
		public JobCategoryRepositoryAsync(HrmDbContext _context) : base(_context)
        {
		}
	}
}

