using Hrm.Interview.ApplicationLayer.Entity;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Interview.Infrastructure.Data
{
    public class InterviewDbContext : DbContext
    {
        public InterviewDbContext(DbContextOptions<InterviewDbContext> options) : base(options)
        {

        }
        public DbSet<InterviewFeedback> InterviewFeedback { get; set; }
        public DbSet<Interviewer> Interviewer { get; set; }

        public DbSet<InterviewType> InterviewType { get; set; }

        public DbSet<Interview2> Interviews { get; set; }
    }
}
