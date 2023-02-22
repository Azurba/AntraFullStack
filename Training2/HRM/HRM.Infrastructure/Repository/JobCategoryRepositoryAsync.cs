using System;
using HRM.ApllicationCore.Repository;
using HRM.ApplicationCore.Entity;
using HRM.Infrastructure.Data;

namespace HRM.Infrastructure.Repository
{
	public class JobCategoryRepositoryAsync: BaseRepositoryAsync<JobCategory>, IJobCategoryRepositoryAsync
	{
		public JobCategoryRepositoryAsync(HRMDbContext _context) : base(_context)
        {
		}
	}
}

