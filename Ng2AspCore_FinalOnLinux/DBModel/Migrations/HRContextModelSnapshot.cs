using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Ng2AspCore.DBModel;

namespace Ng2AspCore_FinalOnLinux.DBModel.Migrations
{
    [DbContext(typeof(HRContext))]
    partial class HRContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ng2AspCore.DBModel.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDay");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Ng2AspCore.DBModel.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .HasMaxLength(100);

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Ng2AspCore.DBModel.RoleAssignment", b =>
                {
                    b.Property<int>("RoleAssignmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capacity");

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("End");

                    b.Property<string>("Position")
                        .HasMaxLength(30);

                    b.Property<int>("ProjectId");

                    b.Property<DateTime>("Start");

                    b.HasKey("RoleAssignmentId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("RoleAssignments");
                });

            modelBuilder.Entity("Ng2AspCore.DBModel.RoleAssignment", b =>
                {
                    b.HasOne("Ng2AspCore.DBModel.Employee", "Employee")
                        .WithMany("RoleAssignments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ng2AspCore.DBModel.Project", "Project")
                        .WithMany("RoleAssignments")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
