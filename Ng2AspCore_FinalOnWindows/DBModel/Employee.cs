using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ng2AspCore.DBModel
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string FirstName  { get; set; }

        public string LastName  { get; set; }

        public DateTime BirthDay { get; set; }

        [InversePropertyAttribute("Employee")]
        public List<RoleAssignment> RoleAssignments { get; set; }
    }
}