using System;
using HRM.ApplicationCore.Entity;
using HRM.ApllicationCore.Repository;
using Hrm.Infrastructure.Data;
using Hrm.Infrastructure.Repository;

namespace HRM.Infrastructure.Repository
{
	public class InterviewTypeRepositoryAsync : BaseRepositoryAsync<InterviewType>, IInterviewTypeRepositoryAsync
    {
		public InterviewTypeRepositoryAsync(HrmDbContext _context) : base(_context)
        {
		}
	}
}

