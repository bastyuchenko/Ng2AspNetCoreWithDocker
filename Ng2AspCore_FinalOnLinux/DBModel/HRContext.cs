using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ng2AspCore.DBModel
{
    public class HRContext : DbContext
    {
        public HRContext(DbContextOptions<HRContext> options)
            : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<RoleAssignment> RoleAssignments { get; set; }
    }
}