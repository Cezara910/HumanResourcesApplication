﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hr1.humanResources;

#nullable disable

namespace hr1.Migrations
{
    [DbContext(typeof(humanResourcesContext))]
    partial class humanResourcesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("hr1.humanResources.Department", b =>
                {
                    b.Property<string>("Department1")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Department")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("DeptID")
                        .HasDefaultValueSql("'NULL'");

                    b.ToTable("Departments", "humanresources");
                });

            modelBuilder.Entity("hr1.humanResources.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(5)")
                        .HasColumnName("EmpID");

                    b.Property<int?>("Absences")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Department")
                        .HasColumnType("longtext");

                    b.Property<int?>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("DeptID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("EmpStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("EmpStatusID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("EmployeeName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("Employee_Name")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("EmployeeStatus")
                        .HasColumnType("longtext");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("longtext");

                    b.Property<int?>("MaritalStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("MaritalStatusID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("PerfScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("PerfScoreID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("PerformanceScore")
                        .HasColumnType("longtext");

                    b.Property<string>("Position")
                        .HasColumnType("longtext");

                    b.Property<int?>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(2)")
                        .HasColumnName("PositionID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("Salary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(6)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Sex")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.HasKey("EmpId")
                        .HasName("PRIMARY");

                    b.ToTable("Employees", "humanresources");
                });

            modelBuilder.Entity("hr1.humanResources.EmployeeDetail", b =>
                {
                    b.Property<int?>("Absences")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("CitizenDesc")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(19)
                        .HasColumnType("varchar(19)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("DateofHire")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("DateofTermination")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("DaysLateLast30")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Department")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("DeptID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Dob")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("DOB")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(5)")
                        .HasColumnName("EmpID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("EmpSatisfaction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("EmpStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("EmpStatusID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("EmployeeName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("Employee_Name")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("EmploymentStatus")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(22)
                        .HasColumnType("varchar(22)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<decimal?>("EngagementSurvey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3,2)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("FromDiversityJobFairId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("FromDiversityJobFairID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("GenderID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("HispanicLatino")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("LastPerformanceReviewDate")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("LastPerformanceReview_Date")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("ManagerID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("ManagerName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(18)
                        .HasColumnType("varchar(18)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("MaritalDesc")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(9)
                        .HasColumnType("varchar(9)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("MaritalStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("MaritalStatusID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("MarriedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("MarriedID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("PerfScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("PerfScoreID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("PerformanceScore")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(17)
                        .HasColumnType("varchar(17)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Position")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(28)
                        .HasColumnType("varchar(28)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(2)")
                        .HasColumnName("PositionID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("RaceDesc")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("RecruitmentSource")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(23)
                        .HasColumnType("varchar(23)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("Salary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(6)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Sex")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("SpecialProjectsCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("State")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("TermReason")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("Termd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Zip")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)")
                        .HasDefaultValueSql("'NULL'");

                    b.ToTable("employee_details", "humanresources");
                });

            modelBuilder.Entity("hr1.humanResources.EmployeeStatus", b =>
                {
                    b.Property<int?>("EmpStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("EmpStatusID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("EmploymentStatus")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(22)
                        .HasColumnType("varchar(22)")
                        .HasDefaultValueSql("'NULL'");

                    b.ToTable(" Employee Status", "humanresources");
                });

            modelBuilder.Entity("hr1.humanResources.MaritalStatus", b =>
                {
                    b.Property<string>("MaritalDesc")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(9)
                        .HasColumnType("varchar(9)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("MaritalStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("MaritalStatusID")
                        .HasDefaultValueSql("'NULL'");

                    b.ToTable("Marital Status", "humanresources");
                });

            modelBuilder.Entity("hr1.humanResources.Performance", b =>
                {
                    b.Property<int?>("PerfScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(1)")
                        .HasColumnName("PerfScoreID")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("PerformanceScore")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(17)
                        .HasColumnType("varchar(17)")
                        .HasDefaultValueSql("'NULL'");

                    b.ToTable("Performance", "humanresources");
                });

            modelBuilder.Entity("hr1.humanResources.Position", b =>
                {
                    b.Property<string>("Position1")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(28)
                        .HasColumnType("varchar(28)")
                        .HasColumnName("Position")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int?>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(2)")
                        .HasColumnName("PositionID")
                        .HasDefaultValueSql("'NULL'");

                    b.ToTable("positions", "humanresources");
                });
#pragma warning restore 612, 618
        }
    }
}
