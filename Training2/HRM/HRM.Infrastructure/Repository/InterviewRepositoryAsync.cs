using System;
using HRM.ApplicationCore.Entity;
using HRM.ApllicationCore.Repository;
using HRM.Infrastructure.Data;

namespace HRM.Infrastructure.Repository
{
	public class InterviewRepositoryAsync : BaseRepositoryAsync<InterviewTable>, IInterviewRepositoryAsync
    {
		public InterviewRepositoryAsync(HRMDbContext _context) : base(_context)
        {
		}
	}
}

