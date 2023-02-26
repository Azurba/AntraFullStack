using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Recruiting.ApplicationLayer.Entity
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        [Required]
        [Column("varchar(20)")]
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        [Column("varchar(25)")]
        public string LastName { get; set; }
        [Required]
        [Column("varchar(15)"), DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string? ResumeURL { get; set; }

    }
}
