﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Onboard.ApplicationCore.Entity
{
    public class EmployeeCategory
    {
        public int Id { get; set; }
        [Required, Column(TypeName = "nvarchar(512)")]
        public string Description { get; set; }
    }
}
