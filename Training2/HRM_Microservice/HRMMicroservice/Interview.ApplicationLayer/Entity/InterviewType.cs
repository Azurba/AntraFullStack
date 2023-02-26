using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationLayer.Entity
{
    public class InterviewType
    {
        public int LookupCode { get; set; }
        [Column("varchar(500)")]
        public string Description { get; set; }
    }
}