using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ng2AspCore.DBModel
{
    public class RoleAssignment
    {
        [Key]
        public int RoleAssignmentId { get; set; }

        [MaxLength(30)]
        public string Position { get; set; }

        public int Capacity { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }

    }
}