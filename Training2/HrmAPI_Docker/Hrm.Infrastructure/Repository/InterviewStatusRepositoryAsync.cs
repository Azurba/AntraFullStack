using System;
using HRM.ApplicationCore.Entity;
using HRM.ApllicationCore.Repository;
using Hrm.Infrastructure.Repository;
using Hrm.Infrastructure.Data;

namespace HRM.Infrastructure.Repository
{
	public class InterviewStatusRepositoryAsync : BaseRepositoryAsync<InterviewStatus>, IInterviewStatusRepositoryAsync
    {
		public InterviewStatusRepositoryAsync(HrmDbContext _context) : base(_context)
        {
		}
	}
}

