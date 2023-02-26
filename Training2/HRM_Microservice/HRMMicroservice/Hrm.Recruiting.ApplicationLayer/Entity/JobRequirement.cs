using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Recruiting.ApplicationLayer.Entity
{
    public class JobRequirement
    {
        public int Id { get; set; }
        [Required]
        [Column("varchar(100)")]
        public string Title { get; set; }
        [Required]
        public int TotalPositions { get; set; }
        [Required]
        [Column("varchar(500)")]
        public string? Description { get; set; }
        [Required]
        public int HiringManagerId { get; set; }
        [Required]
        [Column("varchar(50)")]
        public string HiringManagerName { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime ClosedOn { get; set; }
        public string? CloasingReason { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.Now; //default value
        [Required]
        public int JobCategoryId { get; set; }
        public int EmploymentType { get; set; }

        //Navigation Property
        public JobCategory jobCategory { get; set; }

    }
}
