using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationLayer.Entity
{
    public class Interviewer
    {
        public int InterviewerId { get; set; }
        [Required, Column("varchar(128)")]
        public string FirstName { get; set; }
        [Required, Column("varchar(128)")]
        public string LastName { get; set; }
        [Required]
        public int EmployeeId { get; set; }
    }
}