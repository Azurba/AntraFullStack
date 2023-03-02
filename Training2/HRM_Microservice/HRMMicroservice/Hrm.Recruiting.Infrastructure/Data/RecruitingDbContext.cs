using Hrm.Recruiting.ApplicationLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Recruiting.Infrastructure.Data
{
    public class RecruitingDbContext : DbContext
    {
        public RecruitingDbContext(DbContextOptions<RecruitingDbContext> options) : base(options)
        {

        }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobRequirement> JobRequirements { get; set; }
        public DbSet<Candidate> Candidate { set; get; }
        public DbSet<Submission> Submission { get; set; }
        public DbSet<SubmissionStatus> SubmissionStatus { get; set; }
    }
}
