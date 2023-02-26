using System;
using HRM.ApplicationCore.Entity;
using HRM.ApllicationCore.Repository;
using Hrm.Infrastructure.Repository;
using Hrm.Infrastructure.Data;

namespace HRM.Infrastructure.Repository
{
	public class InterviewRepositoryAsync : BaseRepositoryAsync<InterviewTable>, IInterviewRepositoryAsync
    {
		public InterviewRepositoryAsync(HrmDbContext _context) : base(_context)
        {
		}
	}
}

