using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hr1.Migrations
{
    public partial class Position : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "humanresources");

            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: " Employee Status",
                schema: "humanresources",
                columns: table => new
                {
                    EmpStatusID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    EmploymentStatus = table.Column<string>(type: "varchar(22)", maxLength: 22, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Departments",
                schema: "humanresources",
                columns: table => new
                {
                    DeptID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    Department = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "employee_details",
                schema: "humanresources",
                columns: table => new
                {
                    Employee_Name = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmpID = table.Column<int>(type: "int(5)", nullable: true, defaultValueSql: "'NULL'"),
                    MarriedID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    MaritalStatusID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    GenderID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    EmpStatusID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    DeptID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    PerfScoreID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    FromDiversityJobFairID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    Salary = table.Column<int>(type: "int(6)", nullable: true, defaultValueSql: "'NULL'"),
                    Termd = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    PositionID = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'"),
                    Position = table.Column<string>(type: "varchar(28)", maxLength: 28, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Zip = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DOB = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sex = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MaritalDesc = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CitizenDesc = table.Column<string>(type: "varchar(19)", maxLength: 19, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HispanicLatino = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RaceDesc = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateofHire = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateofTermination = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TermReason = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmploymentStatus = table.Column<string>(type: "varchar(22)", maxLength: 22, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Department = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ManagerName = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ManagerID = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RecruitmentSource = table.Column<string>(type: "varchar(23)", maxLength: 23, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PerformanceScore = table.Column<string>(type: "varchar(17)", maxLength: 17, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EngagementSurvey = table.Column<decimal>(type: "decimal(3,2)", nullable: true, defaultValueSql: "'NULL'"),
                    EmpSatisfaction = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    SpecialProjectsCount = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    LastPerformanceReview_Date = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DaysLateLast30 = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    Absences = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "humanresources",
                columns: table => new
                {
                    EmpID = table.Column<int>(type: "int(5)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Employee_Name = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sex = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MaritalStatusID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    PositionID = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'"),
                    DeptID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    Salary = table.Column<int>(type: "int(6)", nullable: true, defaultValueSql: "'NULL'"),
                    PerfScoreID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    EmpStatusID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    Absences = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'"),
                    Position = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.EmpID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Marital Status",
                schema: "humanresources",
                columns: table => new
                {
                    MaritalStatusID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    MaritalDesc = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Performance",
                schema: "humanresources",
                columns: table => new
                {
                    PerfScoreID = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'NULL'"),
                    PerformanceScore = table.Column<string>(type: "varchar(17)", maxLength: 17, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "positions",
                schema: "humanresources",
                columns: table => new
                {
                    PositionID = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'NULL'"),
                    Position = table.Column<string>(type: "varchar(28)", maxLength: 28, nullable: true, defaultValueSql: "'NULL'")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: " Employee Status",
                schema: "humanresources");

            migrationBuilder.DropTable(
                name: "Departments",
                schema: "humanresources");

            migrationBuilder.DropTable(
                name: "employee_details",
                schema: "humanresources");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "humanresources");

            migrationBuilder.DropTable(
                name: "Marital Status",
                schema: "humanresources");

            migrationBuilder.DropTable(
                name: "Performance",
                schema: "humanresources");

            migrationBuilder.DropTable(
                name: "positions",
                schema: "humanresources");
        }
    }
}
