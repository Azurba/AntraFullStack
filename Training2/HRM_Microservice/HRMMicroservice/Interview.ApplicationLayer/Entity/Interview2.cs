using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Interview.ApplicationLayer.Entity
{
    public class Interview2
    {
        public int InterviewId { get; set; }
        [Required]
        public int RecruiterId { get; set; }
        [Required]
        public int SubmissionId { get; set; }
        [Required]
        public InterviewType InterviewTypeCode { get; set; }
        [Required]
        public int InterviewRound { get; set; }
        [Required]
        public DateTime ScheduledOn { get; set; }
        [Required]
        public Interviewer InterviewerId { get; set; }
        [Required]
        public InterviewFeedback FeedbackId { get; set; }
    }
}
