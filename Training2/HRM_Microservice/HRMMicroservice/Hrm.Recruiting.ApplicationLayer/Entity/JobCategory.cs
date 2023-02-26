using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Recruiting.ApplicationLayer.Entity
{
    public class JobCategory
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Title { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
