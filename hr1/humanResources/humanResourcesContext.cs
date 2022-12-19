using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace hr1.humanResources
{
    public partial class humanResourcesContext : DbContext
    {
        public humanResourcesContext()
        {
        }

        public humanResourcesContext(DbContextOptions<humanResourcesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<EfmigrationsHistory> EfmigrationsHistories { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; } = null!;
        public virtual DbSet<EmployeeStatus> EmployeeStatuses { get; set; } = null!;
        public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; } = null!;
        public virtual DbSet<Performance> Performances { get; set; } = null!;
        public virtual DbSet<Position> Positions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=humanResources;username=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.21-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.DeptId)
                    .HasColumnType("int(1)")
                    .HasColumnName("DeptID");

                entity.Property(e => e.Department1)
                    .HasMaxLength(20)
                    .HasColumnName("Department");
            });

            modelBuilder.Entity<EfmigrationsHistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__EFMigrationsHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ProductVersion).HasMaxLength(32);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PRIMARY");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.MaritalStatusId, "employees_ibfk_1");

                entity.HasIndex(e => e.PerfScoreId, "employees_ibfk_2");

                entity.HasIndex(e => e.DeptId, "employees_ibfk_3");

                entity.HasIndex(e => e.PositionId, "employees_ibfk_4");

                entity.HasIndex(e => e.EmpStatusId, "employees_ibfk_5");

                entity.Property(e => e.EmpId)
                    .HasColumnType("int(5)")
                    .HasColumnName("EmpID");

                entity.Property(e => e.Absences).HasColumnType("int(2)");

                entity.Property(e => e.DeptId)
                    .HasColumnType("int(1)")
                    .HasColumnName("DeptID");

                entity.Property(e => e.EmpStatusId)
                    .HasColumnType("int(1)")
                    .HasColumnName("EmpStatusID");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(25)
                    .HasColumnName("Employee_Name");

                entity.Property(e => e.MaritalStatusId)
                    .HasColumnType("int(1)")
                    .HasColumnName("MaritalStatusID");

                entity.Property(e => e.PerfScoreId)
                    .HasColumnType("int(1)")
                    .HasColumnName("PerfScoreID");

                entity.Property(e => e.PositionId)
                    .HasColumnType("int(2)")
                    .HasColumnName("PositionID");

                entity.Property(e => e.Salary).HasColumnType("int(6)");

                entity.Property(e => e.Sex).HasMaxLength(2);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("employees_ibfk_3");

                entity.HasOne(d => d.EmpStatus)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmpStatusId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("employees_ibfk_5");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("employees_ibfk_1");

                entity.HasOne(d => d.PerfScore)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PerfScoreId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("employees_ibfk_2");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("employees_ibfk_4");
            });

            modelBuilder.Entity<EmployeeDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee_details");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Absences).HasColumnType("int(2)");

                entity.Property(e => e.CitizenDesc).HasMaxLength(19);

                entity.Property(e => e.DateofHire).HasMaxLength(10);

                entity.Property(e => e.DateofTermination).HasMaxLength(10);

                entity.Property(e => e.DaysLateLast30).HasColumnType("int(1)");

                entity.Property(e => e.Department).HasMaxLength(20);

                entity.Property(e => e.DeptId)
                    .HasColumnType("int(1)")
                    .HasColumnName("DeptID");

                entity.Property(e => e.Dob)
                    .HasMaxLength(8)
                    .HasColumnName("DOB");

                entity.Property(e => e.EmpId)
                    .HasColumnType("int(5)")
                    .HasColumnName("EmpID");

                entity.Property(e => e.EmpSatisfaction).HasColumnType("int(1)");

                entity.Property(e => e.EmpStatusId)
                    .HasColumnType("int(1)")
                    .HasColumnName("EmpStatusID");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(25)
                    .HasColumnName("Employee_Name");

                entity.Property(e => e.EmploymentStatus).HasMaxLength(22);

                entity.Property(e => e.EngagementSurvey).HasPrecision(3, 2);

                entity.Property(e => e.FromDiversityJobFairId)
                    .HasColumnType("int(1)")
                    .HasColumnName("FromDiversityJobFairID");

                entity.Property(e => e.GenderId)
                    .HasColumnType("int(1)")
                    .HasColumnName("GenderID");

                entity.Property(e => e.HispanicLatino).HasMaxLength(3);

                entity.Property(e => e.LastPerformanceReviewDate)
                    .HasMaxLength(10)
                    .HasColumnName("LastPerformanceReview_Date");

                entity.Property(e => e.ManagerId)
                    .HasMaxLength(2)
                    .HasColumnName("ManagerID");

                entity.Property(e => e.ManagerName).HasMaxLength(18);

                entity.Property(e => e.MaritalDesc).HasMaxLength(9);

                entity.Property(e => e.MaritalStatusId)
                    .HasColumnType("int(1)")
                    .HasColumnName("MaritalStatusID");

                entity.Property(e => e.MarriedId)
                    .HasColumnType("int(1)")
                    .HasColumnName("MarriedID");

                entity.Property(e => e.PerfScoreId)
                    .HasColumnType("int(1)")
                    .HasColumnName("PerfScoreID");

                entity.Property(e => e.PerformanceScore).HasMaxLength(17);

                entity.Property(e => e.Position).HasMaxLength(28);

                entity.Property(e => e.PositionId)
                    .HasColumnType("int(2)")
                    .HasColumnName("PositionID");

                entity.Property(e => e.RaceDesc).HasMaxLength(32);

                entity.Property(e => e.RecruitmentSource).HasMaxLength(23);

                entity.Property(e => e.Salary).HasColumnType("int(6)");

                entity.Property(e => e.Sex).HasMaxLength(2);

                entity.Property(e => e.SpecialProjectsCount).HasColumnType("int(1)");

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.TermReason).HasMaxLength(32);

                entity.Property(e => e.Termd).HasColumnType("int(1)");

                entity.Property(e => e.Zip).HasMaxLength(5);
            });

            modelBuilder.Entity<EmployeeStatus>(entity =>
            {
                entity.HasKey(e => e.EmpStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("Employee Status");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.EmpStatusId)
                    .HasColumnType("int(1)")
                    .HasColumnName("EmpStatusID");

                entity.Property(e => e.EmploymentStatus).HasMaxLength(22);
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.ToTable("Marital Status");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.MaritalStatusId)
                    .HasColumnType("int(1)")
                    .ValueGeneratedNever()
                    .HasColumnName("MaritalStatusID");

                entity.Property(e => e.MaritalDesc).HasMaxLength(9);
            });

            modelBuilder.Entity<Performance>(entity =>
            {
                entity.HasKey(e => e.PerfScoreId)
                    .HasName("PRIMARY");

                entity.ToTable("Performance");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.PerfScoreId)
                    .HasColumnType("int(1)")
                    .HasColumnName("PerfScoreID");

                entity.Property(e => e.PerformanceScore).HasMaxLength(17);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("positions");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.PositionId)
                    .HasColumnType("int(2)")
                    .ValueGeneratedNever()
                    .HasColumnName("PositionID");

                entity.Property(e => e.Position1)
                    .HasMaxLength(28)
                    .HasColumnName("Position");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
