using System;
using HRM.ApplicationCore.Entity;
using HRM.ApllicationCore.Repository;
using HRM.Infrastructure.Data;

namespace HRM.Infrastructure.Repository
{
	public class SubmissionRepositoryAsync : BaseRepositoryAsync<Submission>, ISubmissionRepositoryAsync
    {
		public SubmissionRepositoryAsync(HRMDbContext _context) : base(_context)
        {
		}
	}
}

