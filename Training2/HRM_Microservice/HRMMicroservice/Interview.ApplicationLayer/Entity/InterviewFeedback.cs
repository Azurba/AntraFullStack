using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationLayer.Entity
{
    public class InterviewFeedback
    {
        public int InterviewFeedbackId { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required, Column("varchar(500)")]
        public string Comment { get; set; }
    }
}