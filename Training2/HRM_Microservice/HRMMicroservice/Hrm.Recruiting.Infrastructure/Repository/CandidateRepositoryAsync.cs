using Hrm.Recruiting.ApplicationLayer.Contract.Repository;
using Hrm.Recruiting.ApplicationLayer.Entity;
using Hrm.Recruiting.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Recruiting.Infrastructure.Repository
{
    public class CandidateRepositoryAsync : BaseRepositoryAsync<Candidate>, ICandidateRepositoryAsync
    {
        public CandidateRepositoryAsync(RecruitingDbContext _context) : base(_context)
        {
        }
    }
}
